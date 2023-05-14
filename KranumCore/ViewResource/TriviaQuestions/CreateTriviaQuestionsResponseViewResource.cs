using System;

namespace KranumCore.ViewResource.TriviaQuestions
{
    public class CreateTriviaQuestionsResponseViewResource
    {
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
       
        public string Question {get; set;}

        public string Answers {get; set;}

        public string CorrectAnswer {get; set;}

        public DateTime DisplayAt {get; set;}

    }
}