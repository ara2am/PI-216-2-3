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
using ShopDAL.Entity.ShopItem.ShopGoods;
using ShopDAL.Entity.ShopUtility;
using System.Data.Entity;
using ShopBLL.Entity.ShopItem.ShopUtility.ShopEnums;

namespace ShopBLLTest
{
    [TestFixture]
    public class GoodsServicesTest
    {
        private IMapper mapper;
        private DbSet<Goods> db = new ShopContext ().Goods;
        private GoodsServices service;

        public GoodsServicesTest ()
        {
            mapper = new MapperConfiguration (cfg => cfg.AddProfile<Mapper> ()).CreateMapper ();
            service = new GoodsServices ();
        }

        [Test]
        public void GetAll_Test ()
        {
            db.Setup (x => x.Items.GetAll ()).Returns (GetAll ());

            List<Goods> act = mapper.Map<List<Goods>> (service.GetAll ());
            var exp = GetAll ();

            Assert.NotNull (act);
            Assert.AreEqual (exp [0].GoodsId, act [0].GoodsId);
            Assert.AreEqual (exp [0].Name, act [0].Name);
            Assert.AreEqual (exp [1].Price, act [1].Price);
            Assert.AreEqual (exp [1].Type.TypeOfGoodsId, act [1].Type.TypeOfGoodsId);
        }

        [Test]
        public void SortByPrice_Test ()
        {
            db.Setup (x => x.Items.GetAll ()).Returns (GetAll ());

            List<Goods> act = mapper.Map<List<Goods>> (service.SortBy (SortCriteria.Price));
            var exp = GetAll ();

            Assert.NotNull (act);
            Assert.AreEqual (5, act.Count);
            Assert.AreEqual (exp [0].GoodsId, act [0].GoodsId);
            Assert.AreEqual (exp [0].Name, act [0].Name);
            Assert.AreEqual (exp [1].Price, act [1].Price);
            Assert.AreEqual (exp [1].Type.TypeOfGoodsId, act [1].Type.TypeOfGoodsId);
        }

        [Test]
        public void SortByDescendingPrice_Test ()
        {
            
            db.Setup (x => x.Items.GetAll ()).Returns (GetAll ());

            var exp = GetAll ();
            exp.Reverse ();
            List<Goods> act = mapper.Map<List<Goods>> (service.SortBy (SortCriteria.Price));

            Assert.NotNull (act);
            Assert.AreEqual (5, act.Count);
            Assert.AreEqual (exp [0].GoodsId, act [0].GoodsId);
            Assert.AreEqual (exp [0].Name, act [0].Name);
            Assert.AreEqual (exp [1].Price, act [1].Price);
            Assert.AreEqual (exp [1].Type.TypeOfGoodsId, act [1].Type.TypeOfGoodsId);
        }

        [Test]
        public void FilterByCategory_Test ()
        {
            db.Setup (x => x.Items.GetAll ()).Returns (GetAll ());

            var act = service.FilterByCategory (1);

            Assert.NotNull (act);
            Assert.AreEqual (3, act.Count);
            Assert.AreEqual (1, act [0].GoodsId);
            Assert.AreEqual ("edfrgtyhu", act [0].Name);
            Assert.AreEqual (3, act [1].GoodsId);
            Assert.AreEqual ("er45t6y7", act [1].Name);
        }

        private List<Goods> GetAll ()
        {
            return new List<Goods> ()
            {
                new Goods()
                {
                    GoodsId = 1,
                    Name = "edfrgtyhu",
                    Price = 100,
                    Type = new TypeOfGoods () { TypeOfGoodsId = 1 }
                },
                new Goods()
                {
                    GoodsId = 2,
                    Name = "rtyu",
                    Price = 200,
                    Type = new TypeOfGoods () { TypeOfGoodsId = 2 }
                },
                new Goods()
                {
                    GoodsId = 3,
                    Name = "er45t6y7",
                    Price = 300,
                    Type = new TypeOfGoods () { TypeOfGoodsId = 1 }
                },
                new Goods()
                {
                    GoodsId = 4,
                    Name = "er45t6y7",
                    Price = 400,
                    Type = new TypeOfGoods () { TypeOfGoodsId = 4 }
                },
                new Goods()
                {
                    GoodsId = 5,
                    Name = "r5ty67",
                    Price = 500,
                    Type = new TypeOfGoods () { TypeOfGoodsId = 1 }
                },
            };
        }
    }
}
