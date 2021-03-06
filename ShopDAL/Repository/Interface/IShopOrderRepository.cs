﻿using ShopBLL.Repository.Interface;
using ShopDAL.Entity.ShopItem.ShopGoods;
using ShopDAL.Entity.ShopUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repository.Interface
{
    public interface IShopOrderRepository : IRepository<ShopOrder>
    {
        IEnumerable<Goods> GetGoods(int id);
    }
}
