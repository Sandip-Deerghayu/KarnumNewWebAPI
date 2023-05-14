﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AlertsAssessmentDates
    {
        public int AlertId { get; set; }
        public string AlertMessage { get; set; }
        public string AlertType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? Days92 { get; set; }
        public string SetAlerts { get; set; }
        public string ClientUuid { get; set; }
        public string CaregiverUuid { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Days122 { get; set; }
        public string IsAlerts { get; set; }
        public string Days62 { get; set; }
        public string Alerts62 { get; set; }
    }
}
