using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.UserBreakoutQuestion
{
    public class UserBreakoutQuestionResponseViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool OneMonthFreeCareonomy { get; set; }
        public string PostedDate { get; set; }
    }
}
