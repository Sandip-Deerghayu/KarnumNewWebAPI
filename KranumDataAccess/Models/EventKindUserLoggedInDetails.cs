using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EventKindUserLoggedInDetails
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public DateTime LoggedInDateTime { get; set; }
    }
}
