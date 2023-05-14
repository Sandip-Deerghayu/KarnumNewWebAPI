using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Dashboard
{
    public class EventDashboardViewResource
    {
        public int EventId { get; set; }
        public int TotalRegistration { get; set; }
        public int UserCount { get; set; }
        public int TotalComments { get; set; }
        public int TotalSessionVisitors { get; set; }
        public int TotalExhibitVisitors { get; set; }
        public int TotalResourceDownloads { get; set; }
        public int TotalUniqueVisitorsDownloadedResources { get; set; }
        public int TotalNumbersOfMeetingsClicked { get; set; }

        //Changed by RD
        public int EventAverageEngagement { get; set; }
        public decimal EventAverageEngagementRate { get; set; }
    }
}
