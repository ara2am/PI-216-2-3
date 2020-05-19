using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Entity.ShopItem.ShopEnums
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
