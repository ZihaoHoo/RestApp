using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApp.Shared.Domain;
using System;

namespace RestApp.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {

                    Id = 1,
                    FirstName = "Low",
                    LastName = "Ying Yang",
                    ContactNumber = "90896745",
                    EmailAddress = "Low@abc.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Ho",
                    LastName = "Rong Xing",
                    ContactNumber = "90893333",
                    EmailAddress = "Xing@abc.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }

                );
        }
    }
}
