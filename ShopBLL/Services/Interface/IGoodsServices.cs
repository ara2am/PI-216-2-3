using System;
using System.Collections.Generic;
using System.Text;
using ShopBLL.Entity.ShopItem.ShopGoods;

namespace ShopBLL.Services.Interface
{
    interface IGoodsServices
    {
        ActionResult Add (Goods goods);
        ActionResult Remove (int id);
    }
}
