using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class VeiculoRepositorio
    {
        private static string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoVeiculo"];
        private XDocument arquivoXml = XDocument.Load(caminhoArquivo); //a classe ConfigurationManager para ler o arquivo de app.config / usar a biblioteca using System.Configuration;

        public void inserir(Veiculo veiculo)
        {
            var registro = new StringWriter();
            var serializador = new XmlSerializer(typeof(Veiculo));//

            serializador.Serialize(registro, veiculo);

            arquivoXml.Root.Add(XElement.Parse(registro.ToString())); //Parse analizar registros 
            arquivoXml.Save(caminhoArquivo);
        }
    }
}
