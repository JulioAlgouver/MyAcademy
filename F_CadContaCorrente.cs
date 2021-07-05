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
    public partial class F_CadContaCorrente : Form
    {
        public F_CadContaCorrente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.descricao = tbox_descricao.Text;
            contaCorrente.banco = tbox_banco.Text;
            contaCorrente.agencia = Int32.Parse(tbox_agencia.Text);
            contaCorrente.contaCorrente = Int32.Parse(tbox_contaCorrente.Text);
            contaCorrente.saldoInicial = Int32.Parse(tbox_saldoInicial.Text);
            ContaCorrente.novaConta(contaCorrente);
            this.Close();
        }

        private void F_CadContaCorrente_Load(object sender, EventArgs e)
        {
            tbox_saldoInicial.Text = "0,00";
        }
    }
}
