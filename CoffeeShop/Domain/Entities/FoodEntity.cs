﻿using System;

namespace CoffeeShop.Domain.Entities
{
    public class FoodEntity : ExtraEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Amount { get; set; }
        public string Price { get; set; }
        public string CreatedByUserId { get; set; }
        public string LastUpdatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int IsDeleted { get; set; }
        public int Status { get; set; }

    }
}
