using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAcademy
{
    class Usuario
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Datasource = C:\\MyAcademy\\database.db");
            conexao.Open();
            return conexao;
        }

        public Int32 codigo;
        public string nome;
        public string apelido;
        public string senha;
        public string ativo;
        public string permiteAcessoGestao;
        public string permiteAcessoFinanceiro;
        public string pemiteAcessoConfiguracao;
        public string permiteAcessoDatabase;
        public DateTime dataCadastro = DateTime.Now.Date;

        public static DataTable obterUsuarios()
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM USUARIOS";
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    dataAdapter.Fill(dataTable);
                    vcon.Close();
                    return dataTable;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public static DataTable consulta(string SQL)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = SQL;
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    dataAdapter.Fill(dataTable);
                    vcon.Close();
                    return dataTable;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao validar usuário", error.Message);
                throw error;
            }
        }

        public static void novoUsuario(Usuario usuario)
        {
            if (verificaUsuario(usuario))
            {
                MessageBox.Show("Usuário informado já existe!");
                return;
            }

            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO USUARIOS (NOME, 
                                                          APELIDO, 
                                                          SENHA, 
                                                          ATIVO, 
                                                          PERMITE_ACESSO_GESTAO, 
                                                          PERMITE_ACESSO_FINANCEIRO, 
                                                          PERMITE_ACESSO_CONFIGURACAO, 
                                                          PERMITE_ACESSO_CONF_DATABASE, 
                                                          DATA_CADASTRO ) 
                                  VALUES (@nome, 
                                          @apelido, 
                                          @senha, 
                                          @ativo, 
                                          @permiteAcessoGestao, 
                                          @permiteAcessoFinanceiro, 
                                          @permiteAcessoConfiguracao, 
                                          @permiteAcessoDatabase,
                                          @dataCadastro)";

                cmd.Parameters.AddWithValue("@nome", usuario.nome);
                cmd.Parameters.AddWithValue("@apelido", usuario.apelido);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@ativo", usuario.ativo);
                cmd.Parameters.AddWithValue("@permiteAcessoGestao", usuario.permiteAcessoGestao);
                cmd.Parameters.AddWithValue("@permiteAcessoFinanceiro", usuario.permiteAcessoFinanceiro);
                cmd.Parameters.AddWithValue("@permiteAcessoConfiguracao", usuario.pemiteAcessoConfiguracao);
                cmd.Parameters.AddWithValue("@permiteAcessoDatabase", usuario.permiteAcessoDatabase);
                cmd.Parameters.AddWithValue("@dataCadastro", usuario.dataCadastro);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado com Sucesso!");
                vcon.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("", error.Message);
            }
        }


        public static bool verificaUsuario(Usuario usuario)
        {
            bool res;

            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            var vcon = conexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT APELIDO FROM USUARIOS WHERE APELIDO ='" + usuario.apelido + "'";
            dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }

        public static DataTable listaUsuarios()
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            var vcon = conexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT CODIGO, NOME, APELIDO, ATIVO FROM USUARIOS";
            dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
            dataAdapter.Fill(dataTable);
            vcon.Close();

            return dataTable;
        }

        public static DataTable atualizarUsuario(Usuario usuario)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"UPDATE USUARIOS SET NOME='" + usuario.nome +
                                   "', APELIDO='" + usuario.apelido +
                                   "', SENHA='" + usuario.senha +
                                   "', ATIVO='" + usuario.ativo +
                                   "', PERMITE_ACESSO_GESTAO='" + usuario.permiteAcessoGestao +
                                   "', PERMITE_ACESSO_FINANCEIRO='" + usuario.permiteAcessoFinanceiro +
                                   "', PERMITE_ACESSO_CONFIGURACAO='" + usuario.pemiteAcessoConfiguracao +
                                   "', PERMITE_ACESSO_CONF_DATABASE='" + usuario.permiteAcessoDatabase +
                                   "' WHERE CODIGO=" + usuario.codigo + ";";

                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao atualizar cadastro", error.Message);
                throw error;
            }

            return null;
        }

        /// BUSCA DE USUARIOS
        
            
            ///LOCALIZA USUARIO POR CODIGO

        public static DataTable obterDadosUsuario(string id)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM USUARIOS WHERE CODIGO ='" + id + "'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao abrir cadastro", error.Message);
                throw error;
            }
        }

        public static DataTable obterDadosUsuarioCodigoAtivo(string id)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM USUARIOS WHERE ATIVO = 'Sim' AND CODIGO ='" + id + "'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao abrir cadastro", error.Message);
                throw error;
            }
        }

            ///LOCALIZA USUARIO POR NOME

        public static DataTable obterDadosUsuarioNomeAtivo(string nome)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM USUARIOS WHERE ATIVO = 'Sim' AND NOME ='" + nome + "'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao abrir cadastro", error.Message);
                throw error;
            }
        }

        public static DataTable obterDadosUsuarioNomeInativo(string nome)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM USUARIOS WHERE NOME ='" + nome + "'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao abrir cadastro", error.Message);
                throw error;
            }
        }

            ///LOCALIZA USUARIO POR APELIDO

        public static DataTable obterDadosUsuarioApelidoAtivo(string apelido)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM USUARIOS WHERE ATIVO = 'Sim' AND APELIDO ='" + apelido + "'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao abrir cadastro", error.Message);
                throw error;
            }
        }

        public static DataTable obterDadosUsuarioApelidoInativo(string apelido)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM USUARIOS WHERE APELIDO ='" + apelido + "'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao abrir cadastro", error.Message);
                throw error;
            }
        }
    }
}
