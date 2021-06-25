using System;
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
    public partial class F_BuscaConvenio : Form
    {
        public F_BuscaConvenio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbox_codigoConvenio.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridConveniosOnFormBusca gridConvenios = new F_GridConveniosOnFormBusca();
                    gridConvenios.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if(checkBox1.Checked == true)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string id = tbox_codigoConvenio.Text;
                        dataTable = Convenio.localizaConvenioInativoPorID(id);

                        F_ViewConvenio viewConvenio = new F_ViewConvenio();
                        viewConvenio.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewConvenio.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewConvenio.tbox_desconto.Text = dataTable.Rows[0].Field<Double>("PERC_DESCONTO").ToString();
                        viewConvenio.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewConvenio.ShowDialog();
                        this.Close();

                    }catch (Exception error)
                    {
                        MessageBox.Show("Nenhum convênio encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
                else
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string id = tbox_codigoConvenio.Text;
                        dataTable = Convenio.localizaConvenioAtivoPorID(id);

                        F_ViewConvenio viewConvenio = new F_ViewConvenio();
                        viewConvenio.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewConvenio.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewConvenio.tbox_desconto.Text = dataTable.Rows[0].Field<Int64>("PERC_DESCONTO").ToString();
                        viewConvenio.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewConvenio.ShowDialog();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum convênio encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbox_nomeConvenio.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridConveniosOnFormBusca gridConvenios = new F_GridConveniosOnFormBusca();
                    gridConvenios.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string nome = tbox_nomeConvenio.Text;
                        dataTable = Convenio.localizaConvenioInativoPorNome(nome);

                        F_ViewConvenio viewConvenio = new F_ViewConvenio();
                        viewConvenio.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewConvenio.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewConvenio.tbox_desconto.Text = dataTable.Rows[0].Field<Double>("PERC_DESCONTO").ToString();
                        viewConvenio.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewConvenio.ShowDialog();
                        this.Close();

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum convênio encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
                else
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string nome = tbox_nomeConvenio.Text;
                        dataTable = Convenio.localizaConvenioAtivoPorNome(nome);

                        F_ViewConvenio viewConvenio = new F_ViewConvenio();
                        viewConvenio.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewConvenio.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewConvenio.tbox_desconto.Text = dataTable.Rows[0].Field<Double>("PERC_DESCONTO").ToString();
                        viewConvenio.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewConvenio.ShowDialog();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum convênio encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }
    }
}
