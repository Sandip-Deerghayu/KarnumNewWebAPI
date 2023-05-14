using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.CareBusinessForum
{
    public class CareBusinessForumQuestionListViewResource
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int PageNumber { get; set; }
        public int Sequence { get; set; }
        public string Type { get; set; }

        public bool IsVisible { get; set; }
        public virtual ICollection<CareBusinessForumQuestionMappingOptionViewResource> CareBusinessForumQuestionMappingOption { get; set; }
    }
}
