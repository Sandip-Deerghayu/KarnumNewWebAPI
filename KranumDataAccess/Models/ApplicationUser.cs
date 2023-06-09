﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ApplicationUser
    {
        public long Id { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }
    }
}
