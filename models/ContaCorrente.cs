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
        public Int32 agencia;
        public Int32 contaCorrente;
        public double saldoInicial;

        public static void novaConta(ContaCorrente contaCorrente)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO CONTAS_CORRENTES (DESCRICAO, BANCO, AGENCIA, CONTA_CORRENTE, SALDO_INICIAL)
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
    }
}
