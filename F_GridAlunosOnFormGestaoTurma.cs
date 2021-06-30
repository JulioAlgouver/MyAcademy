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
    public partial class F_GridAlunosOnFormGestaoTurma : Form
    {
        public F_GridAlunosOnFormGestaoTurma()
        {
            InitializeComponent();
        }

        private void F_GridAlunosOnFormGestaoTurma_Load(object sender, EventArgs e)
        {
            gridAlunos.DataSource = Aluno.listaAlunos();

            gridAlunos.Columns[0].Width = 50;
            gridAlunos.Columns[1].Width = 200;
            gridAlunos.Columns[2].Width = 110;
            gridAlunos.Columns[3].Width = 82;
        }
    }
}
