using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace KranumCore.ViewResource.Resource
{
    public class CreateResourceRequestViewResource
    {
        public string ClientUUId { get; set; }
        public string AssociatedClientUUID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool? IsHosted { get; set; }
        [StringLength(255)]
        public string HostedUrl { get; set; }
        public bool? IsMedia { get; set; }

        public bool? IsAudio { get; set; }

        public bool? IsDownloadable { get; set; }
        public int? CreatedBy { get; set; }
        public List<IFormFile> ResourceFile { get; set; }
        public string BuyNowUrl { get; set; }
    }
}
