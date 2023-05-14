using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.UserActivityLog
{
    public class CreateUserActivityLogRequestViewResource
    {
        [Required]
        public string UserUUID { get; set; }

        [Required]
        public string Feature { get; set; }

        [Required]
        public string FeatureUUID { get; set; }

        public string LogText { get; set; }
    }
}
