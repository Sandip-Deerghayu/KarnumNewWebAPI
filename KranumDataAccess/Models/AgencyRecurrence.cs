using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AgencyRecurrence
    {
        public int Id { get; set; }
        public DateTime? RecurringStartDate { get; set; }
        public DateTime? RecurringEndDate { get; set; }
        public string RecurringType { get; set; }
        public string AgencyUuid { get; set; }
        public string RecurringAmount { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
