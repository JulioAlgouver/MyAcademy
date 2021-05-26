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
    public partial class F_Login : Form
    {
        F_Painel painel;
        DataTable dataTable = new DataTable();

        public F_Login(F_Painel form)
        {
            InitializeComponent();
            painel = form;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tbox_usuario.Text;
            string password = tbox_senha.Text;

            if (username == "" | password == "")
            {
                MessageBox.Show("Favor preencher todos os campos obrigatórios");
                return;
            }

            string SQL = "SELECT * FROM USUARIOS WHERE APELIDO ='"+username+"' AND SENHA ='"+password+"'";
            dataTable = Usuario.consulta(SQL);

            if(dataTable.Rows.Count == 1)
            {
                painel.lb_codigoUsuario.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                painel.lb_apelidoUsuario.Text = dataTable.Rows[0].Field<string>("APELIDO");         
                painel.pbox_led.Image = Properties.Resources.led_green_on;
                Global.permite_acesso_gestao = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_GESTAO");
                Global.permite_acesso_financeiro = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_FINANCEIRO");
                Global.permite_acesso_configuracao = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONFIGURACAO");
                Global.permite_acesso_conf_database = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONF_DATABASE");
                Global.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique suas credenciais e tente novamente.","Usuário ou senha inválidos!");
            }
            
        }
    }
}
