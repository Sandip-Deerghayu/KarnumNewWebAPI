using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Podcast
{
    public class UpdatePodcastRequestViewResource
    {
        [Required]
        [StringLength(200)]
        public string Uuid { get; set; }

        [Required]
        [StringLength(255)]
        public string PodcastName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public string ChannelUUId { get; set; }
        public string SpotifyLink { get; set; }
        public string GoogleLink { get; set; }
        public string ApplePodcastLink { get; set; }

        public List<IFormFile> FileURL { get; set; }
        public List<IFormFile> PodcastCoverImage { get; set; }
    }
}