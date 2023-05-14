using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserSessionLike
{
    public class UserSessionLikeViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int UserId { get; set; }
        public int SessionId { get; set; }
        public bool LikeSession { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
