using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace KranumCore.ViewResource.Resource
{
    public class ResourceViewResource
    {
        public int Id { get; set; }

        public int? ClientId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }
        public int? AssociatedClientId { get; set; }
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Uuid { get; set; }
        public bool? IsHosted { get; set; }
        [StringLength(255)]
        public string HostedUrl { get; set; }
        public string BuyNowUrl { get; set; }
        public bool? IsMedia { get; set; }
        public bool? IsAudio { get; set; }
        public bool? IsDownloadable { get; set; }

        [StringLength(512)]
        public string OriginalFileName { get; set; }
        [StringLength(512)]
        public string StorageFileName { get; set; }
        public long? FileSize { get; set; }
        [StringLength(200)]
        public string FileType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
