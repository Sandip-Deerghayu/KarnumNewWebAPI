using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class JwtokenVeraMedix
    {
        public int TokenId { get; set; }
        public string UserId { get; set; }
        public string Key { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UserIdEncyptKey { get; set; }
    }
}
