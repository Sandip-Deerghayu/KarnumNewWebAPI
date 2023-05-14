using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.CareBusinessForum
{
    public class CareBusinessForumQuestionMappingOptionViewResource
    {
        public int Id { get; set; }
        public string Option { get; set; }
        public int CareBusinessForumQuestionId { get; set; }

        public virtual CareBusinessForumQuestionListViewResource CareBusinessForumQuestion { get; set; }
        public virtual ICollection<CareBusinessForumQuestionMappingSubOptionViewResource> CareBusinessForumQuestionMappingSubOption { get; set; }
    }
}
