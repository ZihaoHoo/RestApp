using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApp.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int RestId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int TableId { get; set; }
        public virtual Table Table { get; set; }

    }
}
