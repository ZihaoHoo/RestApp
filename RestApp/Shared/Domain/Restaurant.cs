﻿using System;
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
        public virtual List<PaymentType> PaymentOption { get; set; }
        public string Cuisine { get; set; }
        public float AvgPayment { get; set; }
        public string Table_setting { get; set; }
        public virtual List<Image> Images { get; set; }
        public string Menu{ get; set; }
        public string Reviews{ get; set; }
        public virtual List<Table> Tables { get; set; }
    }
}
