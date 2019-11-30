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
    public class VeiculoRepositorio : RepositorioBase
    {
       // private static string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoVeiculo"];
        private XDocument arquivoXml; //a classe ConfigurationManager para ler o arquivo de app.config / usar a biblioteca using System.Configuration;

        public VeiculoRepositorio() : base("caminhoArquivoVeiculo")
        {
            arquivoXml = XDocument.Load(CaminhoArquivo);
        }

        public void inserir<T>(T veiculo) where  T: Veiculo
        {
            var registro = new StringWriter();
            var serializador = new XmlSerializer(typeof(T));

            serializador.Serialize(registro, veiculo);

            arquivoXml.Root.Add(XElement.Parse(registro.ToString())); //Parse analizar registros 
            arquivoXml.Save(CaminhoArquivo);
        }
    }
}
