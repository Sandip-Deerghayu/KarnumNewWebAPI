﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareBusinessForumUpdatedInfo
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string StateList { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string MobileNumber { get; set; }
    }
}
