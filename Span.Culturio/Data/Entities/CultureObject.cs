using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Span.Culturio.Api.Data.Entities
{
    public class CultureObject
    {
        public int id { get; set; }
        public string name { get; set; }
        public int companyId { get; set; }
        public string contactEmail { get; set; }
        public string address { get; set; }
        public int zipCode { get; set; }
        public string city { get; set; }
        public int adminUserId { get; set; }

        public class CultureObjectConfigurationBuilder : IEntityTypeConfiguration<CultureObject>
        {
            public void Configure(EntityTypeBuilder<CultureObject> builder)
            {
                builder.ToTable(nameof(CultureObject));
                builder.HasKey(x => x.id);
                builder.Property(x => x.name).IsRequired();
                builder.Property(x => x.companyId).IsRequired();
                builder.Property(x => x.contactEmail).IsRequired(); 
                builder.Property(x => x.address).IsRequired();
                builder.Property(x => x.zipCode).IsRequired();
                builder.Property(x => x.city).IsRequired();
                builder.Property(x => x.adminUserId).IsRequired();

                builder.HasData(new CultureObject
                {
                        id = 1,
                        name = "string",
                        contactEmail = "string",
                        zipCode = 0,
                        address = "string",
                        city = "string",
                        adminUserId = 0
                });
            }
        }
    }
}
