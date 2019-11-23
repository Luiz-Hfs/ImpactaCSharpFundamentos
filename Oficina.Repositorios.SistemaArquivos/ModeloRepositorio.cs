using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio
    {
        private  XDocument arquivoXml = XDocument.Load(ConfigurationManager.AppSettings["caminhoArquivoModelo"]); //a classe ConfigurationManager para ler o arquivo de app.config / usar a biblioteca using System.Configuration;
        //o comando XDocument para manipular arquivos XML // Load serve para carregar arquivos em XML

        public List<Modelo> ObterPorMarca(int marcaId)//primeira linha de um metodo é chamado de assinatura do metodo
        {
            var modelos = new List<Modelo>();

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if (marcaId.ToString() == elemento.Element("marcaId").Value)
                {
                    var modelo = new Modelo();//instanciando uma classe
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;

                    var marcaRepositorio = new MarcaRepositorio();
                    modelo.Marca = marcaRepositorio.Obter(marcaId);

                    modelos.Add(modelo);
                }
            }

            return modelos;
        }

        public Modelo Obter(int id)
        {
            Modelo modelo = null;

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if (id.ToString() == elemento.Element("id").Value)
                {
                    modelo = new Modelo();//instanciando uma classe
                    modelo.Id = id;
                    modelo.Nome = elemento.Element("nome").Value;

                    var marcaRepositorio = new MarcaRepositorio();
                    modelo.Marca = marcaRepositorio.Obter(Convert.ToInt32(elemento.Element("marcaId").Value));
                    break;
                }
            }

            return modelo;
        }
       
    }
}
