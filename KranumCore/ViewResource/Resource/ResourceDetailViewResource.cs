using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Security.Principal;

namespace KranumCore.ViewResource.Resource
{
    public class ResourceDetailViewResource
    {
        public string ClientUUID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public string AssociatedClientUUID { get; set; }

        public string AssociatedClientName { get; set; }

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
        public long? FileSize { get; set; }
        [StringLength(200)]
        public string FileType { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
