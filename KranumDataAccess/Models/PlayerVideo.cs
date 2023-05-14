using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class PlayerVideo
    {
        public PlayerVideo()
        {
            PlayerVideoUserDetails = new HashSet<PlayerVideoUserDetails>();
        }

        public int Id { get; set; }
        public string YoutubeVideoId { get; set; }
        public int? Duration { get; set; }
        public string VideoTitle { get; set; }
        public string VideoDescripton { get; set; }

        public virtual ICollection<PlayerVideoUserDetails> PlayerVideoUserDetails { get; set; }
    }
}
