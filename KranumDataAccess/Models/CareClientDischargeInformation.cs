using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientDischargeInformation
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string CanClientParticipateInTheDischargePlanningProcess { get; set; }
        public string WhyNotClientCanParticipateInDischargePlan { get; set; }
        public string IsFamilyPresentAndParticipatingInThePlanningProcess { get; set; }
        public string NameOfFamilyMember { get; set; }
        public string Relationship { get; set; }
        public string ChoiceOfArrangementOfFirstPreference { get; set; }
        public string SpecificsOfFirstPreference { get; set; }
        public string ChoiceOfArrangementOfSecondPreference { get; set; }
        public string SpecificsOfSecondPreference { get; set; }
        public string ClientHealthPrognosis { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
