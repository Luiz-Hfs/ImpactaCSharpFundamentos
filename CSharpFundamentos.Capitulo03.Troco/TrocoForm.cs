using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo03.Troco
{
    public partial class trocoForm : Form
    {
        public trocoForm()
        {
            InitializeComponent();
        }

        private void TrocoForm_Load(object sender, EventArgs e)
        {

        }

        private void moedallistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            var valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            //var x = decimal.Parse();

            decimal troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("C"); // imprimindo na tela, ja convertido
                                                     //trocoTextBox.Text = Convert.ToString(Troco);

            //Definir e atribuir o cálculo de moedas à variável
            //int moedas1Real = Convert.ToInt32(Troco);
            //var  moedas1Real = (int)(troco /1); //cast "projetar" converter um obj em outro.
            //troco = troco % 1;
            //Troco % = 1;

            //sempre colocar "m' no final do valor para identificar como Decinal
            //ToDo: refatorar para usar estrutura de repetição. view + task list

            //var moedas50 = (int)(Troco / 0.5m);
            //Troco %= 0.5m;

            //var moedas25 = (int)(Troco / 0.25m);
            //Troco %= 0.25m;

            //var moedas10 = (int)(Troco / 0.10m);
            //Troco %= 0.10m;

            //var moedas5 = (int)(Troco / 0.05m);
            //Troco %= 0.05m;

            //var moedas1 = (int)(Troco / 0.01m);
            //Troco %= 0.01m;

            //moedasListView.Items[0].Text = moedas1Real.ToString();
            //moedasListView.Items[1].Text = moedas50.ToString();
            //moedasListView.Items[2].Text = moedas25.ToString();
            //moedasListView.Items[3].Text = moedas10.ToString();
            //moedasListView.Items[4].Text = moedas5.ToString();
            //moedasListView.Items[5].Text = moedas1.ToString();

            var moedas = new decimal[] { 1, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };

            for (int i = 0; i < moedas.Length; i++)
            {
                moedasListView.Items[i].Text = ((int)(troco / moedas[i])).ToString();
                troco %= moedas[i];
            }

            //var j = 0;
            //foreach (var moeda in moedas)
            //{ 
                
            //    moedasListView.Items[j++].Text = ((int)(troco / moedas)).ToString();
            //    troco %= moeda;
            //}

        }
    }
}
