using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestApp.Shared.Domain
{
    public class Restaurant : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime? OpeningTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 00, 00);
        [Required]
        [DataType(DataType.Time)]
        public DateTime? ClosingTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 00, 00);
        public int PaymentId { get; set; }
        public virtual PaymentType PaymentOption { get; set; }
        [Required]
        public int CuisineId { get; set; }
        public virtual Cuisine Cuisine { get; set; }
        [Required]
        public int MenuId { get; set; }
        public virtual Menu Menu { get; set; }
        [Required]
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public string Reviews { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}
