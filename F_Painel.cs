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
    public partial class F_Painel : Form
    {
        F_CadProfessor FormCadProfessor;
        F_GridHorarios FormGridHorarios;

        public F_Painel()
        {
            InitializeComponent();

            F_Login login = new F_Login(this);
            login.ShowDialog();
        }

        private void F_Painel_Load(object sender, EventArgs e)
        {
            if (Global.logado == false)
            {
                Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_codigoUsuario.Text = "--";
            lb_apelidoUsuario.Text = "--";
            pbox_led.Image = Properties.Resources.led_red_off;
            Global.logado = false;
            Close();
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            if (Global.logado == true)
            {
                if (Global.permite_acesso_conf_database == "Sim")
                {
                    F_Database database = new F_Database();
                    database.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não possui permissão de acesso", "Acesso Negado.", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Login obrigatório!");
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            if (Global.logado == true)
            {
                if (Global.permite_acesso_configuracao == "Sim")
                {
                    F_Configuracao configuracao = new F_Configuracao();
                    configuracao.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não possui permissão de acesso", "Acesso Negado.", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Login obrigatório!");
            }
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            if (Global.logado == true)
            {
                if (Global.permite_acesso_financeiro == "Sim")
                {
                    F_Financeiro financeiro = new F_Financeiro();
                    financeiro.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não possui permissão de acesso", "Acesso Negado.", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Login obrigatório!");
            }
        }

        private void btn_gestao_Click(object sender, EventArgs e)
        {
            if (Global.logado == true)
            {
                if (Global.permite_acesso_gestao == "Sim")
                {
                    F_Gestao gestao = new F_Gestao(FormGridHorarios,FormCadProfessor);
                    gestao.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não possui permissão de acesso", "Acesso Negado.", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Login obrigatório!");
            }
        }
    }
}
