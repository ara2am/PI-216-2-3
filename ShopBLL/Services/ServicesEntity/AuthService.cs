using ShopBLL.Entity.User;
using ShopBLL.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ShopDAL.Context.Interface;
using ShopDAL.Context.ContextClasses;

namespace ShopBLL.Services.ServicesEntity
{
    public class AuthService : Service<User>,IAuthService
    {
        public AuthService(string connection = "DbShopConnection")
          : base(connection)
        {

        }


        public ActionResult Register (User user)
        {
            return null;
        }

        public ClaimsIdentity Login (User user)
        {
            throw new NotImplementedException ();
        }

     
        public override void Add(User obj)
        {
            Unit.users.Add(mapper.Map<User, ShopDAL.Entity.User>(obj));
            Unit.Complete();
        }

        public override void Del(User obj)
        {
            Unit.users.Del(mapper.Map<User, ShopDAL.Entity.User>(obj));
            Unit.Complete();
        }

        public override User Get(int id)
        {
            return mapper.Map<User>(Unit.users.Get(id));
        }

        public override ICollection<User> GetAll()
        {
            return mapper.Map<ICollection<User>>(Unit.users.GetAll());
        }

        public override void Update(int id, User obj)
        {
            Unit.types.Update(id, mapper.Map<User, ShopDAL.Entity.ShopItem.ShopGoods.TypeOfGoods>(obj));
            Unit.Complete();
        }

    }
}
