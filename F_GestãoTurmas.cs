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
    public partial class F_GestãoTurmas : Form
    {
        public F_GestãoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestãoTurmas_Load(object sender, EventArgs e)
        {
            gridTurmas.DataSource = Turma.obterIdNomeTurma();

            gridTurmas.Columns[0].Width = 30;
            gridTurmas.Columns[1].Width = 100;
        }

        private void gridTurmas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridAlunosMatriculados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridAlunosMatriculados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {

        }
    }
}
