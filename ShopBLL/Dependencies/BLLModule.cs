using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using ShopDAL.Dependencies;
using ShopBLL.Services.Interface;
using ShopBLL.Services.ServicesEntity;

namespace ShopBLL.Dependencies
{
    public class BLLModule : NinjectModule
    {
        public override void Load ()
        {
            Bind<IAuthService> ().ToConstructor (x => new AuthService ());
            Bind<IGoodsServices> ().ToConstructor (x => new GoodsServices ());
        }
    }
}
