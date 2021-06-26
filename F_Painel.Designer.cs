namespace MyAcademy
{
    partial class F_Painel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_apelidoUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_codigoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbox_led = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_database = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_gestao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_led)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lb_apelidoUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_codigoUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbox_led);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 34);
            this.panel1.TabIndex = 0;
            // 
            // lb_apelidoUsuario
            // 
            this.lb_apelidoUsuario.AutoSize = true;
            this.lb_apelidoUsuario.Location = new System.Drawing.Point(124, 12);
            this.lb_apelidoUsuario.Name = "lb_apelidoUsuario";
            this.lb_apelidoUsuario.Size = new System.Drawing.Size(16, 13);
            this.lb_apelidoUsuario.TabIndex = 4;
            this.lb_apelidoUsuario.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário:";
            // 
            // lb_codigoUsuario
            // 
            this.lb_codigoUsuario.AutoSize = true;
            this.lb_codigoUsuario.Location = new System.Drawing.Point(52, 12);
            this.lb_codigoUsuario.Name = "lb_codigoUsuario";
            this.lb_codigoUsuario.Size = new System.Drawing.Size(16, 13);
            this.lb_codigoUsuario.TabIndex = 2;
            this.lb_codigoUsuario.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // pbox_led
            // 
            this.pbox_led.Image = global::MyAcademy.Properties.Resources.led_red_off;
            this.pbox_led.InitialImage = null;
            this.pbox_led.Location = new System.Drawing.Point(711, 3);
            this.pbox_led.Name = "pbox_led";
            this.pbox_led.Size = new System.Drawing.Size(28, 28);
            this.pbox_led.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_led.TabIndex = 0;
            this.pbox_led.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btn_database
            // 
            this.btn_database.BackColor = System.Drawing.Color.Transparent;
            this.btn_database.BackgroundImage = global::MyAcademy.Properties.Resources.icon_database;
            this.btn_database.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_database.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_database.FlatAppearance.BorderSize = 0;
            this.btn_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_database.Location = new System.Drawing.Point(542, 97);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(101, 99);
            this.btn_database.TabIndex = 5;
            this.btn_database.UseVisualStyleBackColor = false;
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.Color.Transparent;
            this.btn_config.BackgroundImage = global::MyAcademy.Properties.Resources.icon_config;
            this.btn_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.FlatAppearance.BorderSize = 0;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Location = new System.Drawing.Point(393, 97);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(101, 99);
            this.btn_config.TabIndex = 4;
            this.btn_config.UseVisualStyleBackColor = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.BackColor = System.Drawing.Color.Transparent;
            this.btn_financeiro.BackgroundImage = global::MyAcademy.Properties.Resources.icon_financeiro;
            this.btn_financeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_financeiro.FlatAppearance.BorderSize = 0;
            this.btn_financeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_financeiro.Location = new System.Drawing.Point(235, 97);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(101, 99);
            this.btn_financeiro.TabIndex = 3;
            this.btn_financeiro.UseVisualStyleBackColor = false;
            this.btn_financeiro.Click += new System.EventHandler(this.btn_financeiro_Click);
            // 
            // btn_gestao
            // 
            this.btn_gestao.BackColor = System.Drawing.Color.Transparent;
            this.btn_gestao.BackgroundImage = global::MyAcademy.Properties.Resources.icon_gestão;
            this.btn_gestao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gestao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gestao.FlatAppearance.BorderSize = 0;
            this.btn_gestao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gestao.Location = new System.Drawing.Point(96, 97);
            this.btn_gestao.Name = "btn_gestao";
            this.btn_gestao.Size = new System.Drawing.Size(101, 99);
            this.btn_gestao.TabIndex = 2;
            this.btn_gestao.UseVisualStyleBackColor = false;
            this.btn_gestao.Click += new System.EventHandler(this.btn_gestao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gestão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Financeiro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Configurações";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Banco de dados";
            // 
            // F_Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 513);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_database);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_financeiro);
            this.Controls.Add(this.btn_gestao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAcademy - Painel v1.0";
            this.Load += new System.EventHandler(this.F_Painel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_led)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbox_led;
        public System.Windows.Forms.Label lb_apelidoUsuario;
        public System.Windows.Forms.Label lb_codigoUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btn_gestao;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}