using AutoMapper;
using ShopBLL.Entity.ShopItem.ShopGoods;
using ShopBLL.Entity.ShopItem.ShopUtility;
using ShopBLL.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ShopBLL.Entity.ShopItem.ShopUtility.ShopEnums;
using System.Linq;

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

        public IEnumerable<Goods> SortBy (SortCriteria sortParam)
        {
            IEnumerable<Goods> all_goods = GetAll ();
            IEnumerable<Goods> res;

            if (sortParam == SortCriteria.Name)
                res = all_goods.OrderBy (x => x.Name);
            else
                res = all_goods.OrderBy (x => x.Price);

            return res;
        }

        public IEnumerable<Goods> SortByDescending (SortCriteria sortParam)
        {
            IEnumerable<Goods> all_goods = GetAll ();
            IEnumerable<Goods> res;

            if (sortParam == SortCriteria.Name)
                res = all_goods.OrderByDescending (x => x.Name);
            else
                res = all_goods.OrderByDescending (x => x.Price);

            return res;
        }

        public IEnumerable<Goods> FilterByCategory (int categoryId)
        {
            var goods = Unit.goods.GetAll ().Where (good => good.Type.TypeOfGoodsId == categoryId);
            IEnumerable<Goods> _goods = mapper.Map<IEnumerable<Goods>> (goods);

            return _goods;
        }
    }
}