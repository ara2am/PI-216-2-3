﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Ninject;

namespace ShopWebAPI.Dependencies
{
    public class NinjectResolver : NinjectScope, IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectResolver (IKernel kernel)
            : base (kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope ()
        {
            return new NinjectScope (_kernel.BeginBlock ());
        }
    }
}