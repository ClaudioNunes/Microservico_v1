using Microservico.Models;
using System.Collections.Generic;

namespace Microservico.Servicos
{
    public interface IAlunoRepositorio
    {
        IEnumerable<Aluno> ListaAlunos();
    }
}