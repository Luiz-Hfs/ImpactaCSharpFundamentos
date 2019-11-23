using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentos.Capitulo08.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>(/*1000*/) { 1, 8, 33, 16, -78 };
            //inteiros[0] = 16;
            inteiros.Add(27);
            inteiros.Add(-8);

            var maisInteiros = new List<int> {16,38,-7,8};

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(2, 42);

            inteiros.Remove(42); //renove apenas a primeira ocorrência do item.
            inteiros.RemoveAll(inteiro => inteiro == 16);// lãmbda expression
            inteiros.RemoveAt(5);//renover uma posição do vetor 
            inteiros.Sort();

            var primeiro = inteiros[0];
            primeiro = inteiros.First();// achar o primeiro valor

            var ultimo = inteiros[inteiros.Count - 1];
            ultimo = inteiros.Last();// achar o ultimo numero do vetor

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro}");// indexOF acha o valor para mim
            }
        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2019, 11, 15),"Proclamação da República");//chave tem que ser sempre unica 
            feriados.Add(Convert.ToDateTime("20/11/2019"), "Consciência negra");
            feriados.Add(Convert.ToDateTime("25/01/2020"),"Aniversário de são paulo");

            var proclamacao = feriados[new DateTime(2019, 11, 15)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToShortDateString()}: {feriado.Value}");//String interpolada "$"
            }

            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("20/11/2019")));//ContainsKey Bool
            Console.WriteLine(feriados.ContainsValue("Proclamação da República"));
        }
    }
}
