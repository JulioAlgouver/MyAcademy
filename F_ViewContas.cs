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
    public partial class F_ViewContas : Form
    {
        public F_ViewContas()
        {
            InitializeComponent();
        }

        private void F_ViewContas_Load(object sender, EventArgs e)
        {
            gridContasCorrente.DataSource = ContaCorrente.listarContasCorrente();
            gridContasCorrente.Columns[0].Width = 216;

            DataTable dataTable = new DataTable();
            string nome = gridContasCorrente.Rows[0].Cells[0].Value.ToString();
            dataTable = ContaCorrente.obterDadosContasCorrente(nome);

            tbox_descricao.Text = dataTable.Rows[0].Field<string>("DESCRICAO").ToString();
            tbox_banco.Text = dataTable.Rows[0].Field<string>("BANCO").ToString();
            tbox_agencia.Text = dataTable.Rows[0].Field<string>("AGENCIA").ToString();
            tbox_contaCorrente.Text = dataTable.Rows[0].Field<string>("CONTA_CORRENTE").ToString();
            tbox_saldoInicial.Text = dataTable.Rows[0].Field<Double>("SALDO_INICIAL").ToString();
        }

        private void gridContasCorrente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = new DataTable();
            string nome = gridContasCorrente.SelectedRows[0].Cells[0].Value.ToString();
            dataTable = ContaCorrente.obterDadosContasCorrente(nome);

            tbox_descricao.Text = dataTable.Rows[0].Field<string>("DESCRICAO").ToString();
            tbox_banco.Text = dataTable.Rows[0].Field<string>("BANCO").ToString();
            tbox_agencia.Text = dataTable.Rows[0].Field<string>("AGENCIA").ToString();
            tbox_contaCorrente.Text = dataTable.Rows[0].Field<string>("CONTA_CORRENTE").ToString();
            tbox_saldoInicial.Text = dataTable.Rows[0].Field<Double>("SALDO_INICIAL").ToString();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.descricao = tbox_descricao.Text;
            contaCorrente.banco = tbox_banco.Text;
            contaCorrente.agencia = tbox_agencia.Text;
            contaCorrente.contaCorrente = tbox_contaCorrente.Text;
            ContaCorrente.atualizarConta(contaCorrente);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
