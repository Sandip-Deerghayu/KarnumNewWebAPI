using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Dashboard
{
    public class SessionDashboardViewResource
    {
        public int EventId { get; set; }
        public int SessionId { get; set; }
        public int TotalSessionVisitors { get; set; }
        public decimal TotalVisitTime { get; set; }
        public decimal AverageVisitTime { get; set; }
        public int UniqueVisitorComments { get; set; }
        public int TotalVisitorComments { get; set; }

        //Added by RD
        public int TotalEngagement { get; set; }
        public decimal AverageEngagementRate { get; set; }
        public decimal VisitorEngagementRateForSession { get; set; }
        public decimal SessionEngagementRateForEvent { get; set; }
        public decimal EngagementRateForSessionByEvent { get; set; }
    }
}
