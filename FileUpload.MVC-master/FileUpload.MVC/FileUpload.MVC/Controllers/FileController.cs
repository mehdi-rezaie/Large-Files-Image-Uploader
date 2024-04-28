using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileUpload.MVC.Data;
using FileUpload.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using Microsoft.CodeAnalysis;

namespace FileUpload.MVC.Controllers
{
    public class FileController : Controller
    {
        private readonly ApplicationDbContext context;

        public FileController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index(string ProductId, int currentPage = 1, int pageSize = 5)
        {
            var totalFiles = await context.FilesOnFileSystem.Where(x => x.ProductID == ProductId).CountAsync();
            var files = await context.FilesOnFileSystem
                                    .Where(x => x.ProductID == ProductId)
                                    .Skip((currentPage - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            var fileuploadViewModel = new FileUploadViewModel
            {
                FilesOnFileSystem = files,
                CurrentPage = currentPage,
                TotalPages = (int)Math.Ceiling(totalFiles / (double)pageSize)
            };

            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }

        [HttpPost, DisableRequestSizeLimit, RequestFormLimits(MultipartBodyLengthLimit = long.MaxValue, ValueLengthLimit = Int32.MaxValue)]
        public async Task<IActionResult> UploadToFileSystem(List<IFormFile> files, string ProductId, List<int> displaySequences)
        {
            var response = false;
            if (files == null || files.Count == 0)
            {
                TempData["Message"] = "No files received.";
                //return RedirectToAction("Index");
                return Json(response);
            }

            // Create a directory path based on the description
            var productFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Files", ProductId);
            if (!Directory.Exists(productFolderPath))
            {
                Directory.CreateDirectory(productFolderPath);
            }

            for (int i = 0; i < files.Count; i++)
            {
                var file = files[i];
                var displaySequence = displaySequences[i];
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var filePath = Path.Combine(productFolderPath, file.FileName);
                var extension = Path.GetExtension(file.FileName);

                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    var imageInfo = GetImageInfo(filePath);

                    var fileModel = new FileOnFileSystemModel
                    {
                        CreatedOn = DateTime.Now,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        ProductID = ProductId,
                        FilePath = filePath,
                        DisplaySequence = displaySequence,
                        Height = imageInfo.Height,
                        Width = imageInfo.Width,
                        Size = imageInfo.SizeKB
                    };

                    context.FilesOnFileSystem.Add(fileModel);
                }
            }

            await context.SaveChangesAsync();
            TempData["Message"] = "File(s) uploaded successfully";

            //return RedirectToAction("Index");

            return Json(new { response = true, message = "File(s) successfully uploaded to File System." });

        }


        private ImageInfo GetImageInfo(string imagePath)
        {
            using (var image = Image.FromFile(imagePath))
            {
                var info = new Models.ImageInfo
                {
                    Width = image.Width,
                    Height = image.Height,
                    SizeKB = new FileInfo(imagePath).Length / 1024 // Size in KB
                };

                return info;
            }
        }


        //Download file
        public async Task<IActionResult?> DownloadFileFromFileSystem(int id)
        {

            var file = await context.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            var memory = new MemoryStream();
            using (var stream = new FileStream(file.FilePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, file.FileType, file.Name + file.Extension);
        }

        //Delete File
        public async Task<IActionResult?> DeleteFileFromFileSystem(int id)
        {

            var file = await context.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            if (System.IO.File.Exists(file.FilePath))
            {
                System.IO.File.Delete(file.FilePath);
            }
            context.FilesOnFileSystem.Remove(file);
            context.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from File System.";
            return RedirectToAction("Index");
        }

        //Refresh uploaded file
        public async Task<IActionResult> FileListPartial(string ProductId, int currentPage = 1, int pageSize = 5)
        {
            var totalFiles = await context.FilesOnFileSystem.Where(x => x.ProductID == ProductId).CountAsync();
            var files = await context.FilesOnFileSystem
                                    .Where(x => x.ProductID == ProductId)
                                    .Skip((currentPage - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            var fileuploadViewModel = new FileUploadViewModel
            {
                FilesOnFileSystem = files,
                CurrentPage = currentPage,
                TotalPages = (int)Math.Ceiling(totalFiles / (double)pageSize)
            };

            return PartialView("_FileListPartial", fileuploadViewModel);
        }

        //Preview uploaded file in the list
        public async Task<IActionResult> ImagePreview(int id)
        {
            var file = await context.FilesOnFileSystem.FirstOrDefaultAsync(f => f.Id == id);
            if (file == null || !System.IO.File.Exists(file.FilePath))
            {
                // Handle the case where the file doesn't exist
                return NotFound();
            }

            var imageFileStream = System.IO.File.OpenRead(file.FilePath);
            return File(imageFileStream, file.FileType);
        }


    }
}