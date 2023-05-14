namespace KranumCore.ViewResource.PlayerVideo
{
    public class CreatePlayerVideoRequestViewResource
    {
        public string EventUUID { get; set; }
        public string UserUUID { get; set; }
        public string ResourceUUID { get; set; }
        public decimal CurrentTime { get; set; }
        public decimal TotalDuration { get; set; }
        public string EventType { get; set; }
        public string TimeStamp { get; set; }
    }
}
