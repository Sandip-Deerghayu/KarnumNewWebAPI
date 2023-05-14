using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SponsorChat
{
    public class ChatResponse
    {
        public List<userListResponse> userChatList { get; set; }
        public List<SendUserMessageResponse> ChatMsg { get; set; }
    }
}
