using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class Specialization
    {
        public int SpecializationId { get; set; }
        public string SpecializationName { get; set; }
        public string SpecializationCode { get; set; }
    }
}
