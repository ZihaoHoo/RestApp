using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestApp.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime? BkDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 00, 00);
        [Required]
        [DataType(DataType.Time)]
        public DateTime? BkTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 00, 00);
        [Required]
        public int? Pax { get; set; }
        [Required]
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        [Required]
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
