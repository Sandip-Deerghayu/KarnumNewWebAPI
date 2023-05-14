using System.Collections.Generic;

namespace KranumCore.ViewResource.Analytics.UserQuestionsForSponsor
{
    public class UserQuestionsForSponsorResponseViewResource
    {
        public int TotalRecords { get; set; }
        public List<UserQuestionsForSponsorViewResource> UserQuestions { get; set; }

    }
}
