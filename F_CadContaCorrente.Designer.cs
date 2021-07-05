
namespace MyAcademy
{
    partial class F_CadContaCorrente
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_descricao = new System.Windows.Forms.TextBox();
            this.tbox_banco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_agencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_contaCorrente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_saldoInicial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_cancelar.Location = new System.Drawing.Point(16, 241);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 45);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_salvar.Location = new System.Drawing.Point(135, 241);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(103, 45);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // tbox_descricao
            // 
            this.tbox_descricao.Location = new System.Drawing.Point(19, 30);
            this.tbox_descricao.Name = "tbox_descricao";
            this.tbox_descricao.Size = new System.Drawing.Size(219, 20);
            this.tbox_descricao.TabIndex = 3;
            // 
            // tbox_banco
            // 
            this.tbox_banco.Location = new System.Drawing.Point(19, 72);
            this.tbox_banco.Name = "tbox_banco";
            this.tbox_banco.Size = new System.Drawing.Size(103, 20);
            this.tbox_banco.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banco";
            // 
            // tbox_agencia
            // 
            this.tbox_agencia.Location = new System.Drawing.Point(19, 115);
            this.tbox_agencia.Name = "tbox_agencia";
            this.tbox_agencia.Size = new System.Drawing.Size(103, 20);
            this.tbox_agencia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Agência";
            // 
            // tbox_contaCorrente
            // 
            this.tbox_contaCorrente.Location = new System.Drawing.Point(19, 157);
            this.tbox_contaCorrente.Name = "tbox_contaCorrente";
            this.tbox_contaCorrente.Size = new System.Drawing.Size(103, 20);
            this.tbox_contaCorrente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conta Corrente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo Inicial (R$)";
            // 
            // tbox_saldoInicial
            // 
            this.tbox_saldoInicial.Location = new System.Drawing.Point(19, 198);
            this.tbox_saldoInicial.Name = "tbox_saldoInicial";
            this.tbox_saldoInicial.Size = new System.Drawing.Size(75, 20);
            this.tbox_saldoInicial.TabIndex = 13;
            // 
            // F_CadContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 299);
            this.Controls.Add(this.tbox_saldoInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_contaCorrente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_agencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_banco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CadContaCorrente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Conta Corrente";
            this.Load += new System.EventHandler(this.F_CadContaCorrente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbox_descricao;
        public System.Windows.Forms.TextBox tbox_banco;
        public System.Windows.Forms.TextBox tbox_agencia;
        public System.Windows.Forms.TextBox tbox_contaCorrente;
        private System.Windows.Forms.TextBox tbox_saldoInicial;
    }
}