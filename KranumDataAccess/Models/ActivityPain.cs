using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ActivityPain
    {
        public int ActivityPainId { get; set; }
        public string PatientId { get; set; }
        public int? ClientLocationId { get; set; }
        public string ShoulderL { get; set; }
        public string ShoulderR { get; set; }
        public string ElbowL { get; set; }
        public string ElbowR { get; set; }
        public string Chest { get; set; }
        public string HandL { get; set; }
        public string HandR { get; set; }
        public string KneeL { get; set; }
        public string KneeR { get; set; }
        public string FootL { get; set; }
        public string FootR { get; set; }
        public string Back { get; set; }
        public string HipL { get; set; }
        public string HipR { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? AppointmentId { get; set; }
    }
}
