using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MyAcademy
{
    class PlanoContas
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Datasource = C:\\MyAcademy\\database.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable carregarGrupos()
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM CONTAS_CENTRO_CUSTO WHERE TIPO_CONTA = '' ";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText,vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch(Exception error)
            {
                MessageBox.Show("Não foi possível listar ramos do plano de contas", "Erro", MessageBoxButtons.OK);
                throw error;
            }
        }
    }
}
