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
        public F_GridHorarios()
        {
            InitializeComponent();
        }

        private void F_GridHorarios_Load(object sender, EventArgs e)
        {
            gridHorarios.DataSource = Horario.obterHorarios();

            gridHorarios.Columns[0].Width = 40;
            gridHorarios.Columns[1].Width = 80;
            gridHorarios.Columns[2].Width = 98;
            gridHorarios.Columns[3].Width = 98;
        }
    }
}
