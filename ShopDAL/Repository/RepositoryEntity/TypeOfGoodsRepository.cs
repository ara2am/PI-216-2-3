using ShopDAL.Context.ContextClasses;
using ShopDAL.Entity.ShopItem.ShopGoods;
using ShopDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repository.RepositoryEntity
{
    public class TypeOfGoodsRepository : Repository<TypeOfGoods>, ITypeOfGoodsRepository
    {
        public TypeOfGoodsRepository(ShopContext context)
            : base(context)
        {

        }

        public ShopContext PContext
        {
            get { return Context as ShopContext; }
        }
    }
}
