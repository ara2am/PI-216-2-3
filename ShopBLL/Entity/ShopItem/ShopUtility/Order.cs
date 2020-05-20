using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBLL.Entity.Interface
{
    public abstract class Order
    {
        abstract public int OrderId { get; set; }
        abstract public DateTime Time { get; set; }
        abstract public double Price { get; set; }
    }
}
