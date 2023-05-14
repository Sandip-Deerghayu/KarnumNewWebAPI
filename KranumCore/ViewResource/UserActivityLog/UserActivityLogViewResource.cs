using KranumCore.ViewResource.EventChatAgent;
using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.UserActivityLog
{
    public class UserActivityLogViewResource
    {
        public string Uuid { get; set; }
        public int UserId { get; set; }
        public string Feature { get; set; }
        public string FeatureUUID { get; set; }
        public string LogText { get; set; }
        public DateTime LogDate { get; set; }
    }
}
