using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApp.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApp.Server.Configurations.Entities
{
    public class CuisineSeedConfiguration : IEntityTypeConfiguration<Cuisine>
    {
        public void Configure(EntityTypeBuilder<Cuisine> builder)
        {
            builder.HasData(
                new Cuisine
                {
                    Name = "French"
                },
                new Cuisine
                {
                    Name = "Japanese"
                },
                new Cuisine
                {
                    Name = "Indian"
                },
                new Cuisine
                {
                    Name = "Thai"
                },
                new Cuisine
                {
                    Name = "Chinese"
                },
                new Cuisine
                {
                    Name = "American"
                },
                new Cuisine
                {
                    Name = "Italian"
                }
                );
        }
    }
}
