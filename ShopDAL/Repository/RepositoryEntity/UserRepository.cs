using ShopDAL.Context.ContextClasses;
using ShopDAL.Entity;
using ShopDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repository.RepositoryEntity
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ShopContext context)
            : base(context)
        {

        }

        public ShopContext PContext
        {
            get { return Context as ShopContext; }
        }

        public User GetUser (int id)
        {
            return Get (id);
        }
    }
}
