namespace KranumCore.ViewResource.Client
{
    public class ClientResponseViewResource
    {
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string LogoResourceUuid { get; set; }
        public int TotalVisitorCount { get; set; }
        public int UniqueVisitorCount { get; set; }
        public int? TotalPoints { get; set; }
        public string Tags { get; set; }
    }
}
