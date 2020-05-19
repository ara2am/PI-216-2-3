using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Entity.ShopItem.ShopEnums
{
    class TypeOfGoods
    {
        [Key]
        public int TypeOfGoodsId { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 250 characters")]
        public string Name { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Age must be in interval [5,250]")]
        public int AgeLimit { get; set; }
        public bool NeedPermission { get; set; }
    }
}
