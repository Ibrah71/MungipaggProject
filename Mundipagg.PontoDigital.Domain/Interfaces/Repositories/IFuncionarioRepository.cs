using Mundipagg.PontoDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.PontoDigital.Domain.Interfaces.Repositories
{
  public  interface IFuncionarioRepository 
    {
         void Add(Funcionario funcionario);
        List<Funcionario> GetAll();
        Funcionario GetByCardId(double cardId);
        void Update( Funcionario funcionario);        
        void Remove(double cardId);
    }
}
