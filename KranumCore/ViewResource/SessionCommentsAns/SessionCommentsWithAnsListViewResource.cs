using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionCommentsAns
{
    public class SessionCommentsWithAnsListViewResource
    {
        public string Uuid { get; set; }
        public string CommentText { get; set; }
        public string AnsText { get; set; }
        public string SessionUuid { get; set; }
        public string SessionTitle { get; set; }
        public string UserUuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public List<SessionCommentsWithAnsViewResource> SessionCommentsAnswers { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
