using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AssessorScreenMappingLevel
    {
        public int Id { get; set; }
        public int? NumberOfLevel { get; set; }
        public int? AssessorScreenListId { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
    }
}
