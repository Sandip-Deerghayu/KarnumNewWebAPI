using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.AgencyInorm
{
    public class AgencyInormViewResource
    {
        public int Id { get; set; }        
        public string Uuid { get; set; }
        public string UserUUId { get; set; }
        [Required]
        [StringLength(200)]
        public string ChannelName { get; set; }
        public string Bio { get; set; }
        public string WebsiteUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstaLink { get; set; }
        public DateTime? CreatedDate { get; set; }        
        public DateTime? ModifiedDate { get; set; }       
        public string ChannelImageUUID { get; set; }
        public string ChannelCreatorImageUUID { get; set; }
        public string ChannelImageName { get; set; }
        public string ChannelCreatorImageName { get; set; }
        public int CategoryId { get; set; }
        public int VideoCount { get; set; }
        public int PodcastCount { get; set; }
        public string UserName { get; set; }
    }
}
