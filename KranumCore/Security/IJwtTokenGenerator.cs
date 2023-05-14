using KranumCore.ViewResource.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.Security
{
    public interface IJwtTokenGenerator
    {
        string CreateToken(LoginResponseViewResource LoginResponseViewResource, List<string> Roles);
        string CreateZoomJoinMeetingToken(string apiKey, string apiSecret, string meetingNumber, string ts, string role);

        string CreateZoomJWTToken(string apiKey, string apiSecret);

    }
}
