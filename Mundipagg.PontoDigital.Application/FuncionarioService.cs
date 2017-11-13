
using System;
using System.Collections.Generic;
using Mundipagg.PontoDigital.Domain.Entities;
using Mundipagg.PontoDigital.Domain.Interfaces.Repositories;
using Mundipagg.PontoDigital.Aplication.Interfaces;
using Mundipagg.PontoDigital.Application.ViewModel;
using AutoMapper;
using Mundipagg.PontoDigital.Application.Validations;

namespace Mundipagg.PontoDigital.Aplication
{
   public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _repository;

        public FuncionarioService(IFuncionarioRepository repository)
        {
            
            _repository = repository;
        }
               

        public bool Add(FuncionarioViewModel funcionario)
        {
            if (funcionario.IsValid() && CardIdValidation.CardIdValidationStart(funcionario))
            {
                var funcionarioDomain = Mapper.Map<FuncionarioViewModel, Funcionario>(funcionario);
                _repository.Add(funcionarioDomain);

                return true;
            }

            else
            {
                return false;
            }
        }

 

        public List<FuncionarioViewModel> GetAll()
        {
            var funcionarioViewModel = Mapper.Map<List<Funcionario>, List<FuncionarioViewModel>>(_repository.GetAll());

            return funcionarioViewModel;
        }
    
        
        public FuncionarioViewModel GetByCardId(double cardId)
        {
            var funcionarioViewModel = Mapper.Map<Funcionario, FuncionarioViewModel>(_repository.GetByCardId(cardId));

            return funcionarioViewModel;
        }

            

        public void Remove(double cardId)
        {
           
            _repository.Remove(cardId);
        }

        public bool Update( FuncionarioViewModel funcionario)
        {
            if (funcionario.IsValid() && CardIdValidation.CardIdValidationStart(funcionario))
            {
                var funcionarioDomain = Mapper.Map<FuncionarioViewModel, Funcionario>(funcionario);

            _repository.Update(funcionarioDomain);
                return true;
        }


           else
            {
                return false;
            }
        }
    }
}
