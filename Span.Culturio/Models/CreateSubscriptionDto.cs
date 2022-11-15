namespace Span.Culturio.Api.Models
{
    public class CreateSubscriptionDto
    {
        public int userId { get; set; }
        public int packageId { get; set; }
        public string name { get; set; }
    }
}
