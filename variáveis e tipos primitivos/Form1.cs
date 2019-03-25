using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variáveis_e_tipos_primitivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int idadeMae = 40;
            int idadePai = 41;
            int idadePaulo = 21;
            double media = (idadeMae + idadePai + idadePaulo) / 3;
            MessageBox.Show("a média das idades é:" + media);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int pi = 3.14; //não compila pois o número é decimal e não cabe num inteiro

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado); // piQuebrado=3; o (int) "forçou" a conversão do double para um inteiro. Mesmo exemplo que ele deu sobre no uso do short.Esa operação é chamada de casting

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 5;
            int c = 6;
            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);
            double a1 = (-b + raiz) / (2 * a);
            double a2 = (-b - raiz) / (2 * a);
            MessageBox.Show("o valor da primeira raíz é: " + a1 + "  e o valor da segunda raíz é:" + a2);
        }
    }
}
