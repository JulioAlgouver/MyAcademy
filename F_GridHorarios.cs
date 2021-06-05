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
    public partial class F_GridHorarios : Form
    {
        F_CadProfessor FormCadProfesor;

        public static int idHorarioSelecionado;
        public static string descricaoHorarioSelecionado;

        public F_GridHorarios(F_CadProfessor cadProfessor)
        {
            InitializeComponent();

            FormCadProfesor = cadProfessor;
        }

        private void F_GridHorarios_Load(object sender, EventArgs e)
        {
            gridHorarios.DataSource = Horario.obterHorarios();

            gridHorarios.Columns[0].Width = 40;
            gridHorarios.Columns[1].Width = 80;
            gridHorarios.Columns[2].Width = 98;
            gridHorarios.Columns[3].Width = 98;
        }

        private void gridHorarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;

            int contLinhas = 0;

            if(gridView.SelectedRows.Count > contLinhas)
            {
                idHorarioSelecionado = Int32.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                descricaoHorarioSelecionado = gridView.SelectedRows[0].Cells[1].Value.ToString();

                DataTable dataTable = new DataTable(idHorarioSelecionado.ToString(), descricaoHorarioSelecionado);

                FormCadProfesor.tbox_idHorario.Text = idHorarioSelecionado.ToString();
                FormCadProfesor.tbox_horario.Text = descricaoHorarioSelecionado;
                
                this.Close();
            }
        }
    }
}