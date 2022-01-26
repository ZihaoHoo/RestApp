using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApp.Shared.Domain
{
    public class Restaurant : BaseDomainModel
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public int PaymentId { get; set; }
        public virtual PaymentType PaymentOption { get; set; }
        public int CuisineId { get; set; }
        public virtual Cuisine Cuisine { get; set; }
        public float AvgPayment { get; set; }
        public string Table_setting { get; set; }
        public int ImageId { get; set; }
        public virtual Image Images { get; set; }
        public string Menu{ get; set; }
        public string Reviews{ get; set; }
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
        public List<Booking> Booking { get; set; }
    }
}
