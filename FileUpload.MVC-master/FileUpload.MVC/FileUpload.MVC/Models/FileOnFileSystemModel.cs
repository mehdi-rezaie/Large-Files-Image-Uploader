﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.MVC.Models
{
    public class FileOnFileSystemModel : FileModel
    {
        public required string FilePath { get; set; }
    }
}
