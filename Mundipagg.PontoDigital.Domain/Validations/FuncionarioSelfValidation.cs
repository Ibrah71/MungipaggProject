using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Mundipagg.PontoDigital.Domain.Entities;
using MongoDB.Bson;

namespace Mundipagg.PontoDigital.Domain.Validations
{
   public class FuncionarioSelfValidation : AbstractValidator<Funcionario>
    {
        public FuncionarioSelfValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");

            RuleFor(f => f.CardId)
               .LessThan(13).WithMessage("The CardId must haver 12 numbers");

            RuleFor(f => f.CardId)
               .GreaterThan(11).WithMessage("The CardId must haver 12 numbers");


        }
    }
}
