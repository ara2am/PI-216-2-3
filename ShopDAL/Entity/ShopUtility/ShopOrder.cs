using ShopDAL.Entity.ShopItem.ShopEnums;
using ShopDAL.Entity.ShopItem.ShopGoods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Entity.ShopUtility
{
    [Table("TypeOfGoods")]
    public class ShopOrder : Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int OrderId { get; set; }
        public override DateTime Time { get; set; }

        [Required]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Must be positive value")]
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
