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
    public class AuthService : IAuthService
    {
        IUserContext context = new UserContext ();

        public ActionResult Register (User user)
        {
            
        }

        public ClaimsIdentity Login (User user)
        {
            throw new NotImplementedException ();
        }

        public void Dispose ()
        {
            throw new NotImplementedException ();
        }
    }
}
