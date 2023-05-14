using KranumCore.ViewResource.Resource;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KranumCore.BlobHandler
{
    public class BlobManager : IBlobManager
    {
        private readonly IConfiguration _configuration;
        private readonly string blobstorageconnection;
        private readonly string containerName;
        public BlobManager(IConfiguration configuration)
        {
            _configuration = configuration;
            blobstorageconnection = _configuration.GetValue<string>("blobstorage");
            containerName = _configuration.GetValue<string>("containerName");
        }
        public async Task<List<UploadedFileViewResource>> UploadAsync(List<IFormFile> formFiles, string DefaultUUID = "")
        {
            try
            {
                var uploadedFiles = new List<UploadedFileViewResource>();
                if (formFiles != null && formFiles.Count > 0)
                {
                    foreach (var formFile in formFiles)
                    {
                        var uuid = Guid.NewGuid().ToString();

                        if (DefaultUUID != "")
                        {
                            uuid = DefaultUUID;
                        }

                        byte[] dataFiles;
                        var cloudBlobContainer = GetCloudBlobContainer();
                        await cloudBlobContainer.CreateIfNotExistsAsync();

                        BlobContainerPermissions permissions = new BlobContainerPermissions
                        {
                            PublicAccess = BlobContainerPublicAccessType.Blob
                        };

                        string originalFileName = formFile.FileName;

                        FileInfo fi = new FileInfo(originalFileName);
                        string fileExtn = fi.Extension;

                        string fileType = formFile.ContentType;
                        string storageFileName = $"{uuid}{fileExtn}";
                        long fileSize = formFile.Length;
                        await cloudBlobContainer.SetPermissionsAsync(permissions);
                        var target = new MemoryStream();

                        formFile.CopyTo(target);
                        dataFiles = target.ToArray();

                        CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(storageFileName.ToLower());
                        await cloudBlockBlob.UploadFromByteArrayAsync(dataFiles, 0, dataFiles.Length);
                        uploadedFiles.Add(new UploadedFileViewResource()
                        {
                            Uuid = uuid,
                            FileSize = fileSize,
                            FileType = fileType,
                            OriginalFileName = originalFileName,
                            StorageFileName = storageFileName
                        });
                    }
                }

                return uploadedFiles;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<MemoryStream> DownloadAsync(string fileName)
        {
            var cloudBlobContainer = GetCloudBlobContainer();
            var blob = cloudBlobContainer.GetBlockBlobReference(fileName.ToLower());
            if (await blob.ExistsAsync())
            {
                var targetStream = new MemoryStream();
                await blob.DownloadToStreamAsync(targetStream);

                return targetStream;
            }

            return null;
        }

        public async Task DeleteAsync(string fileName)
        {
            if (!(string.IsNullOrEmpty(fileName)))
            {
                var cloudBlobContainer = GetCloudBlobContainer();
                CloudBlockBlob blob = cloudBlobContainer.GetBlockBlobReference(fileName);
                await blob.DeleteIfExistsAsync();
            }
        }

        private CloudBlobContainer GetCloudBlobContainer()
        {
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(blobstorageconnection);
            CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            return cloudBlobContainer;
        }
    }
}
