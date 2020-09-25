﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEI.API.DAL
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PricePerItem { get; set; }
        public decimal AverageCustomerRating { get; set; }
    }
}
