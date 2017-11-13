using AutoMapper;
using Mundipagg.PontoDigital.Application.Automapper;
using Mundipagg.PontoDigital.MVC.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Mundipagg.PontoDigital.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SimpleInjectorInitializer.Initialize();
            Mapper.Initialize(cfg => cfg.AddProfile<AutomapperProfile>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
