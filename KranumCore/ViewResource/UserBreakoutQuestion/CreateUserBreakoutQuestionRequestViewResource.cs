using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.UserBreakoutQuestion
{
    public class CreateUserBreakoutQuestionRequestViewResource
    {
        [Required]
        public string UserUUID { get; set; }

        [Required]
        public bool OneMonthFreeCareonomy { get; set; }

    }
}
