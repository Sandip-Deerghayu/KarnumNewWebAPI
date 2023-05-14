﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AppointmentMedicationMapping
    {
        public int Id { get; set; }
        public int? MedicationId { get; set; }
        public int? AppointmentId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string MedicineName { get; set; }
        public string MedicineGivenTime { get; set; }
    }
}
