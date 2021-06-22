using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAcademy
{
    public partial class F_Calc : Form
    {
        decimal num1;
        decimal num2;
        string operacao = "";

        public F_Calc()
        {
            InitializeComponent();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 9;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 6;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 3;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + 0;
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = tbox_valor.Text + ".";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbox_valor.Text = "";
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            num2 = decimal.Parse(tbox_valor.Text, CultureInfo.InvariantCulture);

            if (operacao == "soma"){
                tbox_valor.Text = Convert.ToString(num1 + num2);
            }else if (operacao == "subtracao"){
                tbox_valor.Text = Convert.ToString(num1 - num2);
            }else if (operacao == "multiplicacao"){
                tbox_valor.Text = Convert.ToString(num1 * num2);
            }else if (operacao == "divisao"){
                tbox_valor.Text = Convert.ToString(num1 / num2);
            }else if (operacao == "percent"){
                tbox_valor.Text = Convert.ToString(num1 * (num2/100));
            }
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(tbox_valor.Text, CultureInfo.InvariantCulture);
            tbox_valor.Text = "";
            operacao = "soma";
            label1.Text = "+";
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(tbox_valor.Text, CultureInfo.InvariantCulture);
            tbox_valor.Text = "";
            operacao = "subtracao";
            label1.Text = "-";
        }

        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(tbox_valor.Text, CultureInfo.InvariantCulture);
            tbox_valor.Text = "";
            operacao = "multiplicacao";
            label1.Text = "x";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(tbox_valor.Text, CultureInfo.InvariantCulture);
            tbox_valor.Text = "";
            operacao = "divisao";
            label1.Text = "/";
        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(tbox_valor.Text, CultureInfo.InvariantCulture);
            tbox_valor.Text = Convert.ToString(num1*num1);
        }

        private void btn_porcent_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(tbox_valor.Text, CultureInfo.InvariantCulture);
            tbox_valor.Text = "";
            operacao = "percent";
            label1.Text = "/";
        }
    }
}
