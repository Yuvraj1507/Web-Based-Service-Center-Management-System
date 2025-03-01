﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopServiceItem
    {
        public int id { get; set; }
        public Service service { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }
    }
}
