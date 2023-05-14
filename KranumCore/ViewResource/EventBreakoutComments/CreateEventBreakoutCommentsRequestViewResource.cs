using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.EventBreakoutComments
{
    public class CreateEventBreakoutCommentsRequestViewResource
    {
        public string eventBreakoutUUID { get; set; }
        public string userUUID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string commentText { get; set; }
        public string commentType { get; set; }
    }
}
