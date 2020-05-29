using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopWebAPI.Models.Goods
{
    public class AddModel
    {
        public int GoodsId { get; set; }

        [Required]
        [StringLength (250, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 250 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength (1000, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 1000 characters")]
        public string Description { get; set; }

        [Required]
        [Range (double.Epsilon, double.MaxValue, ErrorMessage = "Must be positive value")]
        public double Price { get; set; }
    }
}