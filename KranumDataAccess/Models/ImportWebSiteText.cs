using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ImportWebSiteText
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string WebUrl { get; set; }
        public string WebText { get; set; }
        public string Uuid { get; set; }
        public DateTime? ImportedDate { get; set; }
    }
}
