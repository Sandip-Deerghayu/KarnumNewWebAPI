using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class FirstDemoInteraction
    {
        public int Id { get; set; }
        public string ProspectUuid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Notes { get; set; }
        public string DemoIsWith { get; set; }
        public string Designation { get; set; }
        public string NumberOfEmployee { get; set; }
        public string NumberOfClient { get; set; }
        public string Location { get; set; }
        public string StateType { get; set; }
        public string Solutions { get; set; }
        public string SolutionsAmountPaid { get; set; }
        public string NumberOfNurse { get; set; }
        public string NumberOfCaregiver { get; set; }
    }
}
