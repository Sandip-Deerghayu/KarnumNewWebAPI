using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.ChannelVideo
{
    public class UpdateChannelVideoRequestViewResource
    {
        [Required]
        [StringLength(200)]
        public string Uuid { get; set; }

        [Required]
        [StringLength(255)]
        public string VideoName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string ChannelUUId { get; set; }
        public string VideoLink { get; set; }

        public List<IFormFile> VideoCoverImage { get; set; }
    }
}