using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string I;
        int A, R, B;
        private void BT_Limpar_Click(object sender, EventArgs e)
        {
            TB_Resultado.Text = null;
        }

        private void BT_1_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }

            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "1";
            }
        }

        private void BT_0_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "0";
            }
        }

        private void BT_2_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "2";
            }
        }

        private void BT_3_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "3";
            }
        }

        private void BT_4_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "4";
            }
        }

        private void BT_5_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "5";
            }
        }

        private void BT_6_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "6";
            }
        }

        private void BT_7_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "7";
            }
        }

        private void BT_8_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "8";
            }
        }

        private void BT_9_Click(object sender, EventArgs e)
        {
            if (TB_Resultado.Text == "0")
            {
                TB_Resultado.Text = null;
            }
            if (TB_Resultado.Text != "0")
            {
                TB_Resultado.Text = TB_Resultado.Text + "9";
            }
        }

        private void BT_Soma_Click(object sender, EventArgs e)
        {
            A = int.Parse(TB_Resultado.Text);
            TB_Resultado.Text = null;
            I = "+";
        }

        private void BT_IGUAL_Click(object sender, EventArgs e)
        {
            B = int.Parse(TB_Resultado.Text);
            if (I == "+")
            {
               R = A + B;
               TB_Resultado.Text = null;
            }
            if (I == "-")
            {
                R = A - B;
                TB_Resultado.Text = null;
            }
            if (I == "*")
            {
                R = A * B;
                TB_Resultado.Text = null;
            }
            if (I == "/")
            {
                R = A / B;
                TB_Resultado.Text = null;
            }
            TB_Resultado.Text = Convert.ToString(R);
           
        }

        private void BT_Subtracao_Click(object sender, EventArgs e)
        {
            A = int.Parse(TB_Resultado.Text);
            TB_Resultado.Text = null;
            I = "-";
        }

        private void BT_Multiplicacao_Click(object sender, EventArgs e)
        {
            A = int.Parse(TB_Resultado.Text);
            TB_Resultado.Text = null;
            I = "*";
        }

        private void BT_Divisao_Click(object sender, EventArgs e)
        {
            A = int.Parse(TB_Resultado.Text);
            TB_Resultado.Text = null;
            I = "/";
        }
    }
}
