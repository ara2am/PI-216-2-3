using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Entity.ShopUtility
{
    public abstract class Order
    {
        abstract public int OrderId { get; set; }
        abstract public DateTime Time { get; set; }
        abstract public double Price { get; set; }
        
    }
}
