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
    public partial class F_ViewConvenio : Form
    {
        public F_ViewConvenio()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Convenio convenio = new Convenio();
            convenio.codigo = Int32.Parse(tbox_codigo.Text);
            convenio.nome = tbox_nome.Text;
            convenio.perc_desconto = Int32.Parse(tbox_desconto.Text);
            convenio.ativo = cbox_ativo.Text;
            Convenio.atualizarConvenio(convenio);

            MessageBox.Show("Cadastro atualizado com sucesso!");
            this.Close();
        }
    }
}
