using System;
using System.Collections.Generic;
using System.Text;

namespace APP.AulaAtributo.Atributos
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class IndentarAttribute : Attribute
    {
    }
}
