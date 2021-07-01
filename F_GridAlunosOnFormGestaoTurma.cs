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
    public partial class F_GridAlunosOnFormGestaoTurma : Form
    {
        int idAlunoSelecionado;
        string nomeAlunoSelecionado;

        F_GestãoTurmas FormGestaoTurmas;

        public F_GridAlunosOnFormGestaoTurma(F_GestãoTurmas gestaoTurmas)
        {
            InitializeComponent();

            FormGestaoTurmas = gestaoTurmas;
        }

        private void F_GridAlunosOnFormGestaoTurma_Load(object sender, EventArgs e)
        {
            gridAlunos.DataSource = Aluno.listaAlunos();

            gridAlunos.Columns[0].Width = 50;
            gridAlunos.Columns[1].Width = 200;
            gridAlunos.Columns[2].Width = 110;
            gridAlunos.Columns[3].Width = 82;
        }
        private void gridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idAlunoSelecionado = Int32.Parse(gridAlunos.Rows[0].Cells[0].Value.ToString());
            nomeAlunoSelecionado = gridAlunos.Rows[0].Cells[1].Value.ToString();
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            Aluno aluno = new Aluno();
            aluno.id_turma = ;
            aluno.desc_turma = ;
            aluno.id_aluno = idAlunoSelecionado;
            aluno.nome_aluno = nomeAlunoSelecionado;
            Aluno.matricularAluno(aluno);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
