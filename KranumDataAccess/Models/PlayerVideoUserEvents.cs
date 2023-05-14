using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class PlayerVideoUserEvents
    {
        public long Id { get; set; }
        public long PlayerVideoUserDetailsId { get; set; }
        public int? PausePlayTime { get; set; }
        public string PausePlayType { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual PlayerVideoUserDetails PlayerVideoUserDetails { get; set; }
    }
}
