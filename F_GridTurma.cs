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
    public partial class F_GridTurma : Form
    {
        public F_GridTurma()
        {
            InitializeComponent();
        }

        private void F_GridTurma_Load(object sender, EventArgs e)
        {
            gridTurma.DataSource = Turma.obterTurmas();

            gridTurma.Columns[0].Width = 40;
            gridTurma.Columns[1].Width = 80;
            gridTurma.Columns[2].Width = 98;
            gridTurma.Columns[3].Width = 98;
        }

        private void gridTurma_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = new DataTable();
            string id = gridTurma.SelectedRows[0].Cells[0].Value.ToString();
            dataTable = Turma.localizarTurmaInativaPorID(id);

            F_ViewTurma viewTurma = new F_ViewTurma();

            viewTurma.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
            viewTurma.tbox_nomeTurma.Text = dataTable.Rows[0].Field<string>("DESC_TURMA").ToString();
            viewTurma.tbox_idProfessor.Text = dataTable.Rows[0].Field<Int64>("ID_PROFESSOR").ToString();
            viewTurma.tbox_professor.Text = dataTable.Rows[0].Field<string>("NOME_PROFESSOR").ToString();
            viewTurma.tbox_idHorario.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
            viewTurma.tbox_horario.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
            viewTurma.tbox_limiteAlunos.Text = dataTable.Rows[0].Field<Int64>("LIMITE_ALUNOS").ToString();
            viewTurma.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
            viewTurma.ShowDialog();

            this.Close();
        }
    }
}
