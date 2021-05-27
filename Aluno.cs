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

        public static Int32 codigo;
        public static string nome;
        public static string telefone;
        public static string celular;
        public static string possuiConvenio;
        public static string nomeConvenio;
        public static string ativo;
        public static DateTime dataCdastro = DateTime.Now.Date;

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
                                                        NOME_CONVENIO, 
                                                        ATIVO, 
                                                        DATA_CADASTRO)
                                    VALUES (@nome,
                                            @telefone,
                                            @celular,
                                            @possuiConvenio,
                                            @nomeConvenio,
                                            @ativo,
                                            @dataCadastro)";

                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@telefone", aluno.telefone);
                cmd.Parameters.AddWithValue("@celular", aluno.celular);
                cmd.Parameters.AddWithValue("@possuiConvenio", aluno.possuiConvenio);
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
    }
}
