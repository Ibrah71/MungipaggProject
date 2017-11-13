using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Mundipagg.PontoDigital.Application.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.PontoDigital.Application.ViewModel
{
    public class FuncionarioViewModel
    {

        public FuncionarioViewModel()
        {
            Id = ObjectId.GenerateNewId();
        }

        public FuncionarioViewModel(string nome, ObjectId id, double cardId)
        {
            Nome = nome;
            Id = ObjectId.GenerateNewId();
            CardId = cardId;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Card_Id")]
        public double CardId { get; set; }

        public bool IsValid()
        {

            var ValidationResult = new FuncionarioViewModelSelfValidation().Validate(this);
            return ValidationResult.IsValid;
        }

       
    }
}
