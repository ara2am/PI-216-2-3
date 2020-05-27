using ShopBLL.Repository.Interface;
using ShopDAL.Entity.ShopItem.ShopGoods;
using ShopDAL.Entity.ShopUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repository.Interface
{
    public interface IGoodsRepository : IRepository<Goods>
    {
        IEnumerable<ShopOrder> GetOrders(int id);
    }
}
