using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        CorRepositorio corRepositorio = new CorRepositorio();

        [TestMethod()]
        public void ObterTest()
        {
            var cores = corRepositorio.Obter();

            foreach (var cor in cores)
            {
                Console.WriteLine($"{cor.Id} - {cor.Nome}");
            }
        }

        [TestMethod()]
        public void ObterPorIdTest()
        {
            var cor = corRepositorio.Obter(3);

            Assert.AreEqual(cor.Nome, "Branco");// Assert é um teste = afirmação,negado         

            cor = corRepositorio.Obter(0);
            Assert.IsNull(cor);//verificar de tem um valor nulo InNull

        }
    }
}