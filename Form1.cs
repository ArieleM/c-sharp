using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritmeticos
{
    public partial class frmCalculadora : Form
    {
        int numero1;
        int numero2;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            txbResultado.Text = Somar(numero1,numero2).ToString();
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            txbResultado.Text = Subtrair(numero1,numero2).ToString();

        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);

            txbResultado.Text = Multiplicar(numero1,numero2).ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txbNumero1.Text);
            double numero2 = Convert.ToDouble(txbNumero2.Text);

            txbResultado.Text = Dividir(numero1,numero2).ToString();
        }

        /*int Somar(params int[] numeros)
        {
            int resultado = 0;
            foreach (int numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }*/
        int Somar(int numero1, int numero2)
        {

            return numero1 + numero2;
        }
        int Subtrair(int numero1, int numero2)
        {

            return numero1 - numero2;
        }
        int Multiplicar(int numero1, int numero2)
        {

            return numero1 * numero2;
        }
        double Dividir(double numero1, double numero2)
        {

            return numero1 / numero2;
        }
    }
}
