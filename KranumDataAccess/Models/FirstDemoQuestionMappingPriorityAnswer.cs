using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class FirstDemoQuestionMappingPriorityAnswer
    {
        public int Id { get; set; }
        public string Priority { get; set; }
        public int? FirstDemoInteractionId { get; set; }
    }
}
