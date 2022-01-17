﻿using RestApp.Server.Configurations.Entities;
using RestApp.Server.Models;
using RestApp.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace RestApp.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new TableSeedConfiguration());
 
        }

        public DbSet<RestApp.Shared.Domain.Cuisine> Cuisine { get; set; }

        public DbSet<RestApp.Shared.Domain.Booking> Booking { get; set; }

        public DbSet<RestApp.Shared.Domain.Customer> Customer { get; set; }

        public DbSet<RestApp.Shared.Domain.Food> Food { get; set; }
    }
}
