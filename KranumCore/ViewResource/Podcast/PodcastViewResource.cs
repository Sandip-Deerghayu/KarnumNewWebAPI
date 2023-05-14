using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Podcast
{
    public class PodcastViewResource
    {
        public int Id { get; set; }

        public string Uuid { get; set; }
        public string UserUUId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        public string PodcastName { get; set; }
        public string Description { get; set; }

        public string SpotifyLink { get; set; }
        public string GoogleLink { get; set; }
        public string ApplePodcastLink { get; set; }
        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public string PodcastCoverImageUUID { get; set; }

        public string PodcastCoverImageName { get; set; }

        public int ChannelId { get; set; }

        public string FileURL { get; set; }

        public string audioFileName { get; set; }

    }
}