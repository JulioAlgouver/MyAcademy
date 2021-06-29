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
    class Turma
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Datasource = C:\\MyAcademy\\database.db");
            conexao.Open();
            return conexao;
        }

        public Int32 codigo;
        public string desc_turma;
        public Int32 id_professor;
        public string nome_professor;
        public Int32 limite_alunos;
        public Int32 id_horario;
        public string desc_horario;
        public string ativo;

        public static void novaTurma(Turma turma)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO TURMAS (DESC_TURMA, ID_PROFESSOR, NOME_PROFESSOR, LIMITE_ALUNOS, ID_HORARIO, DESC_HORARIO, ATIVO)
                                  VALUES (@descricaoTurma,@idProfessor,@nomeProfessor,@limiteAlunos,@idHorario,@descricaoHorario,@ativo)";

                cmd.Parameters.AddWithValue("@descricaoTurma", turma.desc_turma);
                cmd.Parameters.AddWithValue("@idProfessor", turma.id_professor);
                cmd.Parameters.AddWithValue("@nomeProfessor", turma.nome_professor);
                cmd.Parameters.AddWithValue("@limiteAlunos", turma.limite_alunos);
                cmd.Parameters.AddWithValue("@idHorario", turma.id_horario);
                cmd.Parameters.AddWithValue("@descricaoHorario", turma.desc_horario);
                cmd.Parameters.AddWithValue("@ativo", turma.ativo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Turma cadastrada com sucesso!");
                vcon.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível concluir o cadastro", "Alerta", MessageBoxButtons.OK);
                throw error;
            }
        }

        public static DataTable atualizarTurma(Turma turma)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"UPDATE TURMAS SET CODIGO='" + turma.codigo +
                                   "', DESC_TURMA='" + turma.desc_turma +
                                   "', ID_PROFESSOR='" + turma.id_professor +
                                   "', NOME_PROFESSOR='" + turma.nome_professor +
                                   "', LIMITE_ALUNOS='" + turma.limite_alunos +
                                   "', ID_HORARIO='" + turma.id_horario +
                                   "', DESC_HORARIO='" + turma.desc_horario +
                                   "', ATIVO='" + turma.ativo +
                                   "' WHERE CODIGO=" + turma.codigo + ";";

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

        public static DataTable obterTurmas()
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT CODIGO, DESC_TURMA AS 'DESCRIÇÃO', NOME_PROFESSOR AS 'PROFESSOR', DESC_HORARIO AS 'HORARIO' FROM TURMAS";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }catch (Exception error)
            {
                throw error;
            }
        }

        public static DataTable localizarTurmaInativaPorID(string id)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM TURMAS WHERE CODIGO ='" + id + "'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public static DataTable localizarTurmaAtivaPorID(string id)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM TURMAS WHERE ATIVO = 'Sim' AND CODIGO ='"+id+"'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public static DataTable localizarTurmaInativaPorNome(string nome)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM TURMAS WHERE NOME ='"+nome+"'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public static DataTable localizarTurmaAtivaPorNome(string nome)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM TURMAS WHERE ATIVO ='Sim' AND NOME='"+nome+"'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public static DataTable obterIdNomeTurma()
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT CODIGO, DESC_TURMA FROM TURMAS WHERE ATIVO = 'Sim'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);

                return dataTable;

            }catch(Exception error)
            {
                MessageBox.Show("Não foi possível obter listagem de turmas", "Erro", MessageBoxButtons.OK);
                throw error;
            }
        }
    }
}
