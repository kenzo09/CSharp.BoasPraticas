using Debugger.Dicas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Debugger
{
    [TestClass]
    public class UnitTesting_DebuggerDisplay
    {
        [TestMethod]
        public void Teste_Aluno()
        {
            var aluno = new Aluno()
            {
                Nome = "Anderson Silva",
                Email = "anderson@ufc.com",
                Endereco = "Rua Antonio Coelho"
            };                
        }

        [TestMethod]
        public void Teste_AlunoExemplo()
        {
            var aluno = new AlunoExemplo()
            {
                Nome = "Anderson Silva",
                Email = "anderson@ufc.com",
                Endereco = "Rua Antonio Coelho"
            };
        }

        [TestMethod]
        public void Test_InfoDebugging()
        {
            var detalhesDepuracao = new InvocadorInfo();

            Console.WriteLine(detalhesDepuracao.QuemInvocou());
            Console.WriteLine(detalhesDepuracao.QualArquivoInvocou());
            Console.WriteLine(detalhesDepuracao.QueLinhaInvocou());
        }
    }
}
