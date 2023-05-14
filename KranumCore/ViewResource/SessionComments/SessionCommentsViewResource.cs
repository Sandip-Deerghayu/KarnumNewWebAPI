using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionComments
{
    public class SessionCommentsViewResource
    {
        public string Uuid { get; set; }
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
