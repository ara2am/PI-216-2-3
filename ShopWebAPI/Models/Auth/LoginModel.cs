﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopWebAPI.Models.Auth
{
    public class LoginModel
    {
        [Required]
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}