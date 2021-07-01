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
    public partial class F_GridAlunosOnFormGestaoTurma : Form
    {
        F_GestãoTurmas FormGestaoTurmas;

        public F_GridAlunosOnFormGestaoTurma(F_GestãoTurmas gestaoTurmas)
        {
            InitializeComponent();

            FormGestaoTurmas = gestaoTurmas;
        }

        private void F_GridAlunosOnFormGestaoTurma_Load(object sender, EventArgs e)
        {
            gridAlunos.DataSource = Aluno.listaAlunos();

            gridAlunos.Columns[0].Width = 50;
            gridAlunos.Columns[1].Width = 200;
            gridAlunos.Columns[2].Width = 110;
            gridAlunos.Columns[3].Width = 82;
        }
        private void gridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            Aluno aluno = new Aluno();
            aluno.id_turma = Int32.Parse(FormGestaoTurmas.gridTurmas.SelectedRows[0].Cells[0].Value.ToString()); ;
            aluno.desc_turma = FormGestaoTurmas.gridTurmas.SelectedRows[0].Cells[1].Value.ToString();
            aluno.id_aluno = Int32.Parse(gridAlunos.SelectedRows[0].Cells[0].Value.ToString());
            aluno.nome_aluno = gridAlunos.SelectedRows[0].Cells[1].Value.ToString();
            Aluno.matricularAluno(aluno);
            this.Close();

            FormGestaoTurmas.gridAlunosMatriculados.Refresh();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
