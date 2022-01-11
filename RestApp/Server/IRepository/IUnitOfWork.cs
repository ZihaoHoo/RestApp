using RestApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApp.Server.IRepository
{
    public class IUnitOfWork
    {
        IGenericRepository<Restaurant> Restaurants { get; }
        IGenericRepository<Food> Foods { get; }
        IGenericRepository<Table> Tables { get; }
        IGenericRepository<AvailablePayment> AvailablePayments { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
