namespace KranumCore.ViewResource.KranumDataMapping
{
    public class UserWatchedVideo
    {
        public string VideoUUID { get; set; }
        public string VideoTitle { get; set; }
        public decimal? WatchedDuration { get; set; }
        public decimal? TotalDuration { get; set; }
    }
}