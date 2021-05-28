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
    public partial class F_CadConvenio : Form
    {
        public F_CadConvenio()
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

            convenio.nome = tbox_nome.Text;
            convenio.perc_desconto = System.Convert.ToDouble(tbox_desconto.Text);
            convenio.ativo = cbox_ativo.Text; 

            Convenio.novoConvenio(convenio);
            this.Close();
        }
    }
}
