using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class PlayerVideoUserQuestionAnswer
    {
        public long Id { get; set; }
        public long? PlayerVideoUserDetailsId { get; set; }
        public int? PlayerVideoQuestionId { get; set; }
        public string PlayerVideoQuestionAnswer { get; set; }
        public string UserUuid { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
