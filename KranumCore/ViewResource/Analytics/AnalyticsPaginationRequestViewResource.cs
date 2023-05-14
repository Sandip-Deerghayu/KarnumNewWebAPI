using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics
{
    public class AnalyticsPaginationRequestViewResource
    {
        public string EventUUID { get; set; }
        public string EventBoothUUID { get; set; }
        public int PreCount { get; set; }
        public int PageSize { get; set; }
    }
}
