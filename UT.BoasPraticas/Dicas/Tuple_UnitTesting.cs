using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    class Tuple_UnitTesting
    {
        #region Tuple
        [TestMethod]
        public void Simples_Tuple()
        {
            var tupleUmElemento = new Tuple<int>(1);

            var tupleDoisElementos = new Tuple<int, string>(1, ".NET Core");

            var tupleCincoElementos = new Tuple<int, int, string, int, decimal>(1, 2, "C#", 4, 5m);

            // Static Create methods
            var tubleDinamico = Tuple.Create(50, "FIAP", DateTime.Now);
        }

        [TestMethod]
        public void Tuple_Recuperando_Valores()
        {
            var tuple = Tuple.Create(10, "MBA .NET");

            int valor = tuple.Item1;
            string texto = tuple.Item2;

            // tuple.Item1 = 10; -- Erro de compilação
        }

        [TestMethod]
        public void Tuple_Dicionario_Ordenado()
        {
            //var tuple1 = Tuple.Create(3, "A");
            //var tuple2 = Tuple.Create(2, "B");
            //var tuple3 = Tuple.Create(1, "C");
            //var tuple4 = Tuple.Create(4, "Z");

            var tuple1 = Tuple.Create("Z", 3);
            var tuple2 = Tuple.Create("A", 2);
            var tuple3 = Tuple.Create("B", 1);
            var tuple4 = Tuple.Create("C", 4);

            var dicionario = new SortedDictionary<Tuple<string, int>, string>();

            dicionario.Add(tuple1, "Esse foi o primeiro");
            dicionario.Add(tuple2, "Esse foi o segundo");
            dicionario.Add(tuple3, "Esse foi o terceiro");
            dicionario.Add(tuple4, "Esse foi o quarto");

            foreach (var item in dicionario)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        [TestMethod]
        public void Tuple_MediaTurma_MBA_Exemplo1()
        {
            int[] turma = { 7, 9, 4, 10, 8, 8 };
            MediaNota mediaTurma = new MediaNota();
            var (media, totalAlunos) = mediaTurma.GetMediaTotalAlunos(turma);

            Console.WriteLine($"Média foi {media} sobre {totalAlunos} alunos");
        }

        [TestMethod]
        public void Tuble_MediaTurma_MBA_Exemplo2()
        {
            int[] turma = { 1, 2, 2, 2, 8, 8 };
            MediaNota mediaTurma = new MediaNota();
            int indexMedia = 5;
            var (media, totalAlunos, isMediaBaixa) = mediaTurma.GetMediaTotalAlunos(turma, indexMedia);

            Console.WriteLine($"Média foi {media} sobre {totalAlunos} alunos. " +
                $"{(media < indexMedia ? "Turma abaixo da média" : "Turma na média")}");
        }
    }

    public class MediaNota
    {
        public (int media, int alunos) GetMediaTotalAlunos(int[] turma)
        {
            var resultadoTuple = (media: 0, total: 0);
            resultadoTuple = (turma.Sum() / turma.Count(), turma.Count());

            return resultadoTuple;
        }

        public (int media, int alunos, bool isMediaIndicador) GetMediaTotalAlunos(int[] turma, int indexMedia)
        {
            var resultadoTuple = (media: 0, total: 0, isBaixa: true);
            resultadoTuple = (turma.Sum() / turma.Count(), turma.Count(), resultadoTuple.media.IsMediaAbaixo(7));

            return resultadoTuple;
        }
    }

    public static class ExtensionMethods
    {
        public static bool IsMediaAbaixo(this int turma, int mediaComparativa)
        {
            return (turma < mediaComparativa) ? true : false;
        }
    }
}
