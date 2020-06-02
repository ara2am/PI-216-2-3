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

namespace ShopBLLTest
{
    [TestFixture]
    public class StatisticServicesTest
    {
        private IMapper mapper;
        private AuthService authService;
        private GoodsServices goodsService;
        private ShopOrderService shopOrderService;
        private TypeOfGoodsService typeOfGoodsService;

        public StatisticServicesTest ()
        {
            mapper = new MapperConfiguration (cfg => cfg.AddProfile<Mapper> ()).CreateMapper ();
            authService = new AuthService ();
            goodsService = new GoodsServices ();
            shopOrderService = new ShopOrderService ();
            typeOfGoodsService = new TypeOfGoodsService ();
        }

        [Test]
        public void GetAll_Test ()
        {
            authService.Add (new User ());
            authService.Add (new User ());
            authService.Add (new User ());
            goodsService.Add (new Goods ());
            shopOrderService.Add (new ShopOrder ());
            shopOrderService.Add (new ShopOrder ());
            typeOfGoodsService.Add (new TypeOfGoods ());
            typeOfGoodsService.Add (new TypeOfGoods ());
            typeOfGoodsService.Add (new TypeOfGoods ());

            var statistic = new StatisticService (authService, goodsService, typeOfGoodsService, shopOrderService).Get ();

            Assert.AreEqual (statistic.TotalCountOfGoods, 1);
            Assert.AreEqual (statistic.TotalCountOfGoodsTypes, 3);
            Assert.AreEqual (statistic.TotalCountOfUsers, 3);
            Assert.AreEqual (statistic.TotalCountOfOrders, 2);
        }
    }
}
