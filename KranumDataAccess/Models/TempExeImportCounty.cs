using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class TempExeImportCounty
    {
        public string DmaDchProviderId { get; set; }
        public string Agency { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string County { get; set; }
        public int Id { get; set; }
    }
}
