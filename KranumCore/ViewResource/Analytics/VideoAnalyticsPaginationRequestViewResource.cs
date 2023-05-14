using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics
{
    public class VideoAnalyticsPaginationRequestViewResource
    {
        public string EventUUID { get; set; }
        public string ResourceUUID { get; set; }
        public int PreCount { get; set; }
        public int PageSize { get; set; }
    }
}
