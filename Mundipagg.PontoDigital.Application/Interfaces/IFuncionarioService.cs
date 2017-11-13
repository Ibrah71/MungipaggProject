using Mundipagg.PontoDigital.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace Mundipagg.PontoDigital.Aplication.Interfaces
{
    public interface IFuncionarioService 
    {
        bool Add(FuncionarioViewModel funcionario);
        List<FuncionarioViewModel> GetAll();
        FuncionarioViewModel GetByCardId(double CardId);
        bool Update(FuncionarioViewModel funcionario);
        void Remove(double cardId);
    }
}
