using System;

namespace KranumCore.ViewResource.UserSessionLikeDislike
{
    public class CreateUpdateUserSessionLikeDislikeViewResource
    {
        public string UserUUID { get; set; }
        public string SessionUUID { get; set; }
        public bool LikeSession { get; set; }
        public bool ThirtyMinutesFreeMeeting { get; set; }
        public string FeedbackAndSuggestion { get; set; }
    }
}
