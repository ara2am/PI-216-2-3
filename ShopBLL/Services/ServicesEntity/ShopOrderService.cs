using ShopBLL.Entity.ShopItem.ShopGoods;
using ShopBLL.Entity.ShopItem.ShopUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Services.ServicesEntity
{
    public class ShopOrderService : Service<ShopOrder>
    {
        public ShopOrderService(string connection = "DbShopConnection")
            : base(connection)
        {

        }


        public override void Add(ShopOrder obj)
        {
            Unit.orders.Add(mapper.Map<ShopOrder, ShopDAL.Entity.ShopUtility.ShopOrder>(obj));
            Unit.Complete();
        }

        public override void Del(ShopOrder obj)
        {
            Unit.orders.Del(mapper.Map<ShopOrder, ShopDAL.Entity.ShopUtility.ShopOrder>(obj));
            Unit.Complete();
        }

        public override ShopOrder Get(int id)
        {
            return mapper.Map<ShopOrder>(Unit.orders.Get(id));
        }

        public IEnumerable<Goods> GetGoods(int id)
        {
            return mapper.Map<IEnumerable<Goods>>(Unit.orders.GetGoods(id));
        }

        public override ICollection<ShopOrder> GetAll()
        {
            return mapper.Map<ICollection<ShopOrder>>(Unit.orders.GetAll());
        }

        public override void Update(int id, ShopOrder obj)
        {
            Unit.orders.Update(id, mapper.Map<ShopOrder, ShopDAL.Entity.ShopUtility.ShopOrder>(obj));
            Unit.Complete();
        }

    }
}
