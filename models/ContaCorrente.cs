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
    class ContaCorrente
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Datasource = C:\\MyAcademy\\database.db");
            conexao.Open();
            return conexao;
        }

        public Int32 codigo;
        public string descricao;
        public string banco;
        public string agencia;
        public string contaCorrente;
        public double saldoInicial;

        public static void novaConta(ContaCorrente contaCorrente)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO CONTAS_CORRENTE (DESCRICAO, BANCO, AGENCIA, CONTA_CORRENTE, SALDO_INICIAL)
                                                    VALUES (@descricao,@banco,@agencia,@contaCorrente,@saldoInicial)";
                cmd.Parameters.AddWithValue("@descricao", contaCorrente.descricao);
                cmd.Parameters.AddWithValue("@banco", contaCorrente.banco);
                cmd.Parameters.AddWithValue("@agencia", contaCorrente.agencia);
                cmd.Parameters.AddWithValue("@contaCorrente", contaCorrente.contaCorrente);
                cmd.Parameters.AddWithValue("@saldoInicial", contaCorrente.saldoInicial);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");
                vcon.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show("Não foi possivel efetuar o cadastro!","Erro",MessageBoxButtons.OK);
                throw error;
            }
        }

        public static void atualizarConta(ContaCorrente contaCorrente)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE CONTAS_CORRENTE SET DESCRICAO='" + contaCorrente.descricao +
                                                               "', BANCO='" + contaCorrente.banco +
                                                               "', AGENCIA='" + contaCorrente.agencia +
                                                               "', CONTA_CORRENTE='" + contaCorrente.contaCorrente + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK);
                vcon.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show("Erro ao atualizar cadastro","Alerta",MessageBoxButtons.OK);
                throw error;
            }
        }

        public static DataTable listarContasCorrente()
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT DESCRICAO FROM CONTAS_CORRENTE";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText,vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }catch(Exception error)
            {
                MessageBox.Show("");
                throw error;
            }
        }

        public static DataTable obterDadosContasCorrente(string nome)
        {
            try
            {
                SQLiteDataAdapter dataAdapter = null;
                DataTable dataTable = new DataTable();

                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM CONTAS_CORRENTE";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();

                return dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível obter dados","Alerta",MessageBoxButtons.OK);
                throw error;
            }
        }
    }
}
