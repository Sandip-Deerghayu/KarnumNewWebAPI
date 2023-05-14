using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.TriviaQuestions
{
    public class UpdateTriviaQuestionsRequestViewResource
    {
        [Required]
        [StringLength(200)]
        public string Uuid { get; set; }
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
        public string Question {get; set;}

        public string Answers {get; set;}

        public int afterStart { get; set; }

        public string CorrectAnswer {get; set;}

        public DateTime DisplayAt {get; set;}
        public DateTime? CreatedDate { get; set; }
    }
}
