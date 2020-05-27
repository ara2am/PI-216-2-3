using ShopDAL.Context.ContextClasses;
using ShopDAL.Repository.Interface;
using ShopDAL.Repository.RepositoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repository
{
    public class UnitOfWork
    {
        private readonly ShopContext context;

        public IGoodsRepository goods { get; private set; }
        public IShopOrderRepository orders { get; private set; }
        public ITypeOfGoodsRepository types { get; private set; }


        public UnitOfWork(ShopContext _context)
        {
            context = _context;
            goods = new GoodsRepository(context);
            orders = new ShopOrderRepository(context);
            types = new TypeOfGoodsRepository(context);
        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
