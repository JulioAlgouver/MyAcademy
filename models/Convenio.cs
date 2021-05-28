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
    class Convenio
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
        public static double perc_desconto;
        public static string ativo;

        public static DataTable listaConvenios()
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"SELECT CODIGO, NOME, PERC_DESCONTO as 'DESCONTO (%)', ATIVO FROM CONVENIOS WHERE ATIVO = 'Sim'";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao acessar lista de convênios.", "Alerta!", MessageBoxButtons.OK);
                throw error;
            }
        }
    }
}
