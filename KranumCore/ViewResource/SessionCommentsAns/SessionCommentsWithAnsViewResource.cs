using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionCommentsAns
{
    public class SessionCommentsWithAnsViewResource
    {
        public string Uuid { get; set; }
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public string AnsText { get; set; }

        public string UserUuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CommentsUuid { get; set; }
        public string SessionUuid { get; set; }
        public int SessionCommentsId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
