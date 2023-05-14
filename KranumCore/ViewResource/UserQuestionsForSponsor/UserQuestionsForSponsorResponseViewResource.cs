using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.UserQuestionsForSponsor
{
    public class UserQuestionsForSponsorResponseViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailId { get; set; }
        public string ClientName { get; set; }
        public string QuestionText { get; set; }
        public string PostedDateTime { get; set; }
    }
}
