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
    public partial class F_BuscaHorario : Form
    {
        public F_BuscaHorario()
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
                    F_GridHorarioOnFormBusca gridHorarios = new F_GridHorarioOnFormBusca();
                    gridHorarios.ShowDialog();
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
                        dataTable = Horario.localizarHorarioInativoPorID(id);

                        F_ViewHorario viewHorario = new F_ViewHorario();

                        viewHorario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                        viewHorario.tbox_descricao.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                        viewHorario.tbox_horaInicio.Text = dataTable.Rows[0].Field<string>("HORA_INICIO").ToString();
                        viewHorario.tbox_horaFim.Text = dataTable.Rows[0].Field<string>("HORA_FIM").ToString();
                        viewHorario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewHorario.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum horario encontrado", "Aviso", MessageBoxButtons.OK);
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
                        dataTable = Horario.localizarHorarioAtivoPorID(id);

                        F_ViewHorario viewHorario = new F_ViewHorario();

                        viewHorario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                        viewHorario.tbox_descricao.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                        viewHorario.tbox_horaInicio.Text = dataTable.Rows[0].Field<string>("HORA_INICIO").ToString();
                        viewHorario.tbox_horaFim.Text = dataTable.Rows[0].Field<string>("HORA_FIM").ToString();
                        viewHorario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewHorario.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum horario encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbox_nome.Text == "")
            {
                var result = MessageBox.Show("Nenhum parametro informado, deseja mostrar todos os registros?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    F_GridHorarioOnFormBusca gridHorarios = new F_GridHorarioOnFormBusca();
                    gridHorarios.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if(checkBox2.Checked == true)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        string nome = tbox_nome.Text;
                        dataTable = Horario.localizarHorarioInativoPorNome(nome);

                        F_ViewHorario viewHorario = new F_ViewHorario();

                        viewHorario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                        viewHorario.tbox_descricao.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                        viewHorario.tbox_horaInicio.Text = dataTable.Rows[0].Field<string>("HORA_INICIO").ToString();
                        viewHorario.tbox_horaFim.Text = dataTable.Rows[0].Field<string>("HORA_FIM").ToString();
                        viewHorario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewHorario.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum horario encontrado", "Aviso", MessageBoxButtons.OK);
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
                        dataTable = Horario.localizarHorarioAtivoPorNome(nome);

                        F_ViewHorario viewHorario = new F_ViewHorario();

                        viewHorario.tbox_codigo.Text = dataTable.Rows[0].Field<Int64>("ID_HORARIO").ToString();
                        viewHorario.tbox_descricao.Text = dataTable.Rows[0].Field<string>("DESC_HORARIO").ToString();
                        viewHorario.tbox_horaInicio.Text = dataTable.Rows[0].Field<string>("HORA_INICIO").ToString();
                        viewHorario.tbox_horaFim.Text = dataTable.Rows[0].Field<string>("HORA_FIM").ToString();
                        viewHorario.cbox_ativo.Text = dataTable.Rows[0].Field<string>("ATIVO").ToString();
                        viewHorario.ShowDialog();

                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nenhum horario encontrado", "Aviso", MessageBoxButtons.OK);
                        return;
                        throw error;
                    }
                }
            }
        }
    }
}
