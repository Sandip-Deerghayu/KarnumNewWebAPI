using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ProspectDemoRequest
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdateBy { get; set; }
        public string RequestBy { get; set; }
        public string DemoDate { get; set; }
        public string ContactEmail { get; set; }
        public string Status { get; set; }
    }
}
