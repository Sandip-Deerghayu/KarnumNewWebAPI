using KranumCore.ViewResource.EventChatAgent;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Prizes
{
    public class CreateOrUpdatePrizesReqestViewResource
    {
        [Required]
        public string EventUUID { get; set; }     
        public string Uuid { get; set; }     
        public List<IFormFile> FirstPrize  { get; set; }
        public List<IFormFile> SecoundPrize { get; set; } 
        public List<IFormFile> ThirdPrize { get; set; } 
        public List<IFormFile> FourthPrize { get; set; } 
        public List<IFormFile> FifthPrize { get; set; }
        
    }   
}
