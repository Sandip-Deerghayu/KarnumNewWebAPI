using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class PlayerVideoQuestion
    {
        public int PlayerVideoQuestionId { get; set; }
        public string PlayerVideoQuestion1 { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string Answer { get; set; }
        public int? PlayerVideoId { get; set; }
        public string ShowsOn { get; set; }
    }
}
