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
    public partial class F_GridProfessoresOnFormBusca : Form
    {
        public F_GridProfessoresOnFormBusca()
        {
            InitializeComponent();
        }

        private void F_GridProfessoresOnFormBusca_Load(object sender, EventArgs e)
        {
            gridProfessores.DataSource = Professor.obterProfessores();

            gridProfessores.Columns[0].Width = 40;
            gridProfessores.Columns[1].Width = 80;
            gridProfessores.Columns[2].Width = 98;
            gridProfessores.Columns[3].Width = 98;
        }

        private void gridProfessores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = new DataTable();
            string id = gridProfessores.SelectedRows[0].Cells[0].Value.ToString();
            dataTable = Professor.localizarProfessorInativoPorID(id);

            F_ViewProfissional viewProfissional = new F_ViewProfissional();

            viewProfissional.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
            viewProfissional.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
            viewProfissional.tbox_especialidade.Text = dataTable.Rows[0].Field<string>("ESPECIALIDADE").ToString();
            viewProfissional.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
            viewProfissional.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
            viewProfissional.tbox_horario.Text = dataTable.Rows[0].Field<string>("HORARIO").ToString();
            viewProfissional.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
            viewProfissional.ShowDialog();

            this.Close();
        }
    }
}
