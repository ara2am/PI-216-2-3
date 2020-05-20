using ShopDAL.Entity.ShopUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Entity.ShopItem.ShopGoods
{
    [Table("Goods")]
    public class Goods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsId { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 250 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 1000 characters")]
        public string Description { get; set; }

        [Required]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Must be positive value")]
        public double Price { get; set; }

        [ForeignKey("TypeOfGoods")]
        public TypeOfGoods Type { get; set; }
        public ICollection<ShopOrder> ListOfOrders { get; set; }

        public Goods()
        {
            ListOfOrders = new List<ShopOrder>();
        }
    }
}
