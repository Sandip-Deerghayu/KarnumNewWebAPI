using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.EventBreakoutComments
{
    public class EventBreakoutCommentsViewResource
    {
        public string Uuid { get; set; }
        public int EventBreakoutId { get; set; }
        public int UserId { get; set; }
        public string CommentType { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
