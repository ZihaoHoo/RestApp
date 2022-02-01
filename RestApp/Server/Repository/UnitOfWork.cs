using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestApp.Server.Data;
using RestApp.Server.IRepository;
using RestApp.Server.Models;
using RestApp.Shared.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RestApp.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Cuisine> _cuisines;
        private IGenericRepository<Food> _foods;
        private IGenericRepository<Image> _images;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Restaurant> _restaurants;
        private IGenericRepository<Table> _tables;
        private IGenericRepository<PaymentType> _paymenttypes;


        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Cuisine> Cuisines
            => _cuisines ??= new GenericRepository<Cuisine>(_context);
        public IGenericRepository<Food> Foods
            => _foods ??= new GenericRepository<Food>(_context);
        public IGenericRepository<Image> Images
            => _images ??= new GenericRepository<Image>(_context);
        public IGenericRepository<Restaurant> Restaurants
            => _restaurants ??= new GenericRepository<Restaurant>(_context);
        public IGenericRepository<Booking> Bookings
            => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Table> Tables
            => _tables ??= new GenericRepository<Table>(_context);
        public IGenericRepository<PaymentType> PaymentTypes
            => _paymenttypes ??= new GenericRepository<PaymentType>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}