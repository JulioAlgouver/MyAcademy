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
    public partial class F_BuscaProfessor : Form
    {
        public F_BuscaProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbox_codigo.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridProfessoresOnFormBusca gridProfessores = new F_GridProfessoresOnFormBusca();
                    gridProfessores.ShowDialog();
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
                        string id = tbox_codigo.Text;
                        dataTable = Professor.localizarProfessorInativoPorID(id);

                        F_ViewProfissional viewProfissional = new F_ViewProfissional();

                        viewProfissional.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewProfissional.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewProfissional.tbox_especialidade.Text = dataTable.Rows[0].Field<string>("ESPECIALIDADE").ToString();
                        viewProfissional.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewProfissional.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewProfissional.tbox_horario.Text = dataTable.Rows[0].Field<string>("HORARIO").ToString();
                        viewProfissional.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewProfissional.ShowDialog();

                        this.Close();

                    }catch (Exception error)
                    {
                        MessageBox.Show("Nenhum professor encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
                else
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string id = tbox_codigo.Text;
                        dataTable = Professor.localizarProfessorAtivoPorID(id);

                        F_ViewProfissional viewProfissional = new F_ViewProfissional();

                        viewProfissional.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewProfissional.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewProfissional.tbox_especialidade.Text = dataTable.Rows[0].Field<string>("ESPECIALIDADE").ToString();
                        viewProfissional.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewProfissional.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewProfissional.tbox_horario.Text = dataTable.Rows[0].Field<string>("HORARIO").ToString();
                        viewProfissional.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewProfissional.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum professor encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbox_nome.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridProfessoresOnFormBusca gridProfessores = new F_GridProfessoresOnFormBusca();
                    gridProfessores.ShowDialog();
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
                        string nome = tbox_nome.Text;
                        dataTable = Professor.localizarProfessorInativoPorNome(nome);

                        F_ViewProfissional viewProfissional = new F_ViewProfissional();

                        viewProfissional.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewProfissional.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewProfissional.tbox_especialidade.Text = dataTable.Rows[0].Field<string>("ESPECIALIDADE").ToString();
                        viewProfissional.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewProfissional.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewProfissional.tbox_horario.Text = dataTable.Rows[0].Field<string>("HORARIO").ToString();
                        viewProfissional.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewProfissional.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum professor encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
                else
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string nome = tbox_nome.Text;
                        dataTable = Professor.localizarProfessorAtivoPorNome(nome);

                        F_ViewProfissional viewProfissional = new F_ViewProfissional();

                        viewProfissional.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewProfissional.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewProfissional.tbox_especialidade.Text = dataTable.Rows[0].Field<string>("ESPECIALIDADE").ToString();
                        viewProfissional.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewProfissional.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewProfissional.tbox_horario.Text = dataTable.Rows[0].Field<string>("HORARIO").ToString();
                        viewProfissional.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewProfissional.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum professor encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }
    }
}
