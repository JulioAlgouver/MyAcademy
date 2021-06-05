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
    public partial class F_Gestao : Form
    {
        F_GridHorarios GridHorarios;
        F_CadProfessor FormCadProfessor;

        public F_Gestao(F_GridHorarios gridHorarios, F_CadProfessor cadProfessor)
        {
            InitializeComponent();

            GridHorarios = gridHorarios;
            FormCadProfessor = cadProfessor;
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CadUsuario cadUsuario = new F_CadUsuario();
            cadUsuario.ShowDialog();
        }

        private void consultarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_BuscaUsuario buscaUsuario = new F_BuscaUsuario();
            buscaUsuario.ShowDialog();
        }

        private void cadastrarNovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_CadConvenio cadConvenio = new F_CadConvenio();
            cadConvenio.ShowDialog();
        }

        private void cadastrarNovoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_CadTurma cadTurma = new F_CadTurma(GridHorarios, FormCadProfessor);
            cadTurma.ShowDialog();
        }

        private void cadastrarNovoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F_CadProfessor cadProfessor = new F_CadProfessor(GridHorarios);
            cadProfessor.ShowDialog();
        }

        private void cadastrarNovoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            F_CadAluno cadAluno = new F_CadAluno();
            cadAluno.ShowDialog();
        }

        private void novoHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CadHorario cadHorario = new F_CadHorario();
            cadHorario.ShowDialog();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Calendar calendar = new F_Calendar();
            calendar.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Calc calculadora = new F_Calc();
            calculadora.ShowDialog();
        }
    }
}
