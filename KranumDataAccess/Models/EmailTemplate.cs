using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AgencyUuid { get; set; }
        public string Event { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
