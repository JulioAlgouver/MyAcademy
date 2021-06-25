
namespace MyAcademy
{
    partial class F_ViewHorario
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
            this.tbox_horaFim = new System.Windows.Forms.MaskedTextBox();
            this.tbox_horaInicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_ativo = new System.Windows.Forms.ComboBox();
            this.tbox_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox_horaFim
            // 
            this.tbox_horaFim.Location = new System.Drawing.Point(102, 125);
            this.tbox_horaFim.Mask = "90:00";
            this.tbox_horaFim.Name = "tbox_horaFim";
            this.tbox_horaFim.Size = new System.Drawing.Size(63, 20);
            this.tbox_horaFim.TabIndex = 55;
            this.tbox_horaFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_horaFim.ValidatingType = typeof(System.DateTime);
            // 
            // tbox_horaInicio
            // 
            this.tbox_horaInicio.Location = new System.Drawing.Point(15, 125);
            this.tbox_horaInicio.Mask = "90:00";
            this.tbox_horaInicio.Name = "tbox_horaInicio";
            this.tbox_horaInicio.Size = new System.Drawing.Size(65, 20);
            this.tbox_horaInicio.TabIndex = 54;
            this.tbox_horaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_horaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Horario Fim";
            // 
            // cbox_ativo
            // 
            this.cbox_ativo.Enabled = false;
            this.cbox_ativo.FormattingEnabled = true;
            this.cbox_ativo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_ativo.Location = new System.Drawing.Point(210, 125);
            this.cbox_ativo.Name = "cbox_ativo";
            this.cbox_ativo.Size = new System.Drawing.Size(96, 21);
            this.cbox_ativo.TabIndex = 52;
            this.cbox_ativo.Text = "Sim";
            // 
            // tbox_descricao
            // 
            this.tbox_descricao.Location = new System.Drawing.Point(15, 76);
            this.tbox_descricao.Name = "tbox_descricao";
            this.tbox_descricao.Size = new System.Drawing.Size(290, 20);
            this.tbox_descricao.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Horário inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Descrição";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(11, 168);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 39);
            this.btn_cancelar.TabIndex = 47;
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
            this.btn_salvar.Location = new System.Drawing.Point(175, 168);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(129, 39);
            this.btn_salvar.TabIndex = 46;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Enabled = false;
            this.tbox_codigo.Location = new System.Drawing.Point(15, 30);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.ReadOnly = true;
            this.tbox_codigo.Size = new System.Drawing.Size(65, 20);
            this.tbox_codigo.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Código";
            // 
            // F_ViewHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 224);
            this.Controls.Add(this.tbox_codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_horaFim);
            this.Controls.Add(this.tbox_horaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_ativo);
            this.Controls.Add(this.tbox_descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ViewHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox tbox_horaFim;
        public System.Windows.Forms.MaskedTextBox tbox_horaInicio;
        public System.Windows.Forms.ComboBox cbox_ativo;
        public System.Windows.Forms.TextBox tbox_descricao;
        public System.Windows.Forms.TextBox tbox_codigo;
    }
}