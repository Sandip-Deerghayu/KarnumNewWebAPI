using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class BusinessMappingLabel
    {
        public long Id { get; set; }
        public string Uuid { get; set; }
        public int? LabelId { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
