using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace KranumCore.ViewResource.Resource
{
    public class UploadedFileViewResource
    {
        public string Uuid { get; set; }
        public string OriginalFileName { get; set; }
        public string StorageFileName { get; set; }
        public long? FileSize { get; set; }
        public string FileType { get; set; }
        public MemoryStream MemoryStream { get; set; }
    }
}
