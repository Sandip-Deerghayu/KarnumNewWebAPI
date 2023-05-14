using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AssessorScrrenListMappingMandatoryQues
    {
        public int Id { get; set; }
        public string MandatoryQues { get; set; }
        public int? AssessorScreenListId { get; set; }
        public string ColumnName { get; set; }
        public int? ClientLocationId { get; set; }
    }
}
