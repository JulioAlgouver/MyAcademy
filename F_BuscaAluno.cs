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
    public partial class F_BuscaAluno : Form
    {
        public F_BuscaAluno()
        {
            InitializeComponent();
        }

        private void btn_busca1_Click(object sender, EventArgs e)
        {
            if(tbox_codigo.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridAlunos gridAlunos = new F_GridAlunos();
                    gridAlunos.ShowDialog();
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
                        dataTable = Aluno.localizarAlunoInativoPorID(id);

                        F_ViewAluno viewAluno = new F_ViewAluno();

                        viewAluno.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewAluno.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewAluno.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewAluno.cbox_possuiConvenio.Text = dataTable.Rows[0].Field<string>("POSSUI_CONVENIO").ToString();
                        viewAluno.tbox_idConvenio.Text = dataTable.Rows[0].Field<Int64>("ID_CONVENIO").ToString();
                        viewAluno.tbox_convenio.Text = dataTable.Rows[0].Field<string>("NOME_CONVENIO").ToString();
                        viewAluno.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewAluno.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewAluno.ShowDialog();

                        this.Close();

                    }catch(Exception error)
                    {
                        MessageBox.Show("Nenhum aluno encontrado", "Aviso", MessageBoxButtons.OK);
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
                        dataTable = Aluno.localizarAlunoAtivoPorID(id);

                        F_ViewAluno viewAluno = new F_ViewAluno();

                        viewAluno.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewAluno.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewAluno.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewAluno.cbox_possuiConvenio.Text = dataTable.Rows[0].Field<string>("POSSUI_CONVENIO").ToString();
                        viewAluno.tbox_idConvenio.Text = dataTable.Rows[0].Field<Int64>("ID_CONVENIO").ToString();
                        viewAluno.tbox_convenio.Text = dataTable.Rows[0].Field<string>("NOME_CONVENIO").ToString();
                        viewAluno.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewAluno.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewAluno.ShowDialog();

                        this.Close();
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show("Nenhum aluno encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }

        private void btn_busca2_Click(object sender, EventArgs e)
        {
            if (tbox_nome.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridAlunos gridAlunos = new F_GridAlunos();
                    gridAlunos.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string nome = tbox_nome.Text;
                        dataTable = Aluno.localizarAlunoInativoPorNome(nome);

                        F_ViewAluno viewAluno = new F_ViewAluno();

                        viewAluno.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewAluno.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewAluno.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewAluno.cbox_possuiConvenio.Text = dataTable.Rows[0].Field<string>("POSSUI_CONVENIO").ToString();
                        viewAluno.tbox_idConvenio.Text = dataTable.Rows[0].Field<Int64>("ID_CONVENIO").ToString();
                        viewAluno.tbox_convenio.Text = dataTable.Rows[0].Field<string>("NOME_CONVENIO").ToString();
                        viewAluno.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewAluno.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewAluno.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum aluno encontrado", "Aviso", MessageBoxButtons.OK);
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
                        dataTable = Aluno.localizarAlunoAtivoPorNome(nome);

                        F_ViewAluno viewAluno = new F_ViewAluno();

                        viewAluno.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewAluno.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewAluno.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewAluno.cbox_possuiConvenio.Text = dataTable.Rows[0].Field<string>("POSSUI_CONVENIO").ToString();
                        viewAluno.tbox_idConvenio.Text = dataTable.Rows[0].Field<Int64>("ID_CONVENIO").ToString();
                        viewAluno.tbox_convenio.Text = dataTable.Rows[0].Field<string>("NOME_CONVENIO").ToString();
                        viewAluno.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewAluno.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewAluno.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum aluno encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }

        private void btn_busca3_Click(object sender, EventArgs e)
        {
            if (tbox_telefone.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridAlunos gridAlunos = new F_GridAlunos();
                    gridAlunos.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string telefone = tbox_codigo.Text;
                        dataTable = Aluno.localizarAlunoInativoPorTelefone(telefone);

                        F_ViewAluno viewAluno = new F_ViewAluno();

                        viewAluno.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewAluno.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewAluno.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewAluno.cbox_possuiConvenio.Text = dataTable.Rows[0].Field<string>("POSSUI_CONVENIO").ToString();
                        viewAluno.tbox_idConvenio.Text = dataTable.Rows[0].Field<Int64>("ID_CONVENIO").ToString();
                        viewAluno.tbox_convenio.Text = dataTable.Rows[0].Field<string>("NOME_CONVENIO").ToString();
                        viewAluno.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewAluno.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewAluno.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum aluno encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
                else
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string telefone = tbox_codigo.Text;
                        dataTable = Aluno.localizarAlunoAtivoPorTelefone(telefone);

                        F_ViewAluno viewAluno = new F_ViewAluno();

                        viewAluno.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewAluno.tbox_nome.Text = dataTable.Rows[0].Field<string>("NOME").ToString();
                        viewAluno.tbox_telefone.Text = dataTable.Rows[0].Field<string>("TELEFONE").ToString();
                        viewAluno.cbox_possuiConvenio.Text = dataTable.Rows[0].Field<string>("POSSUI_CONVENIO").ToString();
                        viewAluno.tbox_idConvenio.Text = dataTable.Rows[0].Field<Int64>("ID_CONVENIO").ToString();
                        viewAluno.tbox_convenio.Text = dataTable.Rows[0].Field<string>("NOME_CONVENIO").ToString();
                        viewAluno.tbox_celular.Text = dataTable.Rows[0].Field<string>("CELULAR").ToString();
                        viewAluno.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewAluno.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum aluno encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }
    }
}
