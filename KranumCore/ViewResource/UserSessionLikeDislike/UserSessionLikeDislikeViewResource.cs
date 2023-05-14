using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserSessionLikeDislike
{
    public class UserSessionLikeDislikeViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int UserId { get; set; }
        public int SessionId { get; set; }
        public bool LikeSession { get; set; }
        public bool ThirtyMinutesFreeMeeting { get; set; }
        public string FeedbackAndSuggestion { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
