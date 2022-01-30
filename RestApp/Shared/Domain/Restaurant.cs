using System;
using System.Collections.Generic;

namespace RestApp.Shared.Domain
{
    public class Restaurant : BaseDomainModel
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime? OpeningTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 00, 00);
        public DateTime? ClosingTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 00, 00);
        public int PaymentId { get; set; }
        public virtual PaymentType PaymentOption { get; set; }
        public int CuisineId { get; set; }
        public virtual Cuisine Cuisine { get; set; }
        public float AvgPayment { get; set; }
        public string Table_setting { get; set; }
        public string Menu { get; set; }
        public string Reviews { get; set; }
        //public int TableId { get; set; }
        //public virtual Table Table { get; set; }
        //public virtual List<Booking> Bookings { get; set; }
    }
}
