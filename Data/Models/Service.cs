﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Service
    {
        public int id { set; get; }
        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        public bool isFavorite { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
