using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EventKindUserDetail
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string EventKindUuid { get; set; }
        public string EventKindUserUuid { get; set; }
        public string Json { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string EventTitle { get; set; }
        public DateTime? EventStartDatetime { get; set; }
    }
}
