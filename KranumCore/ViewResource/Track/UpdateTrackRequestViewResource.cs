using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Track
{
    public class UpdateTrackRequestViewResource
    {
        public string Uuid { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
