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
    public partial class F_ViewProfissional : Form
    {
        public F_ViewProfissional()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.nome = tbox_nome.Text;
            professor.telefone = tbox_telefone.Text;
            professor.celular = tbox_celular.Text;
            professor.especialidade = tbox_especialidade.Text;
            professor.horario = tbox_horario.Text;
            professor.ativo = cbox_ativo.Text;
            Professor.atualizarProfessor(professor);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Alerta", MessageBoxButtons.OK);
            this.Close();
        }

        private void btn_bucarHorario_Click(object sender, EventArgs e)
        {
            F_GridHorariosOnFormViewProfessor gridHorarios = new F_GridHorariosOnFormViewProfessor(this);
            gridHorarios.ShowDialog();
        }
    }
}
