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
    public partial class F_GridProfessorOnFormViewTurma : Form
    {
        int idProfessorSelecionado;
        string nomeProfessorSelecionado;

        F_ViewTurma FormViewTurma;

        public F_GridProfessorOnFormViewTurma(F_ViewTurma viewTurma)
        {
            InitializeComponent();

            FormViewTurma = viewTurma;
            
        }

        private void F_GridProfessorOnFormViewTurma_Load(object sender, EventArgs e)
        {
            gridProfessores.DataSource = Professor.obterProfessores();

            gridProfessores.Columns[0].Width = 40;
            gridProfessores.Columns[1].Width = 80;
            gridProfessores.Columns[2].Width = 98;
            gridProfessores.Columns[3].Width = 98;
        }

        private void gridProfessores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;

            int contLinhas = 0;

            if (gridView.SelectedRows.Count > contLinhas)
            {
                idProfessorSelecionado = Int32.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                nomeProfessorSelecionado = gridView.SelectedRows[0].Cells[1].Value.ToString();

                DataTable dataTable = new DataTable(idProfessorSelecionado.ToString(), nomeProfessorSelecionado);

                FormViewTurma.tbox_idProfessor.Text = idProfessorSelecionado.ToString();
                FormViewTurma.tbox_professor.Text = nomeProfessorSelecionado;

                this.Close();
            }
        }
    }
}
