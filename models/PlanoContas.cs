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

        public string tipoConta;
        public string codigo;
        public string descricao;
        public string ativo;
        public string codigoRaiz;

        public static void novoItem(PlanoContas planoContas)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO CONTAS_CENTRO_CUSTO (TIPO_CONTA, CODIGO, DESCRICAO, ATIVO, CODIGO_RAIZ)
                                                        VALUES(@tipoConta,@codigo,@descricao,@ativo,@codigoRaiz)";
                cmd.Parameters.AddWithValue("@tipoConta", planoContas.tipoConta);
                cmd.Parameters.AddWithValue("@codigo", planoContas.codigo);
                cmd.Parameters.AddWithValue("@descricao", planoContas.descricao);
                cmd.Parameters.AddWithValue("@ativo", planoContas.ativo);
                cmd.Parameters.AddWithValue("@codigoRaiz", planoContas.codigoRaiz);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso", "Aviso!", MessageBoxButtons.OK);
                vcon.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show("Não foi possível realizar o cadastro", "Alerta!", MessageBoxButtons.OK);
                throw error;
            }
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
