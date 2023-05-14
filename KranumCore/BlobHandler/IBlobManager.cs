using KranumCore.ViewResource.Resource;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KranumCore.BlobHandler
{
    public interface IBlobManager
    {
        Task<List<UploadedFileViewResource>> UploadAsync(List<IFormFile> formFiles, string DefaultUUID = "");
        Task DeleteAsync(string fileName);

        Task<MemoryStream> DownloadAsync(string fileName);
    }   
}
