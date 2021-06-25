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
    public partial class F_GridHorarioOnFormBusca : Form
    {
        public F_GridHorarioOnFormBusca()
        {
            InitializeComponent();
        }

        private void F_GridHorarioOnFormBusca_Load(object sender, EventArgs e)
        {
            gridHorarios.DataSource = Horario.obterHorarios();

            gridHorarios.Columns[0].Width = 50;
            gridHorarios.Columns[1].Width = 200;
            gridHorarios.Columns[2].Width = 110;
            gridHorarios.Columns[3].Width = 82;
        }

        private void gridHorarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int contLinhas = gridHorarios.Rows.Count;

            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string id = gridHorarios.SelectedRows[0].Cells[0].Value.ToString();
                dataTable = Horario.localizarHorarioInativoPorID(id);

                F_ViewHorario viewHorario = new F_ViewHorario();

                viewHorario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                viewHorario.tbox_descricao.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                viewHorario.tbox_horaInicio.Text = dataTable.Rows[0].Field<string>("HORA_INICIO").ToString();
                viewHorario.tbox_horaFim.Text = dataTable.Rows[0].Field<string>("HORA_FIM").ToString();
                viewHorario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                viewHorario.ShowDialog();

                this.Close();
            }
        }
    }
}
