﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using DAL;
using IDAL;

namespace WebApp.App_Start
{
    public class AutofacConfig
    {
        public static void Register() {
            var builder = new ContainerBuilder();

            builder.RegisterType<CategoryManager>().As<ICategoryManager>();

            builder.RegisterControllers(typeof(AutofacConfig).Assembly);

            var container = builder.Build();

         
                DependencyResolver.SetResolver(new AutofacDependencyResolver(container));



        }
    }
}