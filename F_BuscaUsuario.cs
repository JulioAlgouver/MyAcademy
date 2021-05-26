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
    public partial class F_BuscaUsuario : Form
    {
        public F_BuscaUsuario()
        {
            InitializeComponent();
        }

        //BUSCA POR CÓDIGO

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbox_codigo.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridUsuarios gridUsuarios = new F_GridUsuarios();
                    gridUsuarios.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if(checkBox1.Checked == true) 
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string id = tbox_codigo.Text;
                        dataTable = Usuario.obterDadosUsuario(id);

                        F_ViewUsuario viewUsuario = new F_ViewUsuario();

                        viewUsuario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewUsuario.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME");
                        viewUsuario.tbox_apelido.Text = dataTable.Rows[0].Field<string>("APELIDO");
                        viewUsuario.tbox_senha.Text = dataTable.Rows[0].Field<string>("SENHA");
                        viewUsuario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO");
                        viewUsuario.cbox_acessoGestao.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_GESTAO");
                        viewUsuario.cbox_financeiro.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_FINANCEIRO");
                        viewUsuario.cbox_configuracoes.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONFIGURACAO");
                        viewUsuario.cbox_database.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONF_DATABASE");

                        viewUsuario.ShowDialog();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum usuário encontrado","Aviso",MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
                else
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string id = tbox_codigo.Text;
                        dataTable = Usuario.obterDadosUsuarioCodigoAtivo(id);

                        F_ViewUsuario viewUsuario = new F_ViewUsuario();

                        viewUsuario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewUsuario.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME");
                        viewUsuario.tbox_apelido.Text = dataTable.Rows[0].Field<string>("APELIDO");
                        viewUsuario.tbox_senha.Text = dataTable.Rows[0].Field<string>("SENHA");
                        viewUsuario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO");
                        viewUsuario.cbox_acessoGestao.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_GESTAO");
                        viewUsuario.cbox_financeiro.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_FINANCEIRO");
                        viewUsuario.cbox_configuracoes.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONFIGURACAO");
                        viewUsuario.cbox_database.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONF_DATABASE");

                        viewUsuario.ShowDialog();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum usuário encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }

        //BUSCA POR NOME

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbox_nome.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridUsuarios gridUsuarios = new F_GridUsuarios();
                    gridUsuarios.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string nome = tbox_nome.Text;
                        dataTable = Usuario.obterDadosUsuarioNomeInativo(nome);

                        F_ViewUsuario viewUsuario = new F_ViewUsuario();

                        viewUsuario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewUsuario.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME");
                        viewUsuario.tbox_apelido.Text = dataTable.Rows[0].Field<string>("APELIDO");
                        viewUsuario.tbox_senha.Text = dataTable.Rows[0].Field<string>("SENHA");
                        viewUsuario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO");
                        viewUsuario.cbox_acessoGestao.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_GESTAO");
                        viewUsuario.cbox_financeiro.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_FINANCEIRO");
                        viewUsuario.cbox_configuracoes.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONFIGURACAO");
                        viewUsuario.cbox_database.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONF_DATABASE");

                        viewUsuario.ShowDialog();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum usuário encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
                else
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string nome = tbox_nome.Text;
                        dataTable = Usuario.obterDadosUsuarioNomeAtivo(nome);

                        F_ViewUsuario viewUsuario = new F_ViewUsuario();

                        viewUsuario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewUsuario.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME");
                        viewUsuario.tbox_apelido.Text = dataTable.Rows[0].Field<string>("APELIDO");
                        viewUsuario.tbox_senha.Text = dataTable.Rows[0].Field<string>("SENHA");
                        viewUsuario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO");
                        viewUsuario.cbox_acessoGestao.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_GESTAO");
                        viewUsuario.cbox_financeiro.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_FINANCEIRO");
                        viewUsuario.cbox_configuracoes.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONFIGURACAO");
                        viewUsuario.cbox_database.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONF_DATABASE");

                        viewUsuario.ShowDialog();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum usuário encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }

        //BUSCA POR APELIDO

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbox_apelido.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridUsuarios gridUsuarios = new F_GridUsuarios();
                    gridUsuarios.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (checkBox3.Checked == true)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string apelido = tbox_apelido.Text;
                        dataTable = Usuario.obterDadosUsuarioApelidoInativo(apelido);

                        F_ViewUsuario viewUsuario = new F_ViewUsuario();

                        viewUsuario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewUsuario.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME");
                        viewUsuario.tbox_apelido.Text = dataTable.Rows[0].Field<string>("APELIDO");
                        viewUsuario.tbox_senha.Text = dataTable.Rows[0].Field<string>("SENHA");
                        viewUsuario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO");
                        viewUsuario.cbox_acessoGestao.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_GESTAO");
                        viewUsuario.cbox_financeiro.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_FINANCEIRO");
                        viewUsuario.cbox_configuracoes.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONFIGURACAO");
                        viewUsuario.cbox_database.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONF_DATABASE");

                        viewUsuario.ShowDialog();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum usuário encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
                else
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string apelido = tbox_apelido.Text;
                        dataTable = Usuario.obterDadosUsuarioApelidoAtivo(apelido);

                        F_ViewUsuario viewUsuario = new F_ViewUsuario();

                        viewUsuario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewUsuario.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME");
                        viewUsuario.tbox_apelido.Text = dataTable.Rows[0].Field<string>("APELIDO");
                        viewUsuario.tbox_senha.Text = dataTable.Rows[0].Field<string>("SENHA");
                        viewUsuario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO");
                        viewUsuario.cbox_acessoGestao.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_GESTAO");
                        viewUsuario.cbox_financeiro.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_FINANCEIRO");
                        viewUsuario.cbox_configuracoes.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONFIGURACAO");
                        viewUsuario.cbox_database.Text = dataTable.Rows[0].Field<string>("PERMITE_ACESSO_CONF_DATABASE");

                        viewUsuario.ShowDialog();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum usuário encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }
    }
}
