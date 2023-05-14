using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EventOrganizer
    {
        public string Uuid { get; set; }
        public long? EventId { get; set; }
        public long Id { get; set; }
    }
}
