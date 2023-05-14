using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class StatePropertyForEvvInfo
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string ReferralCompanyUuid { get; set; }
        public string MandateModel { get; set; }
        public string SelectedVendor { get; set; }
        public string StateNotes { get; set; }
        public string SellingTips { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public DateTime? LastDateUpdated { get; set; }
        public string MandateDate { get; set; }
        public string Link { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
