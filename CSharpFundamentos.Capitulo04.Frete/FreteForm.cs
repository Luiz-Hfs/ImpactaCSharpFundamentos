using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo04.Frete
{
    public partial class freteForm : Form
    {
        public freteForm()
        {
            InitializeComponent();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            clienteTextBox.Text = "";
            valorTextBox.Clear();
            ufComboBox.SelectedIndex = -1;
            freteTextBox.Text = String.Empty;
            totalTextBox.Text = null;
        }

       

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(String.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);//Join pega uma list e tranforma em um determinado valor
                                          //Environment.NewLine - separador 

            }
        }

        private void Calcular()
        {
            var percentualFrete = 0M;
            var valor = Convert.ToDecimal(valorTextBox.Text);
            switch (ufComboBox.Text.ToUpper()) //ToUpper pela uma string e deixa em maiusculo
            {
                case "SP":
                    percentualFrete = 0.2M;
                    break;
                case "RJ":
                    percentualFrete = 0.3M;
                    break;
                case "MG":
                    percentualFrete = 0.35M;
                    break;
                case "AM":
                    percentualFrete = 0.6M;
                    break;


                default:
                    percentualFrete = 0.7M;
                    break;
            }

        //    if (ufComboBox.Text.ToUpper() == "SP")
        //    {
        //        percentualFrete = 0.2m;
        //    }
        //    else if (ufComboBox.Text.ToUpper() == "RJ" || ufComboBox.Text.ToUpper() == "MG")
        //    {
        //        percentualFrete = 0.3m;
        //    }
        //    else
        //    {
        //        percentualFrete = 0.7m;
        //    }
            freteTextBox.Text = percentualFrete.ToString("P2");
            totalTextBox.Text = ((1 + percentualFrete) * valor).ToString("c");
        }

        private List<String> ValidarFormulario() // primeira linha do metodo é a assinatura do metodo!
        {
            var erros = new List<String>();

            //if (clienteTextBox.Text == "")
            if (clienteTextBox.Text == string.Empty)
            {
                erros.Add("O campo cliente é obrigatorio!");
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione uma UF!");
            }

            if (string.IsNullOrEmpty(valorTextBox.Text))
            {
                erros.Add(" O campo valor é ogrigatorio");
            }

            else
            {
                decimal valorConvertido;

                if (!decimal.TryParse(valorTextBox.Text, out valorConvertido))//TryParte para converção, verdadeiro ou falso
                {
                    erros.Add("O campo valor deve ser numérico");
                }
            }
            return erros;
        }
    }
}
