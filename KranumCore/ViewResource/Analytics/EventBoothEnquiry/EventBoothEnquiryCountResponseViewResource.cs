using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics.EventBoothEnquiry
{
    public class EventBoothEnquiryCountResponseViewResource
    {
        public int TotalRecords { get; set; }
        public List<EventBoothEnquiryCountViewResource> EventBoothEnquiryCount { get; set; }
    }
}
