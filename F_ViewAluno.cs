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
    public partial class F_ViewAluno : Form
    {
        public F_ViewAluno()
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
            aluno.codigo = Int32.Parse(tbox_codigo.Text);
            aluno.nome = tbox_nome.Text;
            aluno.telefone = tbox_telefone.Text;
            aluno.celular = tbox_celular.Text;
            aluno.ativo = cbox_ativo.Text;
            aluno.possuiConvenio = cbox_possuiConvenio.Text;
            aluno.idConvenio = Int32.Parse(tbox_idConvenio.Text);
            aluno.nomeConvenio = tbox_convenio.Text;

            Aluno.atualizarAluno(aluno);

            MessageBox.Show("Cadastro atualizado com sucesso!");
            this.Close();
        }
    }
}
