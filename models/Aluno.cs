using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace MyAcademy
{
    class Aluno
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
        public string telefone;
        public string celular;
        public Int32 idConvenio;
        public string possuiConvenio;
        public string nomeConvenio;
        public string ativo;
        public DateTime dataCdastro = DateTime.Now.Date;

        public static void novoAluno(Aluno aluno)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = @"INSERT INTO ALUNOS (NOME, 
                                                        TELEFONE, 
                                                        CELULAR, 
                                                        POSSUI_CONVENIO, 
                                                        ID_CONVENIO,
                                                        NOME_CONVENIO, 
                                                        ATIVO, 
                                                        DATA_CADASTRO)
                                    VALUES (@nome,
                                            @telefone,
                                            @celular,
                                            @possuiConvenio,
                                            @idConvenio,
                                            @nomeConvenio,
                                            @ativo,
                                            @dataCadastro)";

                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@telefone", aluno.telefone);
                cmd.Parameters.AddWithValue("@celular", aluno.celular);
                cmd.Parameters.AddWithValue("@possuiConvenio", aluno.possuiConvenio);
                cmd.Parameters.AddWithValue("@idConvenio", aluno.idConvenio);
                cmd.Parameters.AddWithValue("@nomeConvenio", aluno.nomeConvenio);
                cmd.Parameters.AddWithValue("@ativo", aluno.ativo);
                cmd.Parameters.AddWithValue("@dataCadastro", aluno.dataCdastro);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno cadastrado com Sucesso!");
                vcon.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível cadastrar aluno", "Erro",MessageBoxButtons.OK);
                throw error;
            }
        }

        public static DataTable atualizarAluno(Aluno aluno)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"UPDATE ALUNOS SET NOME='" + aluno.nome +
                                   "', TELEFONE='" + aluno.telefone +
                                   "', CELULAR='" + aluno.celular +
                                   "', POSSUI_CONVENIO='" + aluno.possuiConvenio +
                                   "', ID_CONVENIO='" + aluno.idConvenio +
                                   "', NOME_CONVENIO='" + aluno.nomeConvenio +
                                   "', ATIVO='" + aluno.ativo +
                                   "' WHERE CODIGO=" + aluno.codigo + ";";

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

        public static DataTable listaAlunos()
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT CODIGO, NOME, TELEFONE, NOME_CONVENIO AS 'CONVÊNIO' FROM ALUNOS";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch(Exception error)
            {
                throw error;
            }
        }

        public static DataTable localizarAlunoAtivoPorID(string id)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM ALUNOS WHERE ATIVO = 'Sim' AND CODIGO ='" + id + "'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;

            }catch(Exception error)
            {
                MessageBox.Show("Erro ao abrir cadastro", error.Message);
                throw error;
            }
        }

        public static DataTable localizarAlunoInativoPorID(string id)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM ALUNOS WHERE CODIGO ='" + id + "'";
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

        public static DataTable localizarAlunoAtivoPorNome(string nome)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM ALUNOS WHERE ATIVO = 'Sim' AND NOME ='" + nome + "'";
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

        public static DataTable localizarAlunoInativoPorNome(string nome)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM ALUNOS WHERE NOME ='" + nome + "'";
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

        public static DataTable localizarAlunoAtivoPorTelefone(string telefone)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM ALUNOS WHERE ATIVO = 'Sim' AND TELEFONE ='" + telefone + "'";
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

        public static DataTable localizarAlunoInativoPorTelefone(string telefone)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM ALUNOS WHERE TELEFONE ='" + telefone + "'";
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
