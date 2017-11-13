
using SimpleInjector;
using Mundipagg.PontoDigital.Aplication;
using Mundipagg.PontoDigital.Aplication.Interfaces;
using CommonServiceLocator.SimpleInjectorAdapter;
using Mundipagg.PontoDigital.Domain.Interfaces.Repositories;
using Mundipagg.PontoDigital.Infra.Data.Repositories;

namespace Mundipagg.PontoDigital.CrossCutting
{
   public class Bindings
    {
        public static void Start(Container container)
        {
           container.Register<IFuncionarioService, FuncionarioService>();
            container.Register<IFuncionarioRepository, FuncionarioRepositorio>();

            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(()=> new SimpleInjectorServiceLocatorAdapter(container));
        }
    }
}
