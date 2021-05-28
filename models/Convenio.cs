﻿using System;
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

        public Int32 codigo;
        public string nome;
        public double perc_desconto;
        public string ativo;
        public DateTime data_cadastro = DateTime.Now.Date;

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

        public static void novoConvenio(Convenio convenio)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO CONVENIOS (NOME,
                                                           PERC_DESCONTO,
                                                           ATIVO,
                                                           DATA_CADASTRO)
                                    VALUES (@nome,
                                            @perc_desconto,
                                            @ativo,
                                            @data_cadastro)";

                cmd.Parameters.AddWithValue("@nome", convenio.nome);
                cmd.Parameters.AddWithValue("@perc_desconto", convenio.perc_desconto);
                cmd.Parameters.AddWithValue("@ativo", convenio.ativo);
                cmd.Parameters.AddWithValue("@data_cadastro", convenio.data_cadastro);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Convênio cadastrado com Sucesso!");
                vcon.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível cadastrar o convênio","Erro", MessageBoxButtons.OK);
                throw error;
            }
        }
    }
}