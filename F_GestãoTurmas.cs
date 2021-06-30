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
        public F_GestãoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestãoTurmas_Load(object sender, EventArgs e)
        {
            gridTurmas.DataSource = Turma.obterIdNomeTurma();

            gridTurmas.Columns[0].Width = 79;
            gridTurmas.Columns[1].Width = 149;
        }
        private void gridTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {

        }
    }
}
