
using MongoDB.Driver;
using Mundipagg.PontoDigital.Domain.Entities;
using Mundipagg.PontoDigital.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Mundipagg.PontoDigital.Infra.Data.Repositories
{
   public class FuncionarioRepositorio : IFuncionarioRepository
    {
        public static string connectionString = "mongodb://localhost:27017";
        public static MongoClient client = new MongoClient(connectionString);
        public static IMongoDatabase db = client.GetDatabase("teste");

        public void Add(Funcionario funcionario)
        {
                     
                var Funcionarios = db.GetCollection<Funcionario>("funcionarios");
                Funcionarios.InsertOne(funcionario);
            
           
        }

      

        public List<Funcionario> GetAll()
        {
            List<Funcionario> lista = db.GetCollection<Funcionario>("funcionarios")
            .Find(_ => true).ToList();

            return lista;
        }

        public Funcionario GetByCardId(double cardId)
        {


            var funcionario = db.GetCollection<Funcionario>("funcionarios")
            .Find(f => f.CardId == cardId).ToList().SingleOrDefault();

            return funcionario;
        }

        

        public void Remove(double cardId)
        {

            var funcionarios = db.GetCollection<Funcionario>("funcionarios");

             funcionarios.DeleteOne(f => f.CardId == cardId );
        }

        public void Update( Funcionario funcionario)
        {
           

            var funcionarios = db.GetCollection<Funcionario>("funcionarios");

            var filter = Builders<Funcionario>.Filter.Eq("CardId", funcionario.CardId);
            var update = Builders<Funcionario>.Update
                    .Set("Nome", funcionario.Nome)
                    .Set("CardId", funcionario.CardId);
            funcionarios.UpdateOne(filter, update);


        }
    }
}
