using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.DefaultQue
{
    public class UpdateDefaultQueRequestViewResource
    {
        [Required]
        [StringLength(200)]
        public string Uuid { get; set; }
        public string UserUUID { get; set; }
        public string EventUUID { get; set; }
         public string businessName {get; set;}
        public string businessChallenges {get; set;}
        public string alreadyTakenSteps {get; set;}
        public string planSteps {get; set;}
        public string wantToKnowGACCP {get; set;}
        public string showOthersSolutions {get; set;}
        public string speakToMike {get; set;}   
        public bool IsAllAnsGiven { get; set; }


        public DateTime? CreatedDate { get; set; }
    }
}
