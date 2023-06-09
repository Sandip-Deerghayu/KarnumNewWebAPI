﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class UserQuestionForSponsor
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? EventId { get; set; }
    }
}
