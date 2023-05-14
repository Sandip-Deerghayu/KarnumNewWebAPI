using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics
{
    public class EventboothUserQuestionAnalyticsPaginationRequestViewResource
    {
        public string ClientUUID { get; set; }
        public string EventUUID { get; set; }
        public string EventboothUUID { get; set; }
        public int PreCount { get; set; }
        public int PageSize { get; set; }
    }
}
