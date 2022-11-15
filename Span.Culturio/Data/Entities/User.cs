using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Span.Culturio.Api.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public class UserConfigurationBuilder : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.ToTable(nameof(User)) ;
                builder.HasKey(x => x.Id);
                builder.Property(x => x.firstName).IsRequired();
                builder.Property(x => x.lastName).IsRequired();
                builder.Property(x => x.email).IsRequired();
                builder.Property(x => x.username).IsRequired();
                builder.Property(x => x.password).IsRequired();
                

                builder.HasData(new User
                {
                    Id = 1,
                    firstName = "susy",
                    lastName = "baki",
                    email = "admin@among.us",
                    username = "admin",
                    password = "12344321"
                });

            }
        }
    }
}
