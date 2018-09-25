using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    public class ExtensionMethods_UnitTesting
    {
        [TestMethod]
        public void TestMethod_Data()
        {
            Console.WriteLine(DateTime.Now.ToRetornaFormatoPadrao());
        }

        [TestMethod]
        public void TestMethod_Data_Ano()
        {
            Console.WriteLine(DateTime.Now.ToRetornarAno());
        }

        [TestMethod]
        public void TestMethod_Nome_Padrao()
        {
            var nome = "Flávio Mariotti";
            Console.WriteLine(nome.ToRetornaFormatoNome());
        }
    }

    public static class Alfanumericos
    {
        public static string ToRetornaFormatoNome(this string nome)
        {
            var separacao = nome.Split(' ');
            return separacao[1] + ", " + separacao[0];
        }
    }

    public static class Datas
    {
        public static string ToRetornaFormatoPadrao(this DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm");
        }
        public static int ToRetornarAno(this DateTime date)
        {
            return date.Year;
        }
    }
}
