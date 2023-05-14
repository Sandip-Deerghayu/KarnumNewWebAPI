using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KranumCore.ViewResource.Channel
{
    public class CreateChannelRequestViewResource
    {
        [Required]
        [StringLength(200)]

        public string UserUUId { get; set; }
        public string ChannelName { get; set; }
        public int ClientId { get; set; }
        public string Bio { get; set; }
        public int CategoryId { get; set; }
        public string FacebookUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public string InstaLink { get; set; }
        public bool? isActive { get; set; }
        public int VideoCount { get; set; }
        public int PodcastCount { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<IFormFile> ChannelImage { get; set; }
        public List<IFormFile> ChannelCreatorImage { get; set; }
        public DateTime ModifiedDate { get; set; }
        
    }
}
