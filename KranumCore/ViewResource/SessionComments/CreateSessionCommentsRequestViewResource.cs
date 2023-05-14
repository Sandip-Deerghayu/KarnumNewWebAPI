using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionComments
{
    public class CreateSessionCommentsRequestViewResource
    {
        public string sessionUUID { get; set; }
        public string userUUID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string commentText { get; set; }
        public DateTime createdDate { get; set; }
    }
}
