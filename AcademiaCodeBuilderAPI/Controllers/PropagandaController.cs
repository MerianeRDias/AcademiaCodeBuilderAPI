using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaCodeBuilderAPI.Controllers
{
    [ApiController]
    public class PropagandaController : ControllerBase
    {
        private readonly Conexoes.Sql _sql;

        public PropagandaController()
        {
            _sql = new Conexoes.Sql();
        }

        [HttpPost("v1/Propaganda")]
        public void InserirPropaganda(Servicos.Propaganda propaganda)
        {
            _sql.InserirPropaganda(propaganda);
        }

        [HttpGet("v1/Propaganda/{identificador}")]
        public bool VerificarPropaganda(string identificador)
        {
            return _sql.VerificarExistenciaPropaganda(identificador);
        }

        [HttpPut("v1/Propaganda")]
        public void AtualizarPropaganda(Servicos.Propaganda propaganda)
        {
            _sql.AtualizarPropaganda(propaganda);
        }
    }
}
