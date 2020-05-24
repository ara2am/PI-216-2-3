using ShopDAL.Context.ContextClasses;
using ShopDAL.Entity.ShopItem.ShopGoods;
using ShopDAL.Entity.ShopUtility;
using ShopDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repository.RepositoryEntity
{
    public class GoodsRepository : Repository<Goods>, IGoodsRepository
    {
        public GoodsRepository(ShopContext context)
            :base(context)
        {

        }

        public ShopContext PContext
        {
            get { return Context as ShopContext; }
        }

        public IEnumerable<ShopOrder> GetOrders(int id)
        {
            return Get(id).ListOfOrders;
        }

    }
}
