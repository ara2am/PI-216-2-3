using ShopBLL.Entity.User;
using ShopBLL.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Services.ServicesEntity
{
    public class AuthService : IAuthService
    {
        public ActionResult Register (User user)
        {
            throw new NotImplementedException ();
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
