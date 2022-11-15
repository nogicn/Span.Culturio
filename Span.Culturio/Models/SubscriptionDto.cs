namespace Span.Culturio.Api.Models
{
    public class SubscriptionDto
    {
        public string id { get; set; }
        public int userId { get; set; }
        public int packageId { get; set; }
        public string name { get; set; }
        public DateTime activeFrom { get; set; }
        public DateTime activeTo { get; set; }
        public string state { get; set; }
        public int recordedVisits { get; set; }
    }
}
