using System;

namespace KranumCore.ViewResource.DefaultQue
{
    public class CreateDefaultQueResponseViewResource
    {

        public string Uuid { get; set; }
        public string UserUUID { get; set; }
        public string EventUUID { get; set; }
        public bool IsAllAnsGiven { get; set; }

        public DateTime DisplayAt { get; set; }

    }
}