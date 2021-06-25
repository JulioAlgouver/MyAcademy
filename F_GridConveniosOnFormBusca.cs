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
    public partial class F_GridConveniosOnFormBusca : Form
    {
        public F_GridConveniosOnFormBusca()
        {
            InitializeComponent();
        }

        private void F_GridConveniosOnFormBusca_Load(object sender, EventArgs e)
        {
            gridConvenios.DataSource = Convenio.listaConvenios();

            gridConvenios.Columns[0].Width = 80;
            gridConvenios.Columns[1].Width = 120;
            gridConvenios.Columns[2].Width = 108;
            gridConvenios.Columns[3].Width = 50;
        }

        private void gridConvenios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = new DataTable();
            string id = gridConvenios.SelectedRows[0].Cells[0].Value.ToString();
            dataTable = Convenio.localizaConvenioAtivoPorID(id);

            F_ViewConvenio viewConvenio = new F_ViewConvenio();

            viewConvenio.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
            viewConvenio.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
            viewConvenio.tbox_desconto.Text = dataTable.Rows[0].Field<Double>("PERC_DESCONTO").ToString();
            viewConvenio.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
            viewConvenio.ShowDialog();
            this.Close();
        }
    }
}
