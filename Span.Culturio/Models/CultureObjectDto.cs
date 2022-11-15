namespace Span.Culturio.Api.Models
{
    public class CultureObjectDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int companyId { get; set; }
        public string contactEmail { get; set; }
        public string address { get; set; }
        public int zipCode { get; set; }
        public string city { get; set; }
        public int adminUserId { get; set; }
    }
}
