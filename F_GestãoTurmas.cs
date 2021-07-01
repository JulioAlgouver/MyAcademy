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
    public partial class F_GestãoTurmas : Form
    {
        public static string idAlunoSelecionado;
        public static string idTurmaSelecionada;
        public static string nomeTurmaSelecionada;

        public F_GestãoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestãoTurmas_Load(object sender, EventArgs e)
        {
            gridTurmas.DataSource = Turma.obterIdNomeTurma();

            gridTurmas.Columns[0].Width = 79;
            gridTurmas.Columns[1].Width = 149;

            
            DataTable dataTable = new DataTable();
            string id = gridTurmas.SelectedRows[0].Cells[0].Value.ToString();
            dataTable = Aluno.listarAlunosMatriculados(id);
            
            gridAlunosMatriculados.DataSource = Aluno.listarAlunosMatriculados(id);
            gridAlunosMatriculados.Columns[0].Width = 80;
            gridAlunosMatriculados.Columns[1].Width = 166;
        }
        private void gridTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = new DataTable();
            string id = gridTurmas.SelectedRows[0].Cells[0].Value.ToString();
            dataTable = Aluno.listarAlunosMatriculados(id);

            gridAlunosMatriculados.DataSource = Aluno.listarAlunosMatriculados(id);
        }

        private void gridTurmas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = new DataTable();
            string id = gridTurmas.Rows[0].Cells[0].Value.ToString();
            dataTable = Turma.localizarTurmaAtivaPorID(id);
            
            F_ViewTurma viewTurma = new F_ViewTurma();
            viewTurma.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
            viewTurma.tbox_nomeTurma.Text = dataTable.Rows[0].Field<string>("DESC_TURMA").ToString();
            viewTurma.tbox_idProfessor.Text = dataTable.Rows[0].Field<Int64>("ID_PROFESSOR").ToString();
            viewTurma.tbox_professor.Text = dataTable.Rows[0].Field<string>("NOME_PROFESSOR").ToString();
            viewTurma.tbox_limiteAlunos.Text = dataTable.Rows[0].Field<Int64>("LIMITE_ALUNOS").ToString();
            viewTurma.tbox_idHorario.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
            viewTurma.tbox_horario.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
            viewTurma.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
            viewTurma.ShowDialog();
        }

        private void gridAlunosMatriculados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridAlunosMatriculados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = new DataTable();
            string id = gridAlunosMatriculados.Rows[0].Cells[0].Value.ToString();
            dataTable = Aluno.localizarAlunoInativoPorID(id);

            F_ViewAluno viewAluno = new F_ViewAluno();
            viewAluno.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
            viewAluno.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
            viewAluno.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
            viewAluno.cbox_possuiConvenio.Text = dataTable.Rows[0].Field<string>("POSSUI_CONVENIO").ToString();
            viewAluno.tbox_idConvenio.Text = dataTable.Rows[0].Field<Int64>("ID_CONVENIO").ToString();
            viewAluno.tbox_convenio.Text = dataTable.Rows[0].Field<string>("NOME_CONVENIO").ToString();
            viewAluno.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
            viewAluno.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
            viewAluno.ShowDialog();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(gridAlunosMatriculados.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum aluno selecionado");
            }

            Aluno.removerAluno(gridAlunosMatriculados.SelectedRows[0].Cells[0].Value.ToString(),gridTurmas.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show("Aluno removido da turma", "Aviso", MessageBoxButtons.OK);

            DataTable dataTable = new DataTable();
            string id = gridTurmas.SelectedRows[0].Cells[0].Value.ToString();
            dataTable = Aluno.listarAlunosMatriculados(id);

            gridAlunosMatriculados.DataSource = Aluno.listarAlunosMatriculados(id);
        }

        private void btn_matricular_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string id = gridTurmas.SelectedRows[0].Cells[0].Value.ToString();
            dataTable = Turma.obterLimiteAlunos(id);

            int limiteAlunos = Int32.Parse(dataTable.Rows[0].Field<Int64>("LIMITE_ALUNOS").ToString());

            if (gridAlunosMatriculados.RowCount >= limiteAlunos)
            {
                MessageBox.Show("Turma selecionada já está em seu limite de alunos","Alerta!",MessageBoxButtons.OK);
                return;
            }
            else
            {
                F_GridAlunosOnFormGestaoTurma gridAlunos = new F_GridAlunosOnFormGestaoTurma(this);
                gridAlunos.ShowDialog();
            }
        }
    }
}
