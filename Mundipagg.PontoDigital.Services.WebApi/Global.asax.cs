using AutoMapper;

using Mundipagg.PontoDigital.Application.Automapper;

using Mundipagg.PontoDigital.Services.WebApi.App_Start;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Mundipagg.PontoDigital.Services.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();
             container = Injector.Initialize(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

            //var container = new Container();


            //container.Register<IFuncionarioRepository, FuncionarioRepositorio>(Lifestyle.Singleton);
            //container.Register<IFuncionarioService, FuncionarioService>(Lifestyle.Singleton);

            //container.RegisterWebApiControllers(GlobalConfiguration.Configuration); //web api          
            //container.Verify();

            //DependencyResolver.SetResolver(
            //   new SimpleInjectorDependencyResolver(container));
            //GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container); //web api

            Mapper.Initialize(cfg => cfg.AddProfile<AutomapperProfile>());
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
