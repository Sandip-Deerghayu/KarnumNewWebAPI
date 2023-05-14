using KranumCore.ViewResource.User;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace KranumCore.Security
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string CreateToken(LoginResponseViewResource LoginResponseViewResource, List<string> Roles)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.NameId, LoginResponseViewResource.UUID),
                new Claim(JwtRegisteredClaimNames.GivenName, LoginResponseViewResource.FirstName != null ? LoginResponseViewResource.FirstName : ""),
                new Claim(JwtRegisteredClaimNames.FamilyName, LoginResponseViewResource.LastName != null ? LoginResponseViewResource.LastName : ""),
                new Claim(JwtRegisteredClaimNames.Email, LoginResponseViewResource.EmailId),
            };

            if (Roles != null && Roles.Any())
            {
                Roles.ForEach(role =>
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                });
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SuPEr SeCrET KeY"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(3),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public string CreateZoomJWTToken(string apiKey, string apiSecret)
        {
            DateTime Expiry = DateTime.UtcNow.AddMinutes(20);

            string ApiKey = apiKey;
            string ApiSecret = apiSecret;

            int ts = (int)(Expiry - new DateTime(1970, 1, 1)).TotalSeconds;

            // Create Security key  using private key above:
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(ApiSecret));

            // length should be >256b
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Finally create a Token
            var header = new JwtHeader(credentials);

            //Zoom Required Payload
            var payload = new JwtPayload
            {
                { "iss", ApiKey},
                { "exp", ts },
            };

            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();

            // Token to String so you can use it in your client
            var tokenString = handler.WriteToken(secToken);

            return tokenString;
        }

        public string CreateZoomJoinMeetingToken(string apiKey, string apiSecret, string meetingNumber, string ts, string role)
        {
            string message = String.Format("{0}{1}{2}{3}", apiKey, meetingNumber, ts, role);
            apiSecret = apiSecret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(apiSecret);
            byte[] messageBytesTest = encoding.GetBytes(message);
            string msgHashPreHmac = System.Convert.ToBase64String(messageBytesTest);
            byte[] messageBytes = encoding.GetBytes(msgHashPreHmac);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                string msgHash = System.Convert.ToBase64String(hashmessage);
                string token = String.Format("{0}.{1}.{2}.{3}.{4}", apiKey, meetingNumber, ts, role, msgHash);
                var tokenBytes = System.Text.Encoding.UTF8.GetBytes(token);
                return System.Convert.ToBase64String(tokenBytes);
            }
        }
    }
}
