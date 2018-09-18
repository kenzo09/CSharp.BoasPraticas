using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Diretivas
{
    [TestClass]
    class Directive_Testing
    {
        // Diretivas de pré-processamento
        [TestMethod]
        public void TestMethod_Define_PreProcessamento()
        {
#if DEBUG
            Console.WriteLine("Está em modo de depuração");
#endif
            Console.WriteLine("Faça algo...");
        }

        [TestMethod]
        public void TestMethod_Warning_Error()
        {
#if DEBUG && RELEASE
#error "Foi definido DEBUG e RELEASE simultaneamante"
#endif
#warning "Não se esqueça de remover está linha antes da revisão do código"
            Console.WriteLine("Esse trecho de código está sinistro...");
        }

        #region Método teste Diretivas
        public void TesteDiretivas()
        {
            // Faça um teste...
        }
        #endregion

        [TestMethod]
        public void Teste_Diretiva_line()
        {
#line 200 "UT.BoasPraticas.ProjetoOriginal"
            //int a = "a";
#line default
            //int b = "b";
        }

        [TestMethod]
        public void Teste_Diretiva_Pragma()
        {
#pragma warning disable
            int valor;

#pragma warning restore
            int valor1;
        }
    }
}
