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
    public partial class F_GridAlunos : Form
    {
        public F_GridAlunos()
        {
            InitializeComponent();
        }

        private void F_GridAlunos_Load(object sender, EventArgs e)
        {
            gridAlunos.DataSource = Aluno.listaAlunos();

            gridAlunos.Columns[0].Width = 50;
            gridAlunos.Columns[1].Width = 200;
            gridAlunos.Columns[2].Width = 110;
            gridAlunos.Columns[3].Width = 82;
        }

        private void gridAlunos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int contLinhas = gridAlunos.Rows.Count;

            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string id = gridAlunos.SelectedRows[0].Cells[0].Value.ToString();
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

                this.Close();
            }
        }
    }
}
