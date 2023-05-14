using KranumCore.ViewResource.Event;
using KranumDataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.EventSponsor
{
    public class CreateEventSponsorViewResource
    {
        [StringLength(100)]
        public string BoothTitle { get; set; }
        public string OfferDetails { get; set; }
        [StringLength(255)]
        public string CarouselScreen1Uuid { get; set; }
        [StringLength(255)]
        public string CarouselScreen2Uuid { get; set; }
        [StringLength(255)]
        public string CarouselScreen3Uuid { get; set; }
        public int? CreatedBy { get; set; }
    }
}
