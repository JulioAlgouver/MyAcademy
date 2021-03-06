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
    public partial class F_ViewTurma : Form
    {
        public F_ViewTurma()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscarProfessor_Click(object sender, EventArgs e)
        {
            F_GridProfessorOnFormViewTurma gridProfessores = new F_GridProfessorOnFormViewTurma(this);
            gridProfessores.ShowDialog();
        }

        private void btn_bucarHorario_Click(object sender, EventArgs e)
        {
            F_GridHorariosOnFormViewTurma gridHorarios = new F_GridHorariosOnFormViewTurma(this);
            gridHorarios.ShowDialog();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            turma.desc_turma = tbox_nomeTurma.Text;
            turma.id_horario = Int32.Parse(tbox_idHorario.Text);
            turma.desc_horario = tbox_horario.Text;
            turma.id_professor = Int32.Parse(tbox_idProfessor.Text);
            turma.nome_professor = tbox_professor.Text;
            turma.limite_alunos = Int32.Parse(tbox_limiteAlunos.Text);
            turma.ativo = cbox_ativo.Text;
            Turma.atualizarTurma(turma);

            this.Close();
        }
    }
}
