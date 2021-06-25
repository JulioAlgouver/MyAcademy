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
    class Horario
    {
        private static SQLiteConnection conexao;
        
        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Datasource = C:\\MyAcademy\\database.db");
            conexao.Open();
            return conexao;
        }

        public Int32 id_horario;
        public string desc_horario;
        public string hora_inicio;
        public string hora_fim;
        public string ativo;
        public DateTime data_cadastro = DateTime.Now.Date;

        public static void novoHorario(Horario horario)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO HORARIOS (DESC_HORARIO, HORA_INICIO, HORA_FIM, ATIVO, DATA_CADASTRO)
                                            VALUES (@desc_horario, @hora_inicio, @hora_fim, @ativo, @data_cadastro)";

                cmd.Parameters.AddWithValue("@desc_horario", horario.desc_horario);
                cmd.Parameters.AddWithValue("@hora_inicio", horario.hora_inicio);
                cmd.Parameters.AddWithValue("@hora_fim", horario.hora_fim);
                cmd.Parameters.AddWithValue("@ativo", horario.ativo);
                cmd.Parameters.AddWithValue("@data_cadastro", horario.data_cadastro);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Horario cadastrado com sucesso!");
                vcon.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível concluir o cadastro","Alerta",MessageBoxButtons.OK);
                throw error;
            }
        }

        public static DataTable atualizarHorario(Horario horario)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"UPDATE HORARIOS SET ID_HORARIO='" + horario.id_horario +
                                   "', DESC_HORARIO='" + horario.desc_horario +
                                   "', HORA_INICIO='" + horario.hora_inicio +
                                   "', HORA_FIM='" + horario.hora_fim +
                                   "', ATIVO='" + horario.ativo +
                                   "' WHERE ID_HORARIO=" + horario.id_horario + ";";

                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro atualizado com sucesso!", "Alerta", MessageBoxButtons.OK);
                vcon.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao atualizar cadastro", error.Message);
                throw error;
            }

            return null;
        }

        public static DataTable obterHorarios()
        {
            try
            {
                {
                    SQLiteDataAdapter dataAdapter = null;
                    DataTable dataTable = new DataTable();

                    var vcon = conexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = @"SELECT ID_HORARIO as 'CODIGO', DESC_HORARIO as 'Descrição', HORA_INICIO as 'Horário Inicial', HORA_FIM as 'Horário Final' FROM HORARIOS WHERE ATIVO = 'Sim'";
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    dataAdapter.Fill(dataTable);
                    vcon.Close();

                    return dataTable;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao acessar lista de horários.", "Alerta!", MessageBoxButtons.OK);
                throw error;
            }
        }

        public static DataTable localizarHorarioInativoPorID(string id)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM HORARIOS WHERE ID_HORARIO ='" + id+"'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText,vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;

            }catch(Exception error)
            {
                throw error;
            }
        }

        public static DataTable localizarHorarioAtivoPorID(string id)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM HORARIOS WHERE ATIVO = 'Sim' AND ID_HORARIO ='" + id + "'";
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

        public static DataTable localizarHorarioInativoPorNome(string nome)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM HORARIOS WHERE DESC_HORARIO ='" + nome + "'";
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

        public static DataTable localizarHorarioAtivoPorNome(string nome)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM HORARIOS WHERE ATIVO = 'Sim' AND DESC_HORARIO ='" + nome + "'";
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
    }
}
