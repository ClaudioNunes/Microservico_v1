using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservico.Models;
using Microservico.Servicos;

namespace Microservico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MicroServicoController : ControllerBase
    {
        protected readonly IAlunoRepositorio repoAluno;
        public MicroServicoController(IAlunoRepositorio repo)
        {
            repoAluno = repo;
        }


        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return repoAluno.ListaAlunos();
        }
    }
}
