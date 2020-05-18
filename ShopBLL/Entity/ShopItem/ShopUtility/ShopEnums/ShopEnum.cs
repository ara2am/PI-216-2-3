using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBLL.Entity.ShopItem.ShopUtility.ShopEnums
{
    public enum ShopOrderDeliveryState
    {
        Delivered = 0,
        In_Delivery = 1,
        Awaiting_delivery = 2,
    }

    public enum ShopOrderPaymentState
    {
        Paid = 0,
        Not_paid = 1,
        Partially_paid = 2,
    }
}
