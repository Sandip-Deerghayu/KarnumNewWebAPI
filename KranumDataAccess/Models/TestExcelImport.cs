using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class TestExcelImport
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string MergeStatus { get; set; }
        public string LinkedClicked { get; set; }
        public string Uuid { get; set; }
    }
}
