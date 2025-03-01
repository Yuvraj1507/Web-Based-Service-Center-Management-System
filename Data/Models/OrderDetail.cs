using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class OrderDetail
    {

        public int id { set; get; }
        public int orderID { get; set; }

        public int ServiceID { get; set; }

        public uint price { get; set; }

        public virtual Service service { get; set; }

        public virtual Order order { get; set; }

        
    }
}
