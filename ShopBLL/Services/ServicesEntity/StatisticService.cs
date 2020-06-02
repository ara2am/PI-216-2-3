using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBLL.Entity;

namespace ShopBLL.Services.ServicesEntity
{
    public class StatisticService
    {
        AuthService authService;
        GoodsServices goodsServices;
        TypeOfGoodsService typeOfGoodsService;
        ShopOrderService shopOrderService;

        public StatisticService (AuthService service0, GoodsServices service1, TypeOfGoodsService service2, ShopOrderService service3)
        {
            authService = service0;
            goodsServices = service1;
            typeOfGoodsService = service2;
            shopOrderService = service3;
        }

        public Statistic Get ()
        {
            return new Statistic () 
            { 
                TotalCountOfUsers = authService.GetAll ().Count,
                TotalCountOfGoods = goodsServices.GetAll ().Count,
                TotalCountOfGoodsTypes = typeOfGoodsService.GetAll ().Count,
                TotalCountOfOrders = shopOrderService.GetAll ().Count,
            };
        }
    }
}
