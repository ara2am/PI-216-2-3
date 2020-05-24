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
    public class ShopOrderRepository : Repository<ShopOrder>, IShopOrderRepository 
    {
        public ShopOrderRepository(ShopContext context)
            : base(context)
        {

        }

        public ShopContext PContext
        {
            get { return Context as ShopContext; }
        }

        public IEnumerable<Goods> GetGoods(int id)
        {
            return Get(id).ListOfGoods;
        }

    }
}
