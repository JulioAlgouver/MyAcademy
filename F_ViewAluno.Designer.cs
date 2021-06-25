
namespace MyAcademy
{
    partial class F_ViewAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ViewAluno));
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_idConvenio = new System.Windows.Forms.TextBox();
            this.cbox_possuiConvenio = new System.Windows.Forms.ComboBox();
            this.PossuiConvenio = new System.Windows.Forms.Label();
            this.tbox_convenio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_celular = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_ativo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_bucarHorario = new System.Windows.Forms.Button();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "ID";
            this.label2.Visible = false;
            // 
            // tbox_idConvenio
            // 
            this.tbox_idConvenio.Location = new System.Drawing.Point(125, 120);
            this.tbox_idConvenio.Name = "tbox_idConvenio";
            this.tbox_idConvenio.ReadOnly = true;
            this.tbox_idConvenio.Size = new System.Drawing.Size(28, 20);
            this.tbox_idConvenio.TabIndex = 74;
            this.tbox_idConvenio.Visible = false;
            // 
            // cbox_possuiConvenio
            // 
            this.cbox_possuiConvenio.FormattingEnabled = true;
            this.cbox_possuiConvenio.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_possuiConvenio.Location = new System.Drawing.Point(12, 118);
            this.cbox_possuiConvenio.Name = "cbox_possuiConvenio";
            this.cbox_possuiConvenio.Size = new System.Drawing.Size(71, 21);
            this.cbox_possuiConvenio.TabIndex = 73;
            this.cbox_possuiConvenio.Text = "Sim";
            // 
            // PossuiConvenio
            // 
            this.PossuiConvenio.AutoSize = true;
            this.PossuiConvenio.Location = new System.Drawing.Point(9, 103);
            this.PossuiConvenio.Name = "PossuiConvenio";
            this.PossuiConvenio.Size = new System.Drawing.Size(85, 13);
            this.PossuiConvenio.TabIndex = 72;
            this.PossuiConvenio.Text = "Possui convenio";
            // 
            // tbox_convenio
            // 
            this.tbox_convenio.Location = new System.Drawing.Point(152, 120);
            this.tbox_convenio.Name = "tbox_convenio";
            this.tbox_convenio.ReadOnly = true;
            this.tbox_convenio.Size = new System.Drawing.Size(126, 20);
            this.tbox_convenio.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Nome do convênio";
            // 
            // tbox_celular
            // 
            this.tbox_celular.Location = new System.Drawing.Point(173, 168);
            this.tbox_celular.Mask = "(99) 00000-0000";
            this.tbox_celular.Name = "tbox_celular";
            this.tbox_celular.Size = new System.Drawing.Size(126, 20);
            this.tbox_celular.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Celular";
            // 
            // tbox_telefone
            // 
            this.tbox_telefone.Location = new System.Drawing.Point(12, 168);
            this.tbox_telefone.Mask = "(99) 0000-0000";
            this.tbox_telefone.Name = "tbox_telefone";
            this.tbox_telefone.Size = new System.Drawing.Size(126, 20);
            this.tbox_telefone.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Telefone";
            // 
            // cbox_ativo
            // 
            this.cbox_ativo.FormattingEnabled = true;
            this.cbox_ativo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_ativo.Location = new System.Drawing.Point(228, 70);
            this.cbox_ativo.Name = "cbox_ativo";
            this.cbox_ativo.Size = new System.Drawing.Size(71, 21);
            this.cbox_ativo.TabIndex = 64;
            this.cbox_ativo.Text = "Sim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ativo";
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(12, 71);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(197, 20);
            this.tbox_nome.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nome";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(9, 209);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 39);
            this.btn_cancelar.TabIndex = 60;
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
            this.btn_salvar.Location = new System.Drawing.Point(173, 209);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(126, 39);
            this.btn_salvar.TabIndex = 59;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_bucarHorario
            // 
            this.btn_bucarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bucarHorario.BackgroundImage")));
            this.btn_bucarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bucarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bucarHorario.FlatAppearance.BorderSize = 0;
            this.btn_bucarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bucarHorario.Location = new System.Drawing.Point(279, 120);
            this.btn_bucarHorario.Name = "btn_bucarHorario";
            this.btn_bucarHorario.Size = new System.Drawing.Size(20, 20);
            this.btn_bucarHorario.TabIndex = 71;
            this.btn_bucarHorario.UseVisualStyleBackColor = true;
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Enabled = false;
            this.tbox_codigo.Location = new System.Drawing.Point(12, 27);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.ReadOnly = true;
            this.tbox_codigo.Size = new System.Drawing.Size(82, 20);
            this.tbox_codigo.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Código";
            // 
            // F_ViewAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 262);
            this.Controls.Add(this.tbox_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_idConvenio);
            this.Controls.Add(this.cbox_possuiConvenio);
            this.Controls.Add(this.PossuiConvenio);
            this.Controls.Add(this.btn_bucarHorario);
            this.Controls.Add(this.tbox_convenio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_celular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_telefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbox_ativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ViewAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbox_idConvenio;
        private System.Windows.Forms.Label PossuiConvenio;
        private System.Windows.Forms.Button btn_bucarHorario;
        public System.Windows.Forms.TextBox tbox_convenio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbox_codigo;
        public System.Windows.Forms.ComboBox cbox_possuiConvenio;
        public System.Windows.Forms.MaskedTextBox tbox_celular;
        public System.Windows.Forms.MaskedTextBox tbox_telefone;
        public System.Windows.Forms.ComboBox cbox_ativo;
        public System.Windows.Forms.TextBox tbox_nome;
    }
}