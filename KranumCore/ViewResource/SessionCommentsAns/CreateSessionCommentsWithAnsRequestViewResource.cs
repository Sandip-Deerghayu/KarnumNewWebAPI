using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionCommentsAns
{
    public class CreateSessionCommentsWithAnsRequestViewResource
    {
        public string sessionUUID { get; set; }
        public string userUUID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string ansText { get; set; }
        public string commentUUID { get; set; }
        public DateTime createdDate { get; set; }
    }
}
