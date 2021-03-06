using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAcademy
{
    public partial class F_NovaConta : Form
    {
        double valorInicial = 0;
        double valorJuros = 0;
        double valorDesconto = 0;
        double valorFinal;

        public F_NovaConta()
        {
            InitializeComponent();

            valorInicial = 0.00;
            valorJuros = 0.00;
            valorDesconto = 0.00;
            valorFinal = valorInicial + valorJuros - valorDesconto;

            tbox_valor.Text = valorInicial.ToString();
            tbox_juros.Text = valorJuros.ToString();
            tbox_desconto.Text = valorDesconto.ToString();
            tbox_valorFinal.Text = valorFinal.ToString(); 
        }

        public void calculaValorFinal()
        {
            valorInicial = Double.Parse(tbox_valor.Text);
            valorJuros = Double.Parse(tbox_juros.Text);
            valorDesconto = Double.Parse(tbox_desconto.Text);

            valorFinal = valorInicial + valorJuros - valorDesconto;
        }

        private void tbox_valor_TextChanged(object sender, EventArgs e)
        {
            valorInicial = Double.Parse(tbox_valor.Text);
            calculaValorFinal();
        }
    }
}
