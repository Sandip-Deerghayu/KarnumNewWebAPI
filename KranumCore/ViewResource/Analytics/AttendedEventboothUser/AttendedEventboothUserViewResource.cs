using System.Collections.Generic;

namespace KranumCore.ViewResource.Analytics.AttendedEventboothUser
{
    public class AttendedEventboothUserViewResource
    {
        public AttendedEventboothUserViewResource()
        {
            BoothsVisited = new List<string>();
            BookMeetingBooths = new List<string>();
        }
        public string UserUUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessName { get; set; }
        public string State { get; set; }
        public string LoggedInDateTime { get; set; }
        public int UserVisitedCount { get; set; }
        public List<string> BoothsVisited { get; set; }
        public string EventboothName { get; set; }
        public bool BuyNow { get; set; }
        public bool BookMeeting { get; set; }
        public List<string> BookMeetingBooths { get; set; }
        public bool Website { get; set; }
        public bool LinkedIn { get; set; }
        public bool Twitter { get; set; }
        public bool Facebook { get; set; }
    }
}
