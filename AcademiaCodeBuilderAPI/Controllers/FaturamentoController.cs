using AcademiaCodeBuilderAPI.Conexoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaCodeBuilderAPI.Controllers
{
    [ApiController]
    public class FaturamentoController : ControllerBase
    {
        private readonly Conexoes.Sql _sql;

        public FaturamentoController()
        {
            _sql = new Conexoes.Sql();
        }

        [HttpPost("v1/Faturamento")]
        public void InserirFaturamento(Servicos.Faturamento faturamento)
        {
            _sql.InserirFaturamento(faturamento);
        }

        [HttpGet("v1/Faturamento/{identificador}")]
        public bool VerificarFaturamento(string identificador)
        {
            return _sql.VerificarExistenciaFaturamento(identificador);
        }

        [HttpPut("v1/Faturamento")]
        public void AtualizarFaturamento(Servicos.Faturamento faturamento)
        {
            _sql.AtualizarFaturamento(faturamento);
        }

    }
}
