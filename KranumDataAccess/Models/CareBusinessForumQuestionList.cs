using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareBusinessForumQuestionList
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int? PageNumber { get; set; }
        public int? Sequence { get; set; }
        public string Type { get; set; }
    }
}
