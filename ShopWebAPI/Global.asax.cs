﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using ShopWebAPI.Dependencies;
using ShopBLL.Dependencies;

namespace ShopWebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private IKernel _kernel;

        protected void Application_Start()
        {
            RegisterServices ();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver (_kernel);
        }

        private void RegisterServices ()
        {
            _kernel = new StandardKernel (new BLLModule ());
        }
    }
}
