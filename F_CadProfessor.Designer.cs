
namespace MyAcademy
{
    partial class F_CadProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CadProfessor));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_especialidade = new System.Windows.Forms.TextBox();
            this.tbox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tbox_celular = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_ativo = new System.Windows.Forms.ComboBox();
            this.tbox_horario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_bucarHorario = new System.Windows.Forms.Button();
            this.tbox_idHorario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 171);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 39);
            this.btn_cancelar.TabIndex = 29;
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
            this.btn_salvar.Location = new System.Drawing.Point(176, 171);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(126, 39);
            this.btn_salvar.TabIndex = 28;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(15, 34);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(197, 20);
            this.tbox_nome.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Especialidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Telefone";
            // 
            // tbox_especialidade
            // 
            this.tbox_especialidade.Location = new System.Drawing.Point(15, 82);
            this.tbox_especialidade.Name = "tbox_especialidade";
            this.tbox_especialidade.Size = new System.Drawing.Size(147, 20);
            this.tbox_especialidade.TabIndex = 35;
            // 
            // tbox_telefone
            // 
            this.tbox_telefone.Location = new System.Drawing.Point(176, 82);
            this.tbox_telefone.Mask = "(99) 0000-0000";
            this.tbox_telefone.Name = "tbox_telefone";
            this.tbox_telefone.Size = new System.Drawing.Size(126, 20);
            this.tbox_telefone.TabIndex = 37;
            // 
            // tbox_celular
            // 
            this.tbox_celular.Location = new System.Drawing.Point(176, 130);
            this.tbox_celular.Mask = "(99) 00000-0000";
            this.tbox_celular.Name = "tbox_celular";
            this.tbox_celular.Size = new System.Drawing.Size(126, 20);
            this.tbox_celular.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ativo";
            // 
            // cbox_ativo
            // 
            this.cbox_ativo.Enabled = false;
            this.cbox_ativo.FormattingEnabled = true;
            this.cbox_ativo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_ativo.Location = new System.Drawing.Point(231, 33);
            this.cbox_ativo.Name = "cbox_ativo";
            this.cbox_ativo.Size = new System.Drawing.Size(71, 21);
            this.cbox_ativo.TabIndex = 41;
            this.cbox_ativo.Text = "Sim";
            // 
            // tbox_horario
            // 
            this.tbox_horario.Location = new System.Drawing.Point(15, 130);
            this.tbox_horario.Name = "tbox_horario";
            this.tbox_horario.ReadOnly = true;
            this.tbox_horario.Size = new System.Drawing.Size(128, 20);
            this.tbox_horario.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Horario";
            // 
            // btn_bucarHorario
            // 
            this.btn_bucarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bucarHorario.BackgroundImage")));
            this.btn_bucarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bucarHorario.FlatAppearance.BorderSize = 0;
            this.btn_bucarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bucarHorario.Location = new System.Drawing.Point(142, 130);
            this.btn_bucarHorario.Name = "btn_bucarHorario";
            this.btn_bucarHorario.Size = new System.Drawing.Size(20, 20);
            this.btn_bucarHorario.TabIndex = 44;
            this.btn_bucarHorario.UseVisualStyleBackColor = true;
            this.btn_bucarHorario.Click += new System.EventHandler(this.btn_bucarHorario_Click);
            // 
            // tbox_idHorario
            // 
            this.tbox_idHorario.Location = new System.Drawing.Point(15, 130);
            this.tbox_idHorario.Name = "tbox_idHorario";
            this.tbox_idHorario.ReadOnly = true;
            this.tbox_idHorario.Size = new System.Drawing.Size(10, 20);
            this.tbox_idHorario.TabIndex = 45;
            this.tbox_idHorario.Visible = false;
            // 
            // F_CadProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 224);
            this.Controls.Add(this.tbox_idHorario);
            this.Controls.Add(this.btn_bucarHorario);
            this.Controls.Add(this.tbox_horario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbox_ativo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_celular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_telefone);
            this.Controls.Add(this.tbox_especialidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CadProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_especialidade;
        private System.Windows.Forms.MaskedTextBox tbox_telefone;
        private System.Windows.Forms.MaskedTextBox tbox_celular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_ativo;
        private System.Windows.Forms.Button btn_bucarHorario;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbox_horario;
        public System.Windows.Forms.TextBox tbox_idHorario;
    }
}