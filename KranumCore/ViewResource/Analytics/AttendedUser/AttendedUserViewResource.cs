using System;

namespace KranumCore.ViewResource.Analytics.AttendedUser
{
    public class AttendedUserViewResource
    {
        public string UserUUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessName { get; set; }
        public string State { get; set; }
        public DateTime LoggedInDateTime { get; set; }
    }
}
