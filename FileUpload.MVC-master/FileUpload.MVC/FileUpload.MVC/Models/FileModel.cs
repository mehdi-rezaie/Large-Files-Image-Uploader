using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.MVC.Models
{
    public abstract class FileModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string FileType { get; set; }
        public required string Extension { get; set; }
        public required string ProductID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int DisplaySequence { get; set; }
        public long Height { get; set; }
        public long Width { get; set; }
        public long Size { get; set; }
    }
}
