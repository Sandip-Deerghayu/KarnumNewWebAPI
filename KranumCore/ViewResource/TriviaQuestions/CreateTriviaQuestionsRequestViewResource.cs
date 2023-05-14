using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KranumCore.ViewResource.TriviaQuestions
{
    public class CreateTriviaQuestionsRequestViewResource
    {
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
       
        public string Question {get; set;}

        public string Answers {get; set;}

        public string CorrectAnswer {get; set;}

        public int afterStart { get; set; }

        public DateTime? DisplayAt {get; set;}

        public DateTime? CreatedDate { get; set; }
    }
}
