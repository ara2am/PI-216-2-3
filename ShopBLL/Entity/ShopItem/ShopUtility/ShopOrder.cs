using ShopBLL.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ShopBLL.Entity.ShopItem.ShopUtility.ShopEnums;
namespace ShopBLL.Entity.ShopItem.ShopGoods
{
    class ShopOrder : Order
    {
        public ShopOrderDeliveryState DeliveryState { get; set; }
        public ShopOrderPaymentState PaymentState { get; set; }
        public List<Goods> ListOfGoods { get; set; }

        public ShopOrder()
        {
            ListOfGoods = new List<Goods>();
        }

    }
}
