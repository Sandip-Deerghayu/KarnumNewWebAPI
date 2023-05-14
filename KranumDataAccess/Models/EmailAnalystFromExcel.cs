using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EmailAnalystFromExcel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int? LinkedClicked { get; set; }
        public int? EmailSent { get; set; }
        public int? EmailOpened { get; set; }
        public long? CampId { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
