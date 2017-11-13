using MongoDB.Bson;
using Moq;
using Mundipagg.PontoDigital.Aplication.Interfaces;
using Mundipagg.PontoDigital.Application.Validations;
using Mundipagg.PontoDigital.Application.ViewModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.PontoDigital.Solution.Application.Tests
{
    [TestFixture]
    public class FuncionarioServiceTests
    {

        Mock<IFuncionarioService> mockFuncionarioService;
       
        [TestCase("Marcos")]
        [Test]
        public void FuncionarioIsValid_True( string nome) 
        {
            
            var  id = ObjectId.GenerateNewId();
            Double cardId = 12332112322;

            FuncionarioViewModel funcionario = new FuncionarioViewModel( nome, id, cardId  );

            mockFuncionarioService = new Mock<IFuncionarioService>(MockBehavior.Strict);

            var result = funcionario.IsValid();
            
            Assert.True( result);

        }

        [TestCase("")]
        [Test]
        public void FuncionarioIsValid_False(string nome)
        {

            var id = ObjectId.GenerateNewId();
            Double cardId = 12332112322;

            FuncionarioViewModel funcionario = new FuncionarioViewModel(nome, id, cardId);

           
            var result = funcionario.IsValid();

            Assert.False(result);

        }

        [TestCase(123321123222)]
        [Test]
        public void CardIdValidation_true(double cardId )
        {
           string nome = "Marcos";
            var id = ObjectId.GenerateNewId();
            

            FuncionarioViewModel funcionario = new FuncionarioViewModel(nome, id, cardId);

            var result = CardIdValidation.CardIdValidationStart(funcionario);           

            Assert.True(result);

        }

        [TestCase(12)]
        [Test]
        public void CardIdValidation_false(double cardId)
        {
            string nome = "Marcos";
            var id = ObjectId.GenerateNewId();


            FuncionarioViewModel funcionario = new FuncionarioViewModel(nome, id, cardId);

            mockFuncionarioService = new Mock<IFuncionarioService>(MockBehavior.Strict);

            var result = CardIdValidation.CardIdValidationStart(funcionario);

            Assert.False(result);

        }




    }
}
