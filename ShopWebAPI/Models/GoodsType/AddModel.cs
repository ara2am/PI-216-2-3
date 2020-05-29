using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopWebAPI.Models.GoodsType
{
    public class AddModel
    {
        [Required]
        [StringLength (250, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 250 characters")]
        public string Name { get; set; }

        [Required]
        [Range (1, 200, ErrorMessage = "Age must be in interval [5,250]")]
        public int AgeLimit { get; set; }
        public bool NeedPermission { get; set; }
    }
}