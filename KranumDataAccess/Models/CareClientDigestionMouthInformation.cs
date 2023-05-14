using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientDigestionMouthInformation
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string IsClientOnFluidRestriction { get; set; }
        public string CcsPerDay { get; set; }
        public string NoCorrespondinDxforHearing { get; set; }
        public string FirstCorrespondinDxforHearing { get; set; }
        public string SecondCorrespondinDxforHearing { get; set; }
        public string NoCorrespondingSurgery { get; set; }
        public string FirstCorrespondingSurgery { get; set; }
        public string SecondCorrespondingSurgery { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string IsCorrespondingLimitation { get; set; }
    }
}
