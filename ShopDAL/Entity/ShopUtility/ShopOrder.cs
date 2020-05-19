using ShopDAL.Entity.ShopItem.ShopEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Entity.ShopUtility
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
