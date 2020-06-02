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
    public class AuthServiceTest
    {
        private IMapper mapper;
        private DbSet<User> db = new ShopContext ().Users;
        private AuthService service;

        public AuthServiceTest ()
        {
            mapper = new MapperConfiguration (cfg => cfg.AddProfile<Mapper> ()).CreateMapper ();
            service = new AuthService ();
        }

        public void Add_Test ()
        {
            service.Add (new User () { Id = 1, FullName = "test 1" });
            service.Add (new User () { Id = 2, FullName = "test 2" });
            service.Add (new User () { Id = 3, FullName = "test 3" });

            var check = service.Get (2);

            Assert.NotNull (check);
            Assert.AreEqual (check.FullName, "test 2");
        }

        public void Del_Test ()
        {
            service.Add (new User () { Id = 1, FullName = "test 1" });
            service.Add (new User () { Id = 2, FullName = "test 2" });
            service.Add (new User () { Id = 3, FullName = "test 3" });

            service.Del (new User () { Id = 2, FullName = "test 2" });
            var check = service.Get (2);

            Assert.AreEqual (check, null);
        }

        public void Get_Test ()
        {
            service.Add (new User () { Id = 1, FullName = "test 1" });
            service.Add (new User () { Id = 2, FullName = "test 2" });
            service.Add (new User () { Id = 3, FullName = "test 3" });

            var check = service.Get (3);

            Assert.NotNull (check);
            Assert.AreEqual (check.FullName, "test 3");
        }

        public void Update_Test ()
        {
            service.Add (new User () { Id = 1, FullName = "test 1" });
            service.Add (new User () { Id = 2, FullName = "test 2" });
            service.Add (new User () { Id = 3, FullName = "test 3" });

            service.Update (3, new User () { Id = 3, FullName = "test 43" });
            var check = service.Get (3);

            Assert.NotNull (check);
            Assert.AreEqual (check.FullName, "test 43");
        }
    }
}
