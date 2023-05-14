using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AmbulationEmployeeEvalutionInformatiom
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string Transfers { get; set; }
        public string Walking { get; set; }
        public string Repositioning { get; set; }
        public string CueActivityAndRom { get; set; }
        public string PlaceErsorPhone { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
