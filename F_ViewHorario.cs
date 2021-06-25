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
    public partial class F_ViewHorario : Form
    {
        public F_ViewHorario()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.id_horario = Int32.Parse(tbox_codigo.Text);
            horario.desc_horario = tbox_descricao.Text;
            horario.hora_inicio = tbox_horaInicio.Text;
            horario.hora_fim = tbox_horaFim.Text;
            horario.ativo = cbox_ativo.Text;
            Horario.atualizarHorario(horario);

            this.Close();
        }
    }
}
