using System;
using System.Collections.Generic;
using System.Text;

namespace APP.AulaAtributo.Atributos
{
    [AttributeUsage(AttributeTargets.Property)]
    class EtiquetaAttribute : Attribute
    {
        public EtiquetaAttribute(string descricao, ConsoleColor cor = ConsoleColor.White)
        {
            Descricao = descricao ?? throw new ArgumentNullException();
            Cor = cor;
        }

        public string Descricao { get; set; }
        public ConsoleColor Cor { get; set; }
    }
}
