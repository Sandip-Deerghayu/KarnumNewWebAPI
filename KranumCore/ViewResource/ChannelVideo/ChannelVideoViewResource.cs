using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.ChannelVideo
{
    public class ChannelVideoViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string UserUUId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        public string VideoName { get; set; }
        public string Description { get; set; }

        public string VideoLink { get; set; }
        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public string VideoCoverImageUUID { get; set; }

        public string VideoCoverImageName { get; set; }

        public int ChannelId { get; set; }

    }
}