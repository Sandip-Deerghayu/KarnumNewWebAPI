using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SponsorChat
{
    public class userListResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public int MsgCount { get; set; }
        public DateTime CreatdeAt { get; set; }

        public string LastMsg  { get; set; }
        public bool IsLogin { get; set; }

    }
}
