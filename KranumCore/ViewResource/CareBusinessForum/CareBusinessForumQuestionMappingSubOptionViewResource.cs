using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.CareBusinessForum
{
    public class CareBusinessForumQuestionMappingSubOptionViewResource
    {
        public int Id { get; set; }
        public int CareBusinessForumQuestionMappingOptionId { get; set; }
        public string SubOption { get; set; }
        public virtual CareBusinessForumQuestionMappingOptionViewResource CareBusinessForumQuestionMappingOption { get; set; }
    }
}
