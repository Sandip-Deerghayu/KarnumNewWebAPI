using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class StateCountyData
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string CountyCode { get; set; }
        public string CountyName { get; set; }
    }
}
