﻿namespace RestApp.Shared.Domain
{
    public class Food : BaseDomainModel
    {
        public string Name { get; set; }
        public string Catagory { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public int RestId { get; set; }
        public virtual Restaurant Restaurants { get; set; }
    }
}
