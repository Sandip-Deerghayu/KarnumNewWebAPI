using System;

namespace KranumCore.ViewResource.Prizes
{
    public class EventPrizesViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventId { get; set; }
        public string FirstPrizeUuid { get; set; }     
        public string SecoundPrizeUuid { get; set; }     
        public string ThirdPrizeUuid { get; set; }     
        public string FourthPrizeUuid { get; set; }     
        public string FifthPrizeUuid { get; set; }
        public string FirstPrizeName { get; set; }     
        public string SecoundPrizeName { get; set; }     
        public string ThirdPrizeName { get; set; }     
        public string FourthPrizeName { get; set; }     
        public string FifthPrizeName { get; set; }
        public DateTime? CreatedDate { get; set; }
        
        public DateTime? ModifiedDate { get; set; }      

    }
}