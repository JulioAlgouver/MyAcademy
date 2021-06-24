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
    public partial class F_GridProfessores : Form
    {
        int idProfessorSelecionado;
        string nomeProfessorSelecionado;

        F_CadTurma FormCadTurma;

        public F_GridProfessores(F_CadTurma cadTurma)
        {
            InitializeComponent();

            FormCadTurma = cadTurma;
        }

        private void F_GridProfessores_Load(object sender, EventArgs e)
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

            if(gridView.SelectedRows.Count > contLinhas)
            {
                idProfessorSelecionado = Int32.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                nomeProfessorSelecionado = gridView.SelectedRows[0].Cells[1].Value.ToString();

                DataTable dataTable = new DataTable(idProfessorSelecionado.ToString(), nomeProfessorSelecionado);

                FormCadTurma.tbox_idProfessor.Text = idProfessorSelecionado.ToString();
                FormCadTurma.tbox_professor.Text = nomeProfessorSelecionado;

                this.Close();
            }
        }
    }
}
