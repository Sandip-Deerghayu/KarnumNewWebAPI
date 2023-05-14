using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.TriviaQuestions
{


    public class AnsCount
    {

        public string optionsName { get; set; }

        public int optionsCount { get; set; }
    }

    public class TriviaQuestionsViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
       
       public string Question {get; set;}

        public string Answers {get; set;}

        public string CorrectAnswer {get; set;}

        public DateTime DisplayAt {get; set;}

        public int? AnswerCount { get; set; }

        public DateTime? CreatedDate { get; set; }     

        public List<AnsCount> AnsCount { get; set; }
    }
}
