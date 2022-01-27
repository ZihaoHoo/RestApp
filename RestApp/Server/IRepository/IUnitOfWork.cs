using Microsoft.AspNetCore.Http;
using RestApp.Shared.Domain;
using System.Threading.Tasks;

namespace RestApp.Server.IRepository
{
    public interface IUnitOfWork
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Cuisine> Cuisines { get; }
        IGenericRepository<Food> Foods { get; }
        IGenericRepository<Image> Images { get; }
        IGenericRepository<Restaurant> Restaurants { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Table> Tables { get; }
        IGenericRepository<PaymentType> PaymentTypes { get; }
    }
}