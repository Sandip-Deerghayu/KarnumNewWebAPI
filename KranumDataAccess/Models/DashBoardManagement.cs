using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class DashBoardManagement
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Identifier { get; set; }
        public string ClintLocationId { get; set; }
        public string NewProspects { get; set; }
        public string NewClients { get; set; }
        public string TotalClints { get; set; }
        public string Totalcaregiver { get; set; }
        public string BillingHours { get; set; }
        public string TimeArrival { get; set; }
        public string StarRatings { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string Roles { get; set; }
    }
}
