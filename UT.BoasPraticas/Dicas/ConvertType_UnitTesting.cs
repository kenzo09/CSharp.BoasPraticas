using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    public class ConvertType_UnitTesting
    {
        [TestMethod]
        public void Testando_ConvertType()
        {
            Type Tipo;
            Type TipoConvertido;
            object Valor;
            object ValorConvertido;

            Valor = "15";
            Tipo = typeof(int);

            ValorConvertido = Convert.ChangeType(Valor, Tipo);
            TipoConvertido = ValorConvertido.GetType();
            Console.WriteLine("Tipo 1");
            Console.WriteLine(ValorConvertido);
            Console.WriteLine(TipoConvertido);

            Tipo = typeof(double);

            ValorConvertido = Convert.ChangeType(Valor, Tipo);
            TipoConvertido = ValorConvertido.GetType();
            Console.WriteLine("Tipo 2");
            Console.WriteLine(ValorConvertido);
            Console.WriteLine(TipoConvertido);

            // Boolean

            ValorConvertido = Convert.ToBoolean(ValorConvertido);
            TipoConvertido = ValorConvertido.GetType();
            Console.WriteLine("Tipo 3");
            Console.WriteLine(ValorConvertido);
            Console.WriteLine(TipoConvertido);
        }
    }
}
