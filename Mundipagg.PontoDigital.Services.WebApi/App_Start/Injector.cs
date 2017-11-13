using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mundipagg.PontoDigital.Services.WebApi.App_Start
{
    public class Injector
    {
        public static Container Initialize(Container container)
        {
          

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

          return  InitializeContainer(container);

            
            


        }

        private static Container InitializeContainer(Container container)
        {
          return  CrossCutting.BidingApi.Start(container);
        }
    }
}