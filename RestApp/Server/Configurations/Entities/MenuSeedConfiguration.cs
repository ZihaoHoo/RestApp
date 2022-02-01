using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApp.Shared.Domain;
using System;

namespace RestApp.Server.Configurations.Entities
{
    public class MenuSeedConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu
                {
                    Id = 1,
                    Rest_Name= "Italian Vecchio",
                    Path_url = "pdf/Italian Vecchio Menu.pdf",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Menu
                {
                Id = 2,
                    Rest_Name = "American Diner",
                    Path_url = "pdf/American Diner.pdf",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
