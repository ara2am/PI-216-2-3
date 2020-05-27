using ShopBLL.Entity.ShopItem.ShopGoods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Services.ServicesEntity
{
    public class TypeOfGoodsService : Service<TypeOfGoods>
    {
        public TypeOfGoodsService(string connection = "DbShopConnection")
           : base(connection)
        {

        }


        public override void Add(TypeOfGoods obj)
        {
            Unit.types.Add(mapper.Map<TypeOfGoods, ShopDAL.Entity.ShopItem.ShopGoods.TypeOfGoods>(obj));
            Unit.Complete();
        }

        public override void Del(TypeOfGoods obj)
        {
            Unit.types.Del(mapper.Map<TypeOfGoods, ShopDAL.Entity.ShopItem.ShopGoods.TypeOfGoods>(obj));
            Unit.Complete();
        }

        public override TypeOfGoods Get(int id)
        {
            return mapper.Map<TypeOfGoods>(Unit.types.Get(id));
        }

        public override ICollection<TypeOfGoods> GetAll()
        {
            return mapper.Map<ICollection<TypeOfGoods>>(Unit.types.GetAll());
        }

        public override void Update(int id, TypeOfGoods obj)
        {
            Unit.types.Update(id, mapper.Map<TypeOfGoods, ShopDAL.Entity.ShopItem.ShopGoods.TypeOfGoods>(obj));
            Unit.Complete();
        }
    }
}
