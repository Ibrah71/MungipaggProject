using Mundipagg.PontoDigital.Aplication;
using Mundipagg.PontoDigital.Aplication.Interfaces;
using Mundipagg.PontoDigital.Domain.Interfaces.Repositories;
using Mundipagg.PontoDigital.Infra.Data.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.PontoDigital.CrossCutting
{
   public class BidingApi
    {
        public static Container Start(Container container)
        {
            container.Register<IFuncionarioService, FuncionarioService>();
            container.Register<IFuncionarioRepository, FuncionarioRepositorio>();

            return container;
        }
    }
}
