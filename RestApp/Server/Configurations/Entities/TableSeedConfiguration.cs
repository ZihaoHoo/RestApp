using Microsoft.EntityFrameworkCore;
using RestApp.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApp.Server.Configurations.Entities
{
    public class TableSeedConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Table> builder)
        {
            builder.HasData(
                new Table
                {

                    Id = 1,
                    Name = "Black",
                    Location ="",
                    TType ="1 person",
                    Pax =1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 2,
                    Name = "Black",
                    Location = "",
                    TType = "1 person",
                    Pax = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );

        }
    }
}
