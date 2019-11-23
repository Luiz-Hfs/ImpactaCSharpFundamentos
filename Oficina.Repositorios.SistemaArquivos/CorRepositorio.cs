using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        public List<Cor> Obter()
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(@"Dados\Cor.txt"))
            {
                if (string.IsNullOrEmpty(linha))// se a linha vier nula ou vazia vai para o proximo 
                {
                    continue;
                }
                var cor = new Cor();

                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);
            }

            return cores;
        }

        public Cor Obter(int id)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines(@"Dados\Cor.txt"))
            {
                if (string.IsNullOrEmpty(linha))// se a linha vier nula ou vazia vai para o proximo 
                {
                    continue;
                }
                var linhaId = Convert.ToInt32(linha.Substring(0, 5));
                if (id == linhaId)// para fazer um "if" ctrl + k + s
                {
                    cor = new Cor();

                    cor.Id = linhaId;
                    cor.Nome = linha.Substring(5);

                    break;
                }

            }

            return (cor);
        }
    }
}
