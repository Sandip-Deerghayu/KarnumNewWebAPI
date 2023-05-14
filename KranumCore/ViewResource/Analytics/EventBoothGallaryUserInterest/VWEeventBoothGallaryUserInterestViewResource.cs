using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics.EventBoothGallaryUserInterest
{
    public class VWEeventBoothGallaryUserInterestViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int UserId { get; set; }
        public string UserUuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string SecondaryEmailId { get; set; }
        public string ResourceUuid { get; set; }
        public string ResourceTitle { get; set; }
        public string ResourceDescription { get; set; }
        public string BuyNowUrl { get; set; }
        public string EventBoothUuid { get; set; }
        public string BoothTitle { get; set; }
        public string OfferDetails { get; set; }
        public string EventUuid { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
        public string InterestShownDate { get; set; }
    }
}
