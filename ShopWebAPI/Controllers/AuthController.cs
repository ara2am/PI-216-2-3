using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web;
using ShopWebAPI.Models.Auth;
using ShopBLL.Services.Interface;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using ShopBLL.Entity.User;
using System.Security.Claims;

namespace ShopWebAPI.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route ("api/Auth/Login")]
        public IHttpActionResult Login ([FromBody]LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, Password = model.Password };
                ClaimsIdentity claim = getAuthService ().Login (user);
                if (claim == null)
                {
                    return Ok ("Incorrect login or password!");
                } else
                {
                    getAuthentication ().SignOut ();
                    getAuthentication ().SignIn (new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                }

                return Ok ("");
            }
            return BadRequest ();
        }

        [HttpGet]
        [Route ("api/Auth/Logout")]

        public IHttpActionResult Logout ()
        {
            getAuthentication ().SignOut ();
            return Ok ();
        }

        [HttpPost]
        [Route ("api/Auth/Register")]
        public IHttpActionResult Register ([FromBody]RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Email = model.Email,
                    Password = model.Password,
                    Address = model.Address,
                    UserName = model.UserName,
                    FullName = model.FullName,
                    PreferredLanguage = model.PreferredLanguage,
                    RoleName = "user"
                };
                return Ok (getAuthService ().Register (user));
            }
            return BadRequest ();
        }

        private IAuthService getAuthService ()
        {
            return HttpContext.Current.GetOwinContext ().GetUserManager<IAuthService> ();
        }

        private IAuthenticationManager getAuthentication ()
        {
            return HttpContext.Current.GetOwinContext ().Authentication;
        }
    }
}