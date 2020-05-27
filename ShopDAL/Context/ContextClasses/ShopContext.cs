using ShopDAL.Config;
using ShopDAL.Context.Interface;
using ShopDAL.Entity;
using ShopDAL.Entity.ShopItem.ShopEnums;
using ShopDAL.Entity.ShopItem.ShopGoods;
using ShopDAL.Entity.ShopUtility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Context.ContextClasses
{
    public class ShopContext : DbContext, IShopContext
    {
        public ShopContext()
            : base("DbShopConnection")
        {
            Database.SetInitializer(new Initializer());
        }

        public ShopContext(string connection) : base(connection)
        {
        }

        public DbSet<ShopOrder> ShopOrders;

        public DbSet<Goods> Goods;

        public DbSet<TypeOfGoods> TypeOfGoods;

        public DbSet<User> Users;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GoodsConfig());
            modelBuilder.Configurations.Add(new ShopOrderConfig());
            modelBuilder.Configurations.Add(new TypeOfGoodsConfig());
            modelBuilder.Configurations.Add(new UserConfig());
        }
    }
}
