using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.UserJoinRaffleQuestion
{
    public class CreateUserJoinRaffleQuestionRequestViewResource
    {
        [Required]
        public string UserUUID { get; set; }
        [Required]
        public bool JoinRaffle { get; set; }

    }
}
