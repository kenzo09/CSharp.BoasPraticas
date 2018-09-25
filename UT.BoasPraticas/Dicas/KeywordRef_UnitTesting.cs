using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    public class KeywordRef_UnitTesting
    {
        [TestMethod]
        public void Testando_UsoRef()
        {
            int valorA = 50;
            int valorB = 100;
            Recursos recursos = new Recursos();

            int valorResultado = recursos.GetMaiorNumero(valorA, valorB);
            valorResultado += 50;

            Console.WriteLine($"Valor A: {valorA}");
            Console.WriteLine($"Valor B: {valorB}");
            Console.WriteLine($"Valor Resutado: {valorResultado}");

            ref int valorResultadoRef = ref recursos.GetMaiorNumero(ref valorA, ref valorB);
            valorResultadoRef += 50;

            Console.WriteLine($"Valor A: {valorA}");
            Console.WriteLine($"Valor B: {valorB}");
            Console.WriteLine($"Valor Resutado: {valorResultadoRef}");

            unsafe
            {
                IntPtr valorA_EnderecoMemoria = (IntPtr)(&valorA);
                IntPtr valorB_EnderecoMemoria = (IntPtr)(&valorB);
                IntPtr valorResultado_EnderecoMemoria = (IntPtr)(&valorResultado);

                fixed (int* valorRef = &valorResultadoRef)
                {
                    IntPtr valorResultadoRef_EnderecoMemoria = (IntPtr)(&valorRef);
                    Console.WriteLine($"O endereço de memória do valor A é {valorA_EnderecoMemoria}");
                    Console.WriteLine($"O endereço de memória do valor B é {valorB_EnderecoMemoria}");
                    Console.WriteLine($"O endereço de memória do valor Resultado é {valorResultado_EnderecoMemoria}");
                    Console.WriteLine($"O endereço de memória do valor Resultado Ref é {valorResultadoRef_EnderecoMemoria}");
                }
            }
        }
    }

    public class Recursos
    {
        public int GetMaiorNumero(int valor1, int valor2)
        {
            if (valor1 > valor2)
                return valor1;
            else
                return valor2;
        }

        public ref int GetMaiorNumero(ref int valor1, ref int valor2)
        {
            if (valor1 > valor2)
                return ref valor1;
            else
                return ref valor2;
        }
    }
}
