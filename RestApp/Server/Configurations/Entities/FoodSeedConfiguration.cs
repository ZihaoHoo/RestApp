using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApp.Shared.Domain;

namespace RestApp.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    Id = 1,
                    Name = "pdf/Italian Vecchio Menu.pdf"
                }
                );
        }
    }
}
