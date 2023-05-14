using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.CareBusinessForum
{
    public class CreateCareBusinessForumQuestionMappingAnswerRequestViewResource
    {
        [Required]
        [StringLength(255)]
        public string EmailId { get; set; }
        public int QuestionId { get; set; }
        public int? OptionId { get; set; }
        public int? SubOptionId { get; set; }
        [StringLength(255)]
        public string OtherValue { get; set; }
    }
}
