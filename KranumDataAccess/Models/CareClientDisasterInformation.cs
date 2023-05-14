﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientDisasterInformation
    {
        public int Id { get; set; }
        public string ClientsDisasterLevel { get; set; }
        public string HospitalPreference { get; set; }
        public string Notes { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
