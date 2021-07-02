namespace MyAcademy
{
    partial class F_CadUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.tbox_apelido = new System.Windows.Forms.TextBox();
            this.tbox_senha = new System.Windows.Forms.TextBox();
            this.cbox_acessoGestao = new System.Windows.Forms.ComboBox();
            this.cbox_financeiro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_configuracoes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox_database = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cbox_ativo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apelido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PERMISSÕES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Permite acesso ao Módulo Gestão";
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(21, 39);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(297, 20);
            this.tbox_nome.TabIndex = 8;
            // 
            // tbox_apelido
            // 
            this.tbox_apelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_apelido.Location = new System.Drawing.Point(21, 88);
            this.tbox_apelido.Name = "tbox_apelido";
            this.tbox_apelido.Size = new System.Drawing.Size(145, 20);
            this.tbox_apelido.TabIndex = 9;
            // 
            // tbox_senha
            // 
            this.tbox_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_senha.Location = new System.Drawing.Point(204, 88);
            this.tbox_senha.MaxLength = 20;
            this.tbox_senha.Name = "tbox_senha";
            this.tbox_senha.PasswordChar = '*';
            this.tbox_senha.Size = new System.Drawing.Size(114, 20);
            this.tbox_senha.TabIndex = 10;
            // 
            // cbox_acessoGestao
            // 
            this.cbox_acessoGestao.FormattingEnabled = true;
            this.cbox_acessoGestao.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_acessoGestao.Location = new System.Drawing.Point(21, 233);
            this.cbox_acessoGestao.Name = "cbox_acessoGestao";
            this.cbox_acessoGestao.Size = new System.Drawing.Size(96, 21);
            this.cbox_acessoGestao.TabIndex = 14;
            // 
            // cbox_financeiro
            // 
            this.cbox_financeiro.FormattingEnabled = true;
            this.cbox_financeiro.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_financeiro.Location = new System.Drawing.Point(21, 283);
            this.cbox_financeiro.Name = "cbox_financeiro";
            this.cbox_financeiro.Size = new System.Drawing.Size(96, 21);
            this.cbox_financeiro.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Permite acesso ao Módulo Financeiro";
            // 
            // cbox_configuracoes
            // 
            this.cbox_configuracoes.FormattingEnabled = true;
            this.cbox_configuracoes.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_configuracoes.Location = new System.Drawing.Point(21, 334);
            this.cbox_configuracoes.Name = "cbox_configuracoes";
            this.cbox_configuracoes.Size = new System.Drawing.Size(96, 21);
            this.cbox_configuracoes.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Permite acesso as Configurações";
            // 
            // cbox_database
            // 
            this.cbox_database.FormattingEnabled = true;
            this.cbox_database.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_database.Location = new System.Drawing.Point(21, 385);
            this.cbox_database.Name = "cbox_database";
            this.cbox_database.Size = new System.Drawing.Size(96, 21);
            this.cbox_database.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Permite acesso à Conf. do Banco de Dados";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(189, 432);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(129, 39);
            this.btn_salvar.TabIndex = 22;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(25, 432);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 39);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cbox_ativo
            // 
            this.cbox_ativo.Enabled = false;
            this.cbox_ativo.FormattingEnabled = true;
            this.cbox_ativo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_ativo.Location = new System.Drawing.Point(21, 136);
            this.cbox_ativo.Name = "cbox_ativo";
            this.cbox_ativo.Size = new System.Drawing.Size(96, 21);
            this.cbox_ativo.TabIndex = 25;
            this.cbox_ativo.Text = "Sim";
            // 
            // F_CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 488);
            this.Controls.Add(this.cbox_ativo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cbox_database);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbox_configuracoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbox_financeiro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox_acessoGestao);
            this.Controls.Add(this.tbox_senha);
            this.Controls.Add(this.tbox_apelido);
            this.Controls.Add(this.tbox_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.TextBox tbox_apelido;
        private System.Windows.Forms.TextBox tbox_senha;
        private System.Windows.Forms.ComboBox cbox_acessoGestao;
        private System.Windows.Forms.ComboBox cbox_financeiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox_configuracoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbox_database;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cbox_ativo;
    }
}