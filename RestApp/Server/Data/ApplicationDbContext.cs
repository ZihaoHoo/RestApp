using RestApp.Server.Configurations.Entities;
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
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Restaurant> Restaurants {get; set;}
        public DbSet<Table> Tables { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.ApplyConfiguration(new BookingSeedConfiguration());
            //builder.ApplyConfiguration(new CuisineSeedConfiguration());
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            //builder.ApplyConfiguration(new FoodSeedConfiguration());
            //builder.ApplyConfiguration(new ImageSeedConfiguration());
            builder.ApplyConfiguration(new PaymentTypeSeedConfiguration());
            //builder.ApplyConfiguration(new RestaurantSeedConfiguration());
            builder.ApplyConfiguration(new TableSeedConfiguration());
            
            
            
            

        }
        
    }
}
