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
    public partial class F_CadProfessor : Form
    {
        public F_CadProfessor()
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
            professor.especialidade = tbox_especialidade.Text;
            professor.celular = tbox_celular.Text;
            professor.telefone = tbox_telefone.Text;
            professor.horario = tbox_horario.Text;
            professor.ativo = cbox_ativo.Text;
            Professor.novoProfessor(professor);

            this.Close();
        }

        private void btn_bucarHorario_Click(object sender, EventArgs e)
        {
            F_GridHorarios gridHorarios = new F_GridHorarios();
            gridHorarios.ShowDialog();
        }
    }
}
