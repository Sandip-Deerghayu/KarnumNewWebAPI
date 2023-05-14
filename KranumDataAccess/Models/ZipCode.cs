using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ZipCode
    {
        public int? Zip { get; set; }
        public string CountyName { get; set; }
        public string State { get; set; }
        public string Stcountyfp { get; set; }
        public string Classfp { get; set; }
    }
}
