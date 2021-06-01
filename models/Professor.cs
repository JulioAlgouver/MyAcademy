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
    class Professor
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
        public string especialidade;
        public string celular;
        public string telefone;
        public Int32 idHorario;
        public string horario;
        public string ativo;
        public DateTime data_cadastro = DateTime.Now.Date;

        public static void novoProfessor(Professor professor)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO PROFESSORES (NOME, ESPECIALIDADE, CELULAR, TELEFONE, HORARIO, ATIVO, DATA_CADASTRO)
                                                     VALUES (@nome, @especialidade, @celular, @telefone, @horario, @ativo, @data_cadastro)";

                cmd.Parameters.AddWithValue("@nome", professor.nome);
                cmd.Parameters.AddWithValue("@especialidade", professor.especialidade);
                cmd.Parameters.AddWithValue("@celular", professor.celular);
                cmd.Parameters.AddWithValue("@telefone", professor.telefone);
                cmd.Parameters.AddWithValue("@horario", professor.horario);
                cmd.Parameters.AddWithValue("@ativo", professor.ativo);
                cmd.Parameters.AddWithValue("@data_cadastro", professor.data_cadastro);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Professor cadastrado com sucesso!");
                vcon.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível concluir o cadastro", "Alerta", MessageBoxButtons.OK);
                throw error;
            }
        }
    }
}
