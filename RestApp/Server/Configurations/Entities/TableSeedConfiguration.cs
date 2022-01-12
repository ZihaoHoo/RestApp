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
                    TType ="1 person table",
                    Pax =1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 2,
                    TType = "2 person table",
                    Pax = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 3,
                    TType = "3 person table",
                    Pax = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 4,
                    TType = "4 person table",
                    Pax = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );

        }
    }
}
