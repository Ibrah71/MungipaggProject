using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;


namespace Mundipagg.PontoDigital.MVC.App_Start
{
    public class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultLifestyle = new WebRequestLifestyle();


            InitializeContainer(container);
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));


        }

        private static void InitializeContainer(Container container)
        {
            PontoDigital.CrossCutting.Bindings.Start(container);
        }
    }
}