using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.TriviaUserData
{
    public class TriviaUserDataViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
       
       public string Question {get; set;}

        public string Answers {get; set;}

        public bool IsCorrectAnswer {get; set;}
        
        public DateTime? CreatedDate { get; set; }     
    }
}
