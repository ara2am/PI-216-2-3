using ShopBLL.Repository.Interface;
using ShopDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repository.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUser (int id);
    }
}
