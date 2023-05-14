using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KranumCore.ViewResource.TriviaUserData
{
    public class CreateTriviaUserDataRequestViewResource
    {
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
       
        public string Question {get; set;}

        public string Answers {get; set;}

        public bool IsCorrectAnswer {get; set;}

        public DateTime? CreatedDate { get; set; }
    }
}
