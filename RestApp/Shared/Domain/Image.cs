﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApp.Shared.Domain
{
    public class Image : BaseDomainModel
    {
        public string Img_url { get; set; }
        public int RestId { get; set; }
        public virtual List<Restaurant> Restaurants { get; set; }

    }
}
