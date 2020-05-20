using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ShopDAL.Entity.ShopItem.ShopGoods;

namespace ShopDAL.Config
{
    public class TypeOfGoodsConfig : EntityTypeConfiguration<TypeOfGoods>
    {
        public TypeOfGoodsConfig()
        {
            this.ToTable("TypeOfGoods");
        }
    }
}
