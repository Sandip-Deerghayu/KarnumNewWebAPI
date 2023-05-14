using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SponsorChat
{
    public class SendUserMessageRequest
    {
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string msgBody { get; set; }
        public string SessionUUID { get; set; }
        public string EventUUID { get; set; }

    }
}
