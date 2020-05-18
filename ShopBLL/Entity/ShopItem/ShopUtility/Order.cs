using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBLL.Entity.Interface
{
    abstract class Order
    {
        public int OrderId { get; set; }
        public DateTime Time { get; set; }
        public double Price { get; set; }
    }
}
