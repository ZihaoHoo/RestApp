using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApp.Shared.Domain
{
    public class Table : BaseDomainModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string TType { get; set; }
        public int Pax { get; set; }
        public int Quantity { get; set; }
    }
}
