using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.UserQuestionsForSponsor
{
    public class CreateUserQuestionsForSponsorRequestViewResource
    {
        public string UserUUID { get; set; }
        public string ClientUUID { get; set; }
        public string EventUUID { get; set; }
        public string EventboothUUID { get; set; }

        [Required]
        public string QuestionText { get; set; }
    }
}
