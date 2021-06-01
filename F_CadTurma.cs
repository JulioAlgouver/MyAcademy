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
    public partial class F_CadTurma : Form
    {
        F_CadProfessor FormCadProfesor;
        F_GridHorarios FormGridHorarios;

        public F_CadTurma(F_GridHorarios gridHorarios, F_CadProfessor cadProfessor)
        {
            InitializeComponent();

            FormGridHorarios = gridHorarios;
            FormCadProfesor = cadProfessor;
        }

        private void btn_bucarHorario_Click(object sender, EventArgs e)
        {
            F_GridHorarios gridHorarios = new F_GridHorarios(FormCadProfesor);
            gridHorarios.ShowDialog();
        }

        private void btn_buscarProfessor_Click(object sender, EventArgs e)
        {
            F_GridProfessores gridProfessores = new F_GridProfessores();
            gridProfessores.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
