using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ClientLocations
    {
        public int ClientId { get; set; }
        public int LocationNumber { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public string ContactNo { get; set; }
        public long ClientLocationId { get; set; }
    }
}
