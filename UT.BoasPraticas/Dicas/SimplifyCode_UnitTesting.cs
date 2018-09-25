using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    class SimplifyCode_UnitTesting
    {

        [TestMethod]
        public void Testando_CodigoSimplificado_CSharp7()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "Anderson Silva",
                Matricula = "12345"
            };
            //Code_AntesDoCShart_7(aluno);
            Code_ComCSharp_7(aluno);
            Code_ComCSharp_7_Switch(aluno);

            Professor professor = new Professor()
            {
                Nome = "Adenor Leonardo (Tite)",
                Disciplina = ".NET Boas práticas"
            };
            //Code_AntesDoCShart_7(professor);
            Code_ComCSharp_7(professor);
        }

        public void Code_AntesDoCSharp_7(Pessoa pessoa)
        {
            var aluno = pessoa as Aluno;
            if (aluno != null)
            {
                Console.WriteLine("Parabéns {0}, você passou no processo seletivo e sua matrícula é {1}", aluno.Nome, aluno.Matricula);
            }
            var professor = pessoa as Professor;
            if (professor != null)
            {
                Console.WriteLine("Parabéns {0}, você é o novo professor da disciplina {1}", professor.Nome, professor.Disciplina);
            }
        }

        public void Code_ComCSharp_7(Pessoa pessoa)
        {
            if (pessoa is Aluno aluno)
                Console.WriteLine($"Parabéns {aluno.Nome}, você passou no processo seletivo e sua matrícula é {aluno.Matricula}");

            if (pessoa is Professor professor)
                Console.WriteLine($"Parabéns {professor.Nome}, você é o novo professor da disciplina {professor.Disciplina}");
        }

        public void Code_ComCSharp_7_Switch(Pessoa pessoa)
        {
            switch (pessoa)
            {
                case Aluno aluno:
                    {
                        Console.WriteLine($"Parabéns {aluno.Nome}, você passou no processo seletivo e sua matrícula é {aluno.Matricula}");
                        break;
                    }
                case Professor professor:
                    {
                        Console.WriteLine($"Parabéns {professor.Nome}, você é o novo professor da disciplina {professor.Disciplina}");
                        break;
                    }
                default:
                    break;
            }
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
    }

    public class Aluno : Pessoa
    {
        public Aluno()
        {
        }

        public string Matricula { get; set; }
    }

    public class Professor : Pessoa
    {
        public Professor()
        {
        }

        public string Disciplina { get; set; }
    }
}
