using System;

namespace AcademiaCodeBuilderAPI.Servicos
{
    public class Faturamento
    {
        public string Identificador { get; set; }
        public DateTime DiaReferencia { get; set; }
        public decimal TotalEntrada { get; set; }

        public decimal TotalSaida { get; set; }
    }
}
