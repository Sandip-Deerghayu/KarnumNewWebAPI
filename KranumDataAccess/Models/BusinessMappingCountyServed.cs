﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class BusinessMappingCountyServed
    {
        public long Id { get; set; }
        public string BusinessUuid { get; set; }
        public string County { get; set; }
        public int? BusinessMappingStateServedId { get; set; }
    }
}