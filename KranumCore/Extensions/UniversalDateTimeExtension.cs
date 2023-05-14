using System;

namespace KranumCore.Extensions
{
    public static class UniversalDateTimeExtension
    {
        public static DateTime ConvertToUniversalDateTime(this DateTime datetime, string timeZone)
        {
            if (timeZone == "America/Detroit")
            {
                timeZone = "Eastern Standard Time";
            }

            else if (timeZone == "America/Chicago")
            {
                timeZone = "Central Standard Time";
            }

            else if (timeZone == "Mountain")
            {
                timeZone = "Mountain Standard Time";
            }

            else if (timeZone == "America/Dawson")
            {
                timeZone = "Pacific Standard Time";
            }

            else
            {
                timeZone = "Eastern Standard Time";
            }
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(datetime, timeZone);
        }
    }
}
