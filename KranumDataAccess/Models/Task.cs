using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class Task
    {
        public long Id { get; set; }
        public string Uuid { get; set; }
        public string EmployeeUuid { get; set; }
        public string Task1 { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string ProductType { get; set; }
    }
}
