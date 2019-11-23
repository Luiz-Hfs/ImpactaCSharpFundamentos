using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class MarcaRepositorio//public todos a soluçaõ pode ver | "private" ou internal que não é visivel por todos 
    {
        private string caminhaArquivo = ConfigurationManager.AppSettings["caminhoArquivoMarca"]; //a classe ConfigurationManager para ler o arquivo de app.config / usar a biblioteca using System.Configuration;

        public List<Marca> Obter()
        {
            var marcas = new List<Marca>();

            foreach (var linha in File.ReadAllLines(caminhaArquivo))
            {
                if (string.IsNullOrEmpty(linha))// se a linha vier nula ou vazia vai para o proximo 
                {
                    continue;
                }

                var propriedades = linha.Split('|');// Split retorna vetor e como paranetro solicita um separador   
                var marca = new Marca();

                marca.Id = Convert.ToInt32(propriedades[0]);
                marca.Nome = propriedades[1];

                marcas.Add(marca);
            }

            return marcas;
        }

        public Marca Obter(int id)
        {
            Marca marca = null;

            foreach (var linha in File.ReadAllLines(caminhaArquivo))
            {
                if (string.IsNullOrEmpty(linha))// se a linha vier nula ou vazia vai para o proximo 
                {
                    continue;
                }
                var propriedades = linha.Split('|');
                var linhaId = Convert.ToInt32(propriedades[0]);

                if(id == linhaId)
                {
                    marca = new Marca();

                    marca.Id = linhaId;
                    marca.Nome = propriedades[1];

                    break;
                }
            }

            return (marca);
        }
    }
}
