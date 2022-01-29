using System;

namespace RestApp.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime? BkDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 00, 00);
        public DateTime? BkTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 00, 00);
        public int Pax { get; set; }
        public int RestId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
