using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApp.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApp.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    Name = "pdf/Italian Vecchio Menu.pdf"
                },
                new Food
                {
                    Name = ""
                },
                new Food
                {
                    Name = ""
                },
                new Food
                {
                    Name = ""
                },
                new Food
                {
                    Name = ""
                }
                );
        }
    }
}
