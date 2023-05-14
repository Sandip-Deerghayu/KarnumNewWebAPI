using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class TempExeImport
    {
        public int Id { get; set; }
        public string Agency { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool? IsExisting { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsMerge { get; set; }
    }
}
