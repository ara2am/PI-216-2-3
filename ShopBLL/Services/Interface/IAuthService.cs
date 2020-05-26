using ShopBLL.Entity.User;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Services.Interface
{
    public interface IAuthService : IDisposable
    {
        ActionResult Register (User user);
        ClaimsIdentity Login (User user);
    }
}
