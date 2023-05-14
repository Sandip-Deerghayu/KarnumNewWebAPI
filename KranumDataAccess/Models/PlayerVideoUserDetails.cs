using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class PlayerVideoUserDetails
    {
        public PlayerVideoUserDetails()
        {
            PlayerVideoUserEvents = new HashSet<PlayerVideoUserEvents>();
        }

        public long PlayerVideoUserDetailsId { get; set; }
        public string UserEmail { get; set; }
        public int PlayerVideoId { get; set; }
        public decimal? TotalDuration { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string TimeStamp { get; set; }
        public decimal? WatchDuration { get; set; }

        public virtual PlayerVideo PlayerVideo { get; set; }
        public virtual ICollection<PlayerVideoUserEvents> PlayerVideoUserEvents { get; set; }
    }
}
