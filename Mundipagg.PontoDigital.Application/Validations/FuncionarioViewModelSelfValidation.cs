using FluentValidation;
using Mundipagg.PontoDigital.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.PontoDigital.Application.Validations
{
  public class FuncionarioViewModelSelfValidation : AbstractValidator<FuncionarioViewModel>
    {
        
        public FuncionarioViewModelSelfValidation()
        {
            RuleFor(f => f.Nome)
               .NotEmpty().WithMessage("Please ensure you have entered the Name")
               .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");

           
            
        }


        
    }
}
