using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Span.Culturio.Api.Data.Entities
{
    public class Subscription
    {
        public int userId { get; set; }
        public int packageId { get; set; }
        public string name { get; set; }
        public string activeFrom { get; set; }
        public string activeTo { get; set; }
        public string state { get; set; }
        public int recordedVisits { get; set; }

        public class SubscriptionConfigurationBuilder : IEntityTypeConfiguration<Subscription>
        {
            public void Configure(EntityTypeBuilder<Subscription> builder)
            {
                builder.ToTable(nameof(Subscription));
                builder.HasKey(t => t.userId);
                builder.Property(t => t.packageId).IsRequired();
                builder.Property(t => t.name).IsRequired();
                builder.Property(t => t.activeFrom).IsRequired();
                builder.Property(t => t.activeTo).IsRequired();
                builder.Property(t => t.state).IsRequired();
                builder.Property(t => t.recordedVisits).IsRequired();

                builder.HasData(new Subscription
                {
                    userId = 1,
                    packageId = 0,
                    name = "ayo",
                    activeFrom = "2022-11-11T10:29:43.317Z",
                    activeTo = "2022-11-11T10:29:43.317Z",
                    state = "active",
                    recordedVisits = 0
                });
            }

        }
    }
}
