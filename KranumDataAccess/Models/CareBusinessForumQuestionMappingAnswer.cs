using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareBusinessForumQuestionMappingAnswer
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public int? QuestionId { get; set; }
        public int? OptionId { get; set; }
        public int? SubOptionId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string OtherValue { get; set; }
    }
}
