using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    public class Deconstruction_UnitTesting
    {
        [TestMethod]
        public void Testando_VariavelDeSaida_Deconstruction()
        {
            AlunoFiap aluno = new AlunoFiap()
            {
                Nome = "Maria da Silva",
                RM = 56235
            };
            var (PrimeiroNome, Matricula) = aluno;
            Console.WriteLine($"Aluno: {PrimeiroNome} Matrícula: {Matricula}");
        }
    }

    public class AlunoFiap
    {
        public string Nome { get; set; }
        public int RM { get; set; }
        public void Deconstruct(out string nome, out int matricula)
        {
            nome = Nome;
            matricula = RM;
        }
    }

    public static class ExtensionMethodClass
    {
        public static void Deconstruct(this AlunoFiap aluno, out string nome, out int matricula)
        {
            nome = aluno.Nome;
            matricula = aluno.RM;
        }
    }
}
