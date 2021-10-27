using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservico.Models;

namespace Microservico.Servicos
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        protected readonly MongoClient cliente;
        protected readonly IMongoDatabase db;
        protected readonly IMongoCollection<Aluno> alunos;

        public AlunoRepositorio()
        {
            cliente = new MongoClient("mongodb://192.168.100.100:27017");
            db = cliente.GetDatabase("dbUnisanta");
            alunos = db.GetCollection<Aluno>("Alunos");
        }

        public IEnumerable<Aluno> ListaAlunos()
        {
            return alunos.Find(_ => true).ToList();
        }



    }
}
