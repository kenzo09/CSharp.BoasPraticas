using System;
using static System.Console;

namespace APP.AulaAtributo
{
    class Program
    {
        static Aluno aluno;

        static void Main(string[] args)
        {
            InitializarPrograma();

            var alunoRepository = new AlunoRepository(aluno);
            alunoRepository.GetDisplayAluno();

            WriteLine("Pressione ENTER para sair");
            ReadLine();
        }

        private static void InitializarPrograma()
        {
            aluno = new Aluno()
            {
                Nome = "Conor Mcgregor",
                Matricula = 56428,
                Curso = new Curso()
                {
                    Descricao = "MBA Arquitetura e Desenvolvimento na Plataforma .NET",
                    Disciplinas = new System.Collections.Generic.List<Disciplina>()
                    {
                        new Disciplina() { Titulo = ".NET Visão Arquitetural e Boas Práticas", Nota = 7},
                        new Disciplina() { Titulo = "Gestão de Configuração - ALM e DevOps", Nota = 9},
                        new Disciplina() { Titulo = "Arquitetura de Banco de Dados e Persistência", Nota = 10},
                        new Disciplina() { Titulo = "Desenvolvimento Web", Nota = 4}
                    }
                }
            };
        }
    }
}
