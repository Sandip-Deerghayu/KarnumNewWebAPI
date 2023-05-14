using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EmployeeFavouriteItemLog
    {
        public long Id { get; set; }
        public string Uuid { get; set; }
        public string Type { get; set; }
        public string EmployeeUuid { get; set; }
        public string Status { get; set; }
        public long? EmployeeFavouriteItemId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string TblEvent { get; set; }
    }
}
