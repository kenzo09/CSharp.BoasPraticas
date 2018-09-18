using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    public class Enumerador_UnitTesting
    {
        [Flags]
        public enum Esportes
        {
            Nenhum = 0,
            Futebol = 1,
            Golfe = 2,
            Beisebol = 4,
            Regby = 8,
            Volei = 16,
            Tenis = 32,
            Hoquei = 64,
            Boxe = 128
        }

        [TestMethod]
        public void TestMethod_GetValores()
        {
            //foreach (int item in Enum.GetValues(typeof(Esportes)))
            //{
            //    Console.WriteLine(item);
            //}

            Enum.GetValues(typeof(Esportes)).Cast<int>().ToList()
                .ForEach(valor => Console.Write(valor + "\n"));
        }

        [TestMethod]
        public void TestMethod_GetDescricao()
        {
            //foreach (var item in Enum.GetNames(typeof(Esportes)))
            //{
            //    Console.WriteLine(item);
            //}

            Enum.GetNames(typeof(Esportes)).ToList()
                .ForEach(descricao => Console.Write(descricao + "\n"));
        }

        [TestMethod]
        public void TestMethod_UtilizandoMetodo_HasFlag()
        {
            Esportes favoritos = Esportes.Futebol | Esportes.Tenis | Esportes.Hoquei;
            Esportes flagValue = Esportes.Tenis | Esportes.Futebol;

            Console.WriteLine($"{favoritos} está incluído? {favoritos.HasFlag(flagValue)}");
        }
    }
}
