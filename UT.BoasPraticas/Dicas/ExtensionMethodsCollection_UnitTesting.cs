using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    public class ExtensionMethodsCollection_UnitTesting
    {
        [TestMethod]
        public void Testando_ExtensionMethodsAdicionar()
        {
            var listaLutadores = new ColecaoSimples()
            {
                new Lutador() { Nome = "Anderson Silva", Idade = 43 },
                new Lutador() { Nome = "Anderson Manolo", Idade = 31 }
            };
        }
    }

    class ColecaoSimples : IEnumerable<Lutador>
    {
        List<Lutador> Lutadores = new List<Lutador>()
        {
            new Lutador() {Nome = "Rafael dos Anjos", Idade = 33},
            new Lutador() {Nome = "Fabricio Werdum", Idade = 41}
        };

        public Lutador Adicionar(Lutador lutador)
        {
            Lutadores.Add(lutador);
            return lutador;
        }

        public IEnumerator<Lutador> GetEnumerator()
        {
            return Lutadores.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Lutador
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    static class LutadoresPersistenciaExtension
    {
        public static Lutador Add(this ColecaoSimples colecao, Lutador novoLutador)
        {
            colecao.Add(novoLutador);
            return novoLutador;
        }
    }
}
