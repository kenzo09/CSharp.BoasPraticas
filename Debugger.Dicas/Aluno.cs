using System;
using System.Diagnostics;

namespace Debugger.Dicas
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Esse recurso não pode ser instanciado";
        }
    }

    [DebuggerDisplay("Esse cliente {Nome} tem o e-mail {Email}")]
    public class AlunoExemplo
    {
        public string Nome { get; set; }
        [DebuggerDisplay("{Endereco}, São Paulo - SP")]
        public string Endereco { get; set; }
        public string Email { get; set; }
    }
}
