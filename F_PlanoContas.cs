﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAcademy
{
    public partial class F_PlanoContas : Form
    {
        int countLinhas;
        bool isSelected;

        public F_PlanoContas()
        {
            InitializeComponent();

            isSelected = false;
        }

        private void F_PlanoContas_Load(object sender, EventArgs e)
        {            
            DataTable dataTable = new DataTable();
            dataTable = PlanoContas.carregarGrupos();

            for (countLinhas=0; countLinhas < dataTable.Rows.Count; countLinhas++)
            {
                if (dataTable.Rows[countLinhas].Field<string>("TIPO_CONTA").ToString() == "")
                {
                viewPlanoContas.Nodes.Add(Name = "node_" + dataTable.Rows[countLinhas].Field<string>("CODIGO").ToString(),
                                          Text = dataTable.Rows[countLinhas].Field<string>("CODIGO").ToString() + " : " + dataTable.Rows[countLinhas].Field<string>("DESCRICAO").ToString());
                }

                if (dataTable.Rows[countLinhas].Field<string>("TIPO_CONTA").ToString() == "+")
                {
                    viewPlanoContas.Nodes.Add(Name = dataTable.Rows[countLinhas].Field<string>("DESCRICAO").ToString(),
                                          Text = dataTable.Rows[countLinhas].Field<string>("CODIGO").ToString() + " : " + dataTable.Rows[countLinhas].Field<string>("DESCRICAO").ToString());
                }

                if (dataTable.Rows[countLinhas].Field<string>("TIPO_CONTA").ToString() == "-")
                {

                }
            }
        }

        private void viewPlanoContas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            isSelected = true;
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(isSelected == false)
            {
                MessageBox.Show("Nenhum ramo selecionado!", "Alerta!", MessageBoxButtons.OK);
                return;
            }

            F_CadPlanoContas planoContas = new F_CadPlanoContas();
            planoContas.ShowDialog();
        }
    }
}
