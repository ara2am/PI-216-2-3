using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDAL.Context.Interface;
using System.Data.Entity;
using ShopDAL.Entity;
using ShopDAL.Config;

namespace ShopDAL.Context.ContextClasses
{
    public class UserContext : DbContext, IUserContext
    {
        public UserContext ()
            : base ("DbUserConnection")
        {
        }

        public DbSet<User> Users;

        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add (new UserConfig ());
        }
    }
}
