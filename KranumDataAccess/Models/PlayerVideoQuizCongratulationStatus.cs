using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class PlayerVideoQuizCongratulationStatus
    {
        public int PlayerVideoQuizCongratulationId { get; set; }
        public string CaregiverUuid { get; set; }
        public int? PlayerVideoId { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
