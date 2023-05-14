using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SponsorChat
{
    public class SendUserMessageResponse
    {
        public string Uuid { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string msgBody { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsDeActive { get; set; }
        public string SessionUUID { get; set; }
        public string EventUUID { get; set; }
    }
}
