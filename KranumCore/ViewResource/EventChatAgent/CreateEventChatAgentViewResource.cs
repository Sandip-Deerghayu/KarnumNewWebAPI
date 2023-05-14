using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.EventChatAgent
{
    public class CreateEventChatAgentViewResource
    {
        public string ClientUUID { get; set; }
        public List<string> UserUUID { get; set; }
    }
}
