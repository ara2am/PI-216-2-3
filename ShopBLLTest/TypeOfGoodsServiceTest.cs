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
    public class TypeOfGoodsServiceTest
    {
        private IMapper mapper;
        private DbSet<ShopOrder> db = new ShopContext ().ShopOrders;
        private TypeOfGoodsService service;

        public TypeOfGoodsServiceTest ()
        {
            mapper = new MapperConfiguration (cfg => cfg.AddProfile<Mapper> ()).CreateMapper ();
            service = new TypeOfGoodsService ();
        }

        public void Add_Test ()
        {
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 1, Name = "n1" });
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 2, Name = "n2" });
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 3, Name = "n3" });

            var check = service.Get (2);

            Assert.NotNull (check);
            Assert.AreEqual (check.Name, "n2");
        }

        public void Del_Test ()
        {
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 1, Name = "n1" });
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 2, Name = "n2" });
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 3, Name = "n3" });

            service.Del (new TypeOfGoods () { TypeOfGoodsId = 2, Name = "n2" });
            var check = service.Get (2);

            Assert.AreEqual (check, null);
        }

        public void Get_Test ()
        {
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 1, Name = "n1" });
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 2, Name = "n2" });
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 3, Name = "n3" });

            var check = service.Get (3);

            Assert.NotNull (check);
            Assert.AreEqual (check.Name, "n3");
        }

        public void Update_Test ()
        {
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 1, Name = "n1" });
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 2, Name = "n2" });
            service.Add (new TypeOfGoods () { TypeOfGoodsId = 3, Name = "n3" });

            service.Update (3, new TypeOfGoods () { TypeOfGoodsId = 3, Name = "n33333" });
            var check = service.Get (3);

            Assert.NotNull (check);
            Assert.AreEqual (check.Name, "n33333");
        }
    }
}
