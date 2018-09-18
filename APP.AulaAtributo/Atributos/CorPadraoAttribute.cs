using System;
using System.Collections.Generic;
using System.Text;

namespace APP.AulaAtributo.Atributos
{
    [AttributeUsage(AttributeTargets.Class)]
    class CorPadraoAttribute : Attribute
    {
        public ConsoleColor Cor { get; set; } = ConsoleColor.White;
    }
}
