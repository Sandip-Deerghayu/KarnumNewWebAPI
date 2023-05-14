using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics.EventBoothEnquiry
{
    public class EventBoothEnquiryTextResponseViewResource
    {
        public string EventBoothTitle { get; set; }
        public string EventBoothDescription { get; set; }
        public int TotalRecords { get; set; }
        public List<EventBoothEnquiryTextViewResource> EventBoothEnquiryTextViewResource { get; set; }
    }
}
