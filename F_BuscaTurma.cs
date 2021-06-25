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
    public partial class F_BuscaTurma : Form
    {
        public F_BuscaTurma()
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
                    F_GridTurma gridTurma = new F_GridTurma();
                    gridTurma.ShowDialog();
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
                        dataTable = Turma.localizarTurmaInativaPorID(id);

                        F_ViewTurma viewTurma = new F_ViewTurma();

                        viewTurma.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewTurma.tbox_nomeTurma.Text = dataTable.Rows[0].Field<string>("DESC_TURMA").ToString();
                        viewTurma.tbox_idProfessor.Text = dataTable.Rows[0].Field<Int64>("ID_PROFESSOR").ToString();
                        viewTurma.tbox_professor.Text = dataTable.Rows[0].Field<string>("NOME_PROFESSOR").ToString();
                        viewTurma.tbox_idHorario.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                        viewTurma.tbox_horario.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                        viewTurma.tbox_limiteAlunos.Text = dataTable.Rows[0].Field<Int64>("LIMITE_ALUNOS").ToString();
                        viewTurma.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewTurma.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhuma turma encontrada", "Aviso", MessageBoxButtons.OK);
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
                        dataTable = Turma.localizarTurmaAtivaPorID(id);

                        F_ViewTurma viewTurma = new F_ViewTurma();

                        viewTurma.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewTurma.tbox_nomeTurma.Text = dataTable.Rows[0].Field<string>("DESC_TURMA").ToString();
                        viewTurma.tbox_idProfessor.Text = dataTable.Rows[0].Field<Int64>("ID_PROFESSOR").ToString();
                        viewTurma.tbox_professor.Text = dataTable.Rows[0].Field<string>("NOME_PROFESSOR").ToString();
                        viewTurma.tbox_idHorario.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                        viewTurma.tbox_horario.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                        viewTurma.tbox_limiteAlunos.Text = dataTable.Rows[0].Field<Int64>("LIMITE_ALUNOS").ToString();
                        viewTurma.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewTurma.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhuma turma encontrada", "Aviso", MessageBoxButtons.OK);
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
                    F_GridTurma gridTurma = new F_GridTurma();
                    gridTurma.ShowDialog();
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
                        string nome = tbox_nome.Text;
                        dataTable = Turma.localizarTurmaInativaPorNome(nome);

                        F_ViewTurma viewTurma = new F_ViewTurma();

                        viewTurma.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewTurma.tbox_nomeTurma.Text = dataTable.Rows[0].Field<string>("DESC_TURMA").ToString();
                        viewTurma.tbox_idProfessor.Text = dataTable.Rows[0].Field<Int64>("ID_PROFESSOR").ToString();
                        viewTurma.tbox_professor.Text = dataTable.Rows[0].Field<string>("NOME_PROFESSOR").ToString();
                        viewTurma.tbox_idHorario.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                        viewTurma.tbox_horario.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                        viewTurma.tbox_limiteAlunos.Text = dataTable.Rows[0].Field<Int64>("LIMITE_ALUNOS").ToString();
                        viewTurma.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewTurma.ShowDialog();

                        this.Close();
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show("Nenhuma turma encontrada", "Aviso", MessageBoxButtons.OK);
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
                        dataTable = Turma.localizarTurmaAtivaPorNome(nome);

                        F_ViewTurma viewTurma = new F_ViewTurma();

                        viewTurma.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("CODIGO").ToString();
                        viewTurma.tbox_nomeTurma.Text = dataTable.Rows[0].Field<string>("DESC_TURMA").ToString();
                        viewTurma.tbox_idProfessor.Text = dataTable.Rows[0].Field<Int64>("ID_PROFESSOR").ToString();
                        viewTurma.tbox_professor.Text = dataTable.Rows[0].Field<string>("NOME_PROFESSOR").ToString();
                        viewTurma.tbox_idHorario.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                        viewTurma.tbox_horario.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                        viewTurma.tbox_limiteAlunos.Text = dataTable.Rows[0].Field<Int64>("LIMITE_ALUNOS").ToString();
                        viewTurma.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewTurma.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhuma turma encontrada", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }
    }
}
