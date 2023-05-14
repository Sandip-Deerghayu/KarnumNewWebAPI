namespace KranumCore.ViewResource.PlayerVideo
{
    public class CreatePlayedVideoRequestViewResource
    {
        public string VideoUUID { get; set; }
        public string UserUUID { get; set; }
        public string VideoLink { get; set; }
        public decimal CurrentTime { get; set; }
        public decimal TotalDuration { get; set; }
        public string EventType { get; set; }
        public string TimeStamp { get; set; }
    }
}
