using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientGeneralPainInformation
    {
        public int Id { get; set; }
        public string IntensityLevel { get; set; }
        public string Frequency { get; set; }
        public string DoesGenralPainAffectSleep { get; set; }
        public string WhatBringReliefFromGeneralPain { get; set; }
        public int? CareClientPainInformationId { get; set; }
    }
}
