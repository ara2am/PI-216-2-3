using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBLL.Entity.ShopItem.ShopGoods
{
    public class Goods
    {
        public int GoodsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public TypeOfGoods Type { get; set; }
        public ICollection<ShopOrder> ListOfOrders { get; set; }

        public Goods()
        {
            ListOfOrders = new List<ShopOrder>();
        }
    }
}
