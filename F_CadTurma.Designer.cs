
namespace MyAcademy
{
    partial class F_CadTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CadTurma));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_nomeTurma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_limiteAlunos = new System.Windows.Forms.TextBox();
            this.tbox_professor = new System.Windows.Forms.TextBox();
            this.cbox_ativo = new System.Windows.Forms.ComboBox();
            this.tbox_horario = new System.Windows.Forms.TextBox();
            this.tbox_idHorario = new System.Windows.Forms.TextBox();
            this.tbox_idProfessor = new System.Windows.Forms.TextBox();
            this.btn_bucarHorario = new System.Windows.Forms.Button();
            this.btn_buscarProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(15, 175);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 39);
            this.btn_cancelar.TabIndex = 27;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(179, 175);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(126, 39);
            this.btn_salvar.TabIndex = 26;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descrição";
            // 
            // tbox_nomeTurma
            // 
            this.tbox_nomeTurma.Location = new System.Drawing.Point(15, 35);
            this.tbox_nomeTurma.Name = "tbox_nomeTurma";
            this.tbox_nomeTurma.Size = new System.Drawing.Size(290, 20);
            this.tbox_nomeTurma.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Limite de alunos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Horario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ativo";
            // 
            // tbox_limiteAlunos
            // 
            this.tbox_limiteAlunos.Location = new System.Drawing.Point(225, 84);
            this.tbox_limiteAlunos.MaxLength = 3;
            this.tbox_limiteAlunos.Name = "tbox_limiteAlunos";
            this.tbox_limiteAlunos.Size = new System.Drawing.Size(80, 20);
            this.tbox_limiteAlunos.TabIndex = 34;
            // 
            // tbox_professor
            // 
            this.tbox_professor.Location = new System.Drawing.Point(15, 84);
            this.tbox_professor.Name = "tbox_professor";
            this.tbox_professor.ReadOnly = true;
            this.tbox_professor.Size = new System.Drawing.Size(158, 20);
            this.tbox_professor.TabIndex = 35;
            // 
            // cbox_ativo
            // 
            this.cbox_ativo.Enabled = false;
            this.cbox_ativo.FormattingEnabled = true;
            this.cbox_ativo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_ativo.Location = new System.Drawing.Point(225, 131);
            this.cbox_ativo.Name = "cbox_ativo";
            this.cbox_ativo.Size = new System.Drawing.Size(80, 21);
            this.cbox_ativo.TabIndex = 36;
            this.cbox_ativo.Text = "Sim";
            // 
            // tbox_horario
            // 
            this.tbox_horario.Location = new System.Drawing.Point(15, 131);
            this.tbox_horario.Name = "tbox_horario";
            this.tbox_horario.ReadOnly = true;
            this.tbox_horario.Size = new System.Drawing.Size(158, 20);
            this.tbox_horario.TabIndex = 38;
            // 
            // tbox_idHorario
            // 
            this.tbox_idHorario.Location = new System.Drawing.Point(15, 131);
            this.tbox_idHorario.Name = "tbox_idHorario";
            this.tbox_idHorario.Size = new System.Drawing.Size(20, 20);
            this.tbox_idHorario.TabIndex = 40;
            this.tbox_idHorario.Visible = false;
            // 
            // tbox_idProfessor
            // 
            this.tbox_idProfessor.Location = new System.Drawing.Point(15, 84);
            this.tbox_idProfessor.Name = "tbox_idProfessor";
            this.tbox_idProfessor.Size = new System.Drawing.Size(20, 20);
            this.tbox_idProfessor.TabIndex = 41;
            this.tbox_idProfessor.Visible = false;
            // 
            // btn_bucarHorario
            // 
            this.btn_bucarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bucarHorario.BackgroundImage")));
            this.btn_bucarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bucarHorario.FlatAppearance.BorderSize = 0;
            this.btn_bucarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bucarHorario.Location = new System.Drawing.Point(175, 131);
            this.btn_bucarHorario.Name = "btn_bucarHorario";
            this.btn_bucarHorario.Size = new System.Drawing.Size(20, 20);
            this.btn_bucarHorario.TabIndex = 39;
            this.btn_bucarHorario.UseVisualStyleBackColor = true;
            this.btn_bucarHorario.Click += new System.EventHandler(this.btn_bucarHorario_Click);
            // 
            // btn_buscarProfessor
            // 
            this.btn_buscarProfessor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarProfessor.BackgroundImage")));
            this.btn_buscarProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarProfessor.FlatAppearance.BorderSize = 0;
            this.btn_buscarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscarProfessor.Location = new System.Drawing.Point(175, 84);
            this.btn_buscarProfessor.Name = "btn_buscarProfessor";
            this.btn_buscarProfessor.Size = new System.Drawing.Size(20, 21);
            this.btn_buscarProfessor.TabIndex = 37;
            this.btn_buscarProfessor.UseVisualStyleBackColor = true;
            this.btn_buscarProfessor.Click += new System.EventHandler(this.btn_buscarProfessor_Click);
            // 
            // F_CadTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 227);
            this.Controls.Add(this.tbox_idProfessor);
            this.Controls.Add(this.tbox_idHorario);
            this.Controls.Add(this.btn_bucarHorario);
            this.Controls.Add(this.tbox_horario);
            this.Controls.Add(this.btn_buscarProfessor);
            this.Controls.Add(this.cbox_ativo);
            this.Controls.Add(this.tbox_professor);
            this.Controls.Add(this.tbox_limiteAlunos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_nomeTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CadTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_nomeTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_limiteAlunos;
        private System.Windows.Forms.ComboBox cbox_ativo;
        private System.Windows.Forms.Button btn_buscarProfessor;
        private System.Windows.Forms.Button btn_bucarHorario;
        public System.Windows.Forms.TextBox tbox_horario;
        public System.Windows.Forms.TextBox tbox_idHorario;
        public System.Windows.Forms.TextBox tbox_idProfessor;
        public System.Windows.Forms.TextBox tbox_professor;
    }
}