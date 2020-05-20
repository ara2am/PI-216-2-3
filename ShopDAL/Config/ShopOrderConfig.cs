using ShopDAL.Entity.ShopUtility;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Config
{
    class ShopOrderConfig : EntityTypeConfiguration<ShopOrder>
    {
        public ShopOrderConfig()
        {
            this.ToTable(" ShopOrders");

            this.HasMany(p => p.ListOfGoods)
                .WithMany(g => g.ListOfOrders);
        }
    }
}
