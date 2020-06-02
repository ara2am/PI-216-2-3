using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ShopBLLTest.AutoMapper;
using AutoMapper;
using ShopBLL.Services.ServicesEntity;
using Moq;
using Mapper = ShopBLLTest.AutoMapper.Mapper;
using ShopDAL.Context.ContextClasses;
using ShopBLL.Entity.User;
using ShopBLL.Entity.ShopItem.ShopGoods;
using ShopBLL.Entity.Interface;
using ShopBLL.Entity.ShopItem.ShopUtility;
using System.Data.Entity;
using ShopDAL.Entity.ShopUtility;
using ShopOrder = ShopDAL.Entity.ShopUtility.ShopOrder;

namespace ShopBLLTest
{
    [TestFixture]
    public class ShopOrderServiceTest
    {
        private IMapper mapper;
        private DbSet<ShopOrder> db = new ShopContext ().ShopOrders ;
        private ShopOrderService service;

        public ShopOrderServiceTest ()
        {
            mapper = new MapperConfiguration (cfg => cfg.AddProfile<Mapper> ()).CreateMapper ();
            service = new ShopOrderService ();
        }

        public void Add_Test ()
        {
            service.Add (new ShopOrder () { OrderId = 1, Price = 200});
            service.Add (new ShopOrder () { OrderId = 2, Price = 300 });
            service.Add (new ShopOrder () { OrderId = 3, Price = 400 });

            var check = service.Get (2);

            Assert.NotNull (check);
            Assert.AreEqual (check.Price, 300);
        }

        public void Del_Test ()
        {
            service.Add (new ShopOrder () { OrderId = 1, Price = 200 });
            service.Add (new ShopOrder () { OrderId = 2, Price = 300 });
            service.Add (new ShopOrder () { OrderId = 3, Price = 400 });

            service.Del (new ShopOrder () { OrderId = 2, Price = 300 });
            var check = service.Get (2);

            Assert.AreEqual (check, null);
        }

        public void Get_Test ()
        {
            service.Add (new ShopOrder () { OrderId = 1, Price = 200 });
            service.Add (new ShopOrder () { OrderId = 2, Price = 300 });
            service.Add (new ShopOrder () { OrderId = 3, Price = 400 });

            var check = service.Get (3);

            Assert.NotNull (check);
            Assert.AreEqual (check.Price, 400);
        }

        public void Update_Test ()
        {
            service.Add (new ShopOrder () { OrderId = 1, Price = 200 });
            service.Add (new ShopOrder () { OrderId = 2, Price = 300 });
            service.Add (new ShopOrder () { OrderId = 3, Price = 400 });

            service.Update (3, new ShopOrder () { OrderId = 3, Price = 1000 });
            var check = service.Get (3);

            Assert.NotNull (check);
            Assert.AreEqual (check.Price, 1000);
        }
    }
}
