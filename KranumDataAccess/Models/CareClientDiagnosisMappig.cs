using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientDiagnosisMappig
    {
        public int Id { get; set; }
        public string Ques { get; set; }
        public string Icd10 { get; set; }
        public string DxSource { get; set; }
        public string Alteration { get; set; }
        public int? ClientDiagnosisId { get; set; }
        public string IsPrimary { get; set; }
        public string DiagnosisPriority { get; set; }
    }
}
