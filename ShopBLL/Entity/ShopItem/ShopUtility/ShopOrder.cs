using ShopBLL.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ShopBLL.Entity.ShopItem.ShopUtility.ShopEnums;

namespace ShopBLL.Entity.ShopItem.ShopGoods
{
    public class ShopOrder : Order
    {
        public override int OrderId { get; set; }
        public override DateTime Time { get; set; }
        public override double Price { get; set; }
        public ShopOrderDeliveryState DeliveryState { get; set; }
        public ShopOrderPaymentState PaymentState { get; set; }
        public List<Goods> ListOfGoods { get; set; }
        
        public ShopOrder()
        {
            ListOfGoods = new List<Goods>();
        }

    }
}
