using AutoMapper;
using ShopBLL.Entity.ShopItem.ShopGoods;
using ShopBLL.Entity.ShopItem.ShopUtility;
using ShopBLL.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBLL.Services.ServicesEntity
{
    public class GoodsServices : Service<Goods>
    {
        public GoodsServices(string connection = "DbShopConnection")
            : base(connection)
        {

        }


        public override void Add(Goods obj)
        {
            Unit.goods.Add(mapper.Map<Goods, ShopDAL.Entity.ShopItem.ShopGoods.Goods>(obj));
            Unit.Complete();
        }

        public override void Del(Goods obj)
        {
            Unit.goods.Del(mapper.Map<Goods, ShopDAL.Entity.ShopItem.ShopGoods.Goods>(obj));
            Unit.Complete();
        }

        public override Goods Get(int id)
        {
            return mapper.Map<Goods>(Unit.goods.Get(id));
        }

        public IEnumerable<ShopOrder> GetOrder(int id)
        {
            return mapper.Map<IEnumerable<ShopOrder>>(Unit.goods.GetOrders(id));
        }

        public override ICollection<Goods> GetAll()
        {
            return mapper.Map<List<Goods>>(Unit.goods.GetAll());
        }

        public override void Update(int id, Goods obj)
        {
            Unit.goods.Update(id, mapper.Map<Goods, ShopDAL.Entity.ShopItem.ShopGoods.Goods>(obj));
            Unit.Complete();
        }


    }
}