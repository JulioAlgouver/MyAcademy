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
    public partial class F_GridUsuarios : Form
    {
        public F_GridUsuarios()
        {
            InitializeComponent();
        }

        private void F_GridUsuarios_Load(object sender, EventArgs e)
        {
            gridUsuarios.DataSource = Usuario.listaUsuarios();

            gridUsuarios.Columns[0].Width = 50;
            gridUsuarios.Columns[1].Width = 200;
            gridUsuarios.Columns[2].Width = 140;
            gridUsuarios.Columns[3].Width = 52;
        }   

        private void gridUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int contLinhas = gridUsuarios.Rows.Count;

            if(contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string vid = gridUsuarios.SelectedRows[0].Cells[0].Value.ToString(); 
                dataTable = Usuario.obterDadosUsuario(vid);

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
        }
    }
}
