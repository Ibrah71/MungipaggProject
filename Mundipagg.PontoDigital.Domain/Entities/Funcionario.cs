using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using Mundipagg.PontoDigital.Domain.Validations;

namespace Mundipagg.PontoDigital.Domain.Entities
{
   public class Funcionario
    {
          [BsonId]
        public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public double CardId { get; set; }

        public Funcionario(ObjectId id, string nome, double cardId)
        {
            Nome = nome;
            Id = id;
            CardId = cardId;
        }

        public bool IsValid()
        {

         var  ValidationResult =  new  FuncionarioSelfValidation().Validate(this);
         return ValidationResult.IsValid;
        }

      

    }
}
