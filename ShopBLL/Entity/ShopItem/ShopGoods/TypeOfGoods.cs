using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBLL.Entity.ShopItem.ShopGoods
{
    public class TypeOfGoods
    {
        public int TypeOfGoodsId { get; set; }
        public string Name { get; set; }
        public int AgeLimit { get; set; }
        public bool NeedPermission { get; set; }

    }
}
