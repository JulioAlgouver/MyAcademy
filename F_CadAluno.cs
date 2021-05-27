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
    public partial class F_CadAluno : Form
    {
        public F_CadAluno()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.nome = tbox_nome.Text;
            aluno.telefone = tbox_telefone.Text;
            aluno.celular = tbox_celular.Text;
            aluno.ativo = cbox_ativo.Text;
            aluno.possuiConvenio = cbox_possuiConvenio.Text;
            aluno.nomeConvenio = tbox_convenio.Text;

            Aluno.novoAluno(aluno);
            this.Close();
        }

        private void cbox_convenio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbox_possuiConvenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_possuiConvenio.Text == "Sim")
            {
                tbox_convenio.Enabled = true;
                tbox_convenio.ReadOnly = false;
            }
            else
            {
                tbox_convenio.ReadOnly = true;
            }
        }

        private void btn_bucarHorario_Click(object sender, EventArgs e)
        {
            F_GridConvenios gridConvenios = new F_GridConvenios();
            gridConvenios.ShowDialog();
        }
    }
}
