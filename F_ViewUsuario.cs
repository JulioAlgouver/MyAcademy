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
    public partial class F_ViewUsuario : Form
    {
        public F_ViewUsuario()
        {
            InitializeComponent();
        }

        private void F_ViewUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.codigo = Int32.Parse(tbox_codigo.Text);
            usuario.nome = tbox_nome.Text;
            usuario.senha = tbox_senha.Text;
            usuario.apelido = tbox_apelido.Text;
            usuario.ativo = cbox_ativo.Text;
            usuario.permiteAcessoGestao = cbox_acessoGestao.Text;
            usuario.permiteAcessoFinanceiro = cbox_financeiro.Text;
            usuario.pemiteAcessoConfiguracao = cbox_configuracoes.Text;
            usuario.permiteAcessoDatabase = cbox_database.Text;

            Usuario.atualizarUsuario(usuario);

            MessageBox.Show("Cadastro atualizado com sucesso!");
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
