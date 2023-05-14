using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Channel
{
    public class UpdateChannelRequestViewResource
    {
        [Required]
        [StringLength(200)]

        public string Uuid { get; set; }
        public int Id { get; set; }   
        public string ChannelName { get; set; }
        public int UserId { get; set; }
        public string Bio { get; set; }
        public string FacebookUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public string InstaLink { get; set; }
        public int VideoCount { get; set; }
        public int PodcastCount { get; set; }
        public string DeleteCreatorImageUuid { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<IFormFile> ChannelImage { get; set; }
        public List<IFormFile> ChannelCreatorImage { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CategoryId { get; set; }


    }
}
