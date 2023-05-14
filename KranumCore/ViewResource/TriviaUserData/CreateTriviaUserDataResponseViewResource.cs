using System;

namespace KranumCore.ViewResource.TriviaUserData
{
    public class CreateTriviaUserDataResponseViewResource
    {
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
       
        public string Question {get; set;}

        public string Answers {get; set;}

        public bool IsCorrectAnswer {get; set;}


    }
}