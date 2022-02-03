using AcademiaCodeBuilderAPI.Conexoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaCodeBuilderAPI.Controllers
{
  
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly Conexoes.Sql _sql;

        public AlunoController()
        {
            _sql = new Conexoes.Sql();
        }


        [HttpPost ("v1/Aluno")]
        public void InserirAluno(Entidades.Aluno aluno)
        {
            _sql.InserirAluno(aluno);
        }

        [HttpGet ("v1/Aluno/{identificador}")]
        public bool VerificarAluno(string identificador)
        {
            return _sql.VerificarExistenciaAluno(identificador);
        }

        [HttpPut("v1/Aluno")]
        public void AtualizarAluno(Entidades.Aluno aluno)
        {
            _sql.AtualizarAluno(aluno);
        }


    }
}
