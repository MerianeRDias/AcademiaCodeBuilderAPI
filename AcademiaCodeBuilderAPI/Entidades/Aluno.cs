using System;

namespace AcademiaCodeBuilderAPI.Entidades
{
    public class Aluno
    {
        public string Identificador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
