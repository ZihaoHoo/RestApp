using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApp.Shared.Domain;

namespace RestApp.Server.Configurations.Entities
{
    public class CuisineSeedConfiguration : IEntityTypeConfiguration<Cuisine>
    {
        public void Configure(EntityTypeBuilder<Cuisine> builder)
        {
            builder.HasData(
                new Cuisine
                {
                    Id = 1,
                    Name = "French"
                },
                new Cuisine
                {
                    Id = 2,
                    Name = "Japanese"
                },
                new Cuisine
                {
                    Id = 3,
                    Name = "Indian"
                },
                new Cuisine
                {
                    Id = 4,
                    Name = "Thai"
                },
                new Cuisine
                {
                    Id = 5,
                    Name = "Chinese"
                },
                new Cuisine
                {
                    Id = 6,
                    Name = "American"
                },
                new Cuisine
                {
                    Id = 7,
                    Name = "Italian"
                }
                );
        }
    }
}
