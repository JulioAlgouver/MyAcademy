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
    public partial class F_GridConvenios : Form
    {
        F_CadAluno FormCadAluno;

        public static int idConvenioSelecionado;
        public static string nomeConvenioSelecionado;

        public F_GridConvenios(string tbox_convenio, string tbox_idConvenio, F_CadAluno cadAluno)
        {
            InitializeComponent();

            FormCadAluno = cadAluno;
        }

        public static void obterIdNomeConvenioSelecionado(string tbox_convenio, string tbox_idConvenio, F_CadAluno cadAluno)
        {
            cadAluno.tbox_idConvenio.Text = idConvenioSelecionado.ToString();
            cadAluno.tbox_convenio.Text = nomeConvenioSelecionado;
        }

        private void F_GridConvenios_Load(object sender, EventArgs e)
        {
            gridConvenios.DataSource = Convenio.listaConvenios();

            gridConvenios.Columns[0].Width = 80;
            gridConvenios.Columns[1].Width = 120;
            gridConvenios.Columns[2].Width = 108;
            gridConvenios.Columns[3].Width = 50;
        }

        public void gridConvenios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int contLinhas = gridConvenios.Rows.Count;

            if(contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                idConvenioSelecionado = Int32.Parse(gridConvenios.SelectedRows[0].Cells[0].Value.ToString());
                nomeConvenioSelecionado = gridConvenios.SelectedRows[0].Cells[1].Value.ToString();
                dataTable = new DataTable(idConvenioSelecionado.ToString(),nomeConvenioSelecionado);

                FormCadAluno.tbox_idConvenio.Text = idConvenioSelecionado.ToString();
                FormCadAluno.tbox_convenio.Text = nomeConvenioSelecionado;

                this.Close();
            }
        }
    }
}
