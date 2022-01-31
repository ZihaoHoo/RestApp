using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApp.Shared.Domain;
using System;

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
                    Name = "pdf/Italian Vecchio Menu.pdf",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Food
                {
                Id = 2,
                    Name = "pdf/American Diner.pdf",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
