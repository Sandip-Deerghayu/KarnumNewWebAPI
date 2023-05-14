using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics
{
    public class EventBoothEnquiryTextPaginationRequestViewResource
    {
        public string EventBoothUUID { get; set; }
        public int PreCount { get; set; }
        public int PageSize { get; set; }
    }

    public class EventBoothEnquiryCountPaginationRequestViewResource
    {
        public string EventUUID { get; set; }
        public int PreCount { get; set; }
        public int PageSize { get; set; }
    }
}
