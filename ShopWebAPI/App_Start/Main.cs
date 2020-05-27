using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using ShopBLL.Services.Interface;
using ShopBLL.Services.ServicesEntity;

[assembly: OwinStartup (typeof (ShopWebAPI.App_Start.Main))]
namespace ShopWebAPI.App_Start
{
    public class Main
    {
        public void Configuration (IAppBuilder app)
        {
            app.CreatePerOwinContext<IAuthService> (CreateAuthService);
            app.UseCookieAuthentication (new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString ("/Auth/Login"),
            });
        }

        public IAuthService CreateAuthService ()
        {
            return new AuthService ("DbShopConnection");
        }
    }
}