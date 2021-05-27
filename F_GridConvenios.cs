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
        public F_GridConvenios()
        {
            InitializeComponent();
        }

        private void F_GridConvenios_Load(object sender, EventArgs e)
        {
            gridConvenios.DataSource = Convenio.listaConvenios();

            gridConvenios.Columns[0].Width = 80;
            gridConvenios.Columns[1].Width = 120;
            gridConvenios.Columns[2].Width = 108;
            gridConvenios.Columns[3].Width = 50;
        }

        private void gridConvenios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
