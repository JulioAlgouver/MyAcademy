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
    public partial class F_GestãoContas : Form
    {
        public F_GestãoContas()
        {
            InitializeComponent();
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            F_NovaConta novaConta = new F_NovaConta();
            novaConta.ShowDialog();
        }
    }
}
