using ShopDAL.Entity.ShopItem.ShopEnums;
using ShopDAL.Entity.ShopItem.ShopGoods;
using ShopDAL.Entity.ShopUtility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Context.ContextClasses
{
    public class Initializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            TypeOfGoods type1 = new TypeOfGoods()
            {
                Name = "Programming tools",
                NeedPermission = false,
                AgeLimit = 12,
            };
            Goods goods1 = new Goods()
            {
                Name = "Scratch",
                Description = "blablablablabla this is Scratch",
                Price = 100.0,
                ListOfOrders = new List<ShopOrder>(),
                Type = type1,
            };

            TypeOfGoods type2 = new TypeOfGoods()
            {
                Name = "Weapon",
                NeedPermission = false,
                AgeLimit = 12,
            };
            Goods goods2 = new Goods()
            {
                Name = "Glock",
                Description = "Weapons manufacturer headquartered in Deutsch-Wagram, Austria, named after its founder, Gaston Glock",
                Price = 1200.50,
                ListOfOrders = new List<ShopOrder>(),
                Type = type2,
            };

            ShopOrder orders1 = new ShopOrder()
            {
                DeliveryState = ShopOrderDeliveryState.In_Delivery,
                PaymentState = ShopOrderPaymentState.Not_paid,
                Price = 12300,
                Time = DateTime.Now,
                ListOfGoods = new List<Goods>(),
            };

            ShopOrder orders2 = new ShopOrder()
            {
                DeliveryState = ShopOrderDeliveryState.Awaiting_delivery,
                PaymentState = ShopOrderPaymentState.Paid,
                Price = 300,
                Time = DateTime.Now,
                ListOfGoods = new List<Goods>(),
        };
            orders1.ListOfGoods.Add(goods1);
            orders1.ListOfGoods.Add(goods2);
            orders2.ListOfGoods.Add(goods1);

            goods1.ListOfOrders.Add(orders1);
            goods1.ListOfOrders.Add(orders2);
            goods2.ListOfOrders.Add(orders1);

            context.Goods.Add(goods1);
            context.Goods.Add(goods2);
            context.ShopOrders.Add(orders1);
            context.ShopOrders.Add(orders2);
            context.TypeOfGoods.Add(type1);
            context.TypeOfGoods.Add(type2);

            context.SaveChanges();
        }
    }
}
