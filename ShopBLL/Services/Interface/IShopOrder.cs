using System;
using System.Collections.Generic;
using System.Text;
using ShopBLL.Entity.ShopItem.ShopGoods;
using ShopBLL.Entity.ShopItem.ShopUtility.ShopEnums;

namespace ShopBLL.Entity.Interface
{
    interface IShopOrder
    {
        void UpdateDeliveryState(ShopOrderDeliveryState state);
        void UpdatePaymentState(ShopOrderPaymentState state);
    }
}
