using ShopDAL.Context.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Context.ContextClasses
{
    class ShopContext : DbContext, IShopContext
    {

    }
}
