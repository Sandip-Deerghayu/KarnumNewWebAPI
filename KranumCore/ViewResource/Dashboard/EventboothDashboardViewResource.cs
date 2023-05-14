namespace KranumCore.ViewResource.Dashboard
{
    public class EventboothDashboardViewResource
    {
        public int EventId { get; set; }
        public int EventboothId { get; set; }
        public int TotalEventboothVisitors { get; set; }
        public int TotalUniqueEventboothVisitors { get; set; }
        public int TotalBuyNowEventboothVisitors { get; set; }
        public int TotalBookAMeetingEventboothVisitors { get; set; }
        public int TotalEventboothEnquiry { get; set; }
        public int TotalWebsite { get; set; }
        public int TotalFacebook { get; set; }
        public int TotalTwitter { get; set; }
        public int TotalLinkedIn { get; set; }

        //Changed by RD
        public int TotalEngagement { get; set; }
        public decimal AverageEngagementRate { get; set; }
        public decimal VisitorEngagementRateForExhibit { get; set; }
        public decimal EngagementRateForEvent { get; set; }
        public decimal EngagementRateForExhibitByEvent { get; set; }

    }
}
