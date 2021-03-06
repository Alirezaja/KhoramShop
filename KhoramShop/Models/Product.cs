﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoramShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool isAvailable { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }

    }
}