using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ShopDAL.Entity;

namespace ShopDAL.Config
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig ()
        {
            this.ToTable ("Users");
        }
    }
}
