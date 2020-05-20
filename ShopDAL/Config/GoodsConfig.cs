using ShopDAL.Entity.ShopUtility;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Config
{
    class GoodsConfig : EntityTypeConfiguration<ShopOrder>
    {
        public GoodsConfig()
        {
            this.ToTable("Goods");
        }
    }
}
