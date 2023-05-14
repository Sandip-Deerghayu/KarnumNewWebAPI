using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientDigestionGenitourinaryBladderIncontinenceLimitation
    {
        public int Id { get; set; }
        public int? CareClientDigestionGenitourinaryInformationId { get; set; }
        public string Total { get; set; }
        public string Occassional { get; set; }
    }
}
