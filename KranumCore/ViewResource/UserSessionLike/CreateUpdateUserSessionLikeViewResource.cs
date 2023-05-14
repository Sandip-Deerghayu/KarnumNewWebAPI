using System;

namespace KranumCore.ViewResource.UserSessionLike
{
    public class CreateUpdateUserSessionLikeViewResource
    {
        public string UserUUID { get; set; }
        public string SessionUUID { get; set; }
        public bool LikeSession { get; set; }
    }
}
