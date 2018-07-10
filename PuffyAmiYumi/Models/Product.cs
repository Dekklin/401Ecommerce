﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuffyAmiYumi.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public int Stock { get; set; }
    }
}
