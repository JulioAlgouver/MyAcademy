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
    public partial class F_CadPlanoContas : Form
    {
        string tipoConta;

        F_PlanoContas FormPlanoContas;

        public F_CadPlanoContas(F_PlanoContas F_planoContas)
        {
            InitializeComponent();

            FormPlanoContas = F_planoContas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radio_receita.Checked == true)
            {
                tipoConta = "+";
            }
            else if (radio_despesa.Checked == true)
            {
                tipoConta = "-";
            } 
            else if (radio_grupo.Checked == true)
            {
                tipoConta = "";
            }
            else
            {
                MessageBox.Show("Nenhum tipo selecionado","Alerta",MessageBoxButtons.OK);
            }

            PlanoContas planoContas = new PlanoContas();
            planoContas.codigo = tbox_codigo.Text;
            planoContas.descricao = tbox_descricao.Text;
            planoContas.tipoConta = tipoConta;
            planoContas.ativo = "Sim";
            planoContas.codigoRaiz = FormPlanoContas.viewPlanoContas.SelectedNode.Name.ToString();
            PlanoContas.novoItem(planoContas);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
