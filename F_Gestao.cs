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
    public partial class F_Gestao : Form
    {
        public F_Gestao()
        {
            InitializeComponent();
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CadUsuario cadUsuario = new F_CadUsuario();
            cadUsuario.ShowDialog();
        }

        private void consultarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_BuscaUsuario buscaUsuario = new F_BuscaUsuario();
            buscaUsuario.ShowDialog();
        }
    }
}
