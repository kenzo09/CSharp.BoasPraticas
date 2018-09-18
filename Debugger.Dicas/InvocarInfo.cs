using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Debugger.Dicas
{
    public class InvocadorInfo
    {
        public string QuemInvocou([CallerMemberName] string invocador = null)
        {
            return "Foi invocado por " + invocador;
        }

        public string QualArquivoInvocou([CallerFilePath] string arquivoInvocador = null)
        {
            return "Invocado por meio do arquivo " + arquivoInvocador;
        }

        public string QueLinhaInvocou([CallerLineNumber] int numeroLinha = 0)
        {
            return "Na linha " + numeroLinha;
        }
    }
}
