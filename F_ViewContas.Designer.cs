
namespace MyAcademy
{
    partial class F_ViewContas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbox_saldoInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_contaCorrente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_agencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_banco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_saldoAtual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridContasCorrente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridContasCorrente)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_saldoInicial
            // 
            this.tbox_saldoInicial.Enabled = false;
            this.tbox_saldoInicial.Location = new System.Drawing.Point(15, 300);
            this.tbox_saldoInicial.Name = "tbox_saldoInicial";
            this.tbox_saldoInicial.ReadOnly = true;
            this.tbox_saldoInicial.Size = new System.Drawing.Size(75, 20);
            this.tbox_saldoInicial.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Saldo Inicial (R$)";
            // 
            // tbox_contaCorrente
            // 
            this.tbox_contaCorrente.Location = new System.Drawing.Point(15, 259);
            this.tbox_contaCorrente.Name = "tbox_contaCorrente";
            this.tbox_contaCorrente.Size = new System.Drawing.Size(103, 20);
            this.tbox_contaCorrente.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Conta Corrente";
            // 
            // tbox_agencia
            // 
            this.tbox_agencia.Location = new System.Drawing.Point(15, 217);
            this.tbox_agencia.Name = "tbox_agencia";
            this.tbox_agencia.Size = new System.Drawing.Size(103, 20);
            this.tbox_agencia.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Agência";
            // 
            // tbox_banco
            // 
            this.tbox_banco.Location = new System.Drawing.Point(15, 174);
            this.tbox_banco.Name = "tbox_banco";
            this.tbox_banco.Size = new System.Drawing.Size(103, 20);
            this.tbox_banco.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Banco";
            // 
            // tbox_descricao
            // 
            this.tbox_descricao.Location = new System.Drawing.Point(15, 132);
            this.tbox_descricao.Name = "tbox_descricao";
            this.tbox_descricao.Size = new System.Drawing.Size(219, 20);
            this.tbox_descricao.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descrição";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_salvar.Location = new System.Drawing.Point(131, 343);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(103, 45);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_cancelar.Location = new System.Drawing.Point(12, 343);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 45);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Selecione uma conta corrente:";
            // 
            // tbox_saldoAtual
            // 
            this.tbox_saldoAtual.Enabled = false;
            this.tbox_saldoAtual.Location = new System.Drawing.Point(131, 300);
            this.tbox_saldoAtual.Name = "tbox_saldoAtual";
            this.tbox_saldoAtual.ReadOnly = true;
            this.tbox_saldoAtual.Size = new System.Drawing.Size(75, 20);
            this.tbox_saldoAtual.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Saldo Atual (R$)";
            // 
            // gridContasCorrente
            // 
            this.gridContasCorrente.AllowUserToAddRows = false;
            this.gridContasCorrente.AllowUserToDeleteRows = false;
            this.gridContasCorrente.AllowUserToResizeColumns = false;
            this.gridContasCorrente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContasCorrente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridContasCorrente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContasCorrente.Enabled = false;
            this.gridContasCorrente.Location = new System.Drawing.Point(14, 33);
            this.gridContasCorrente.MultiSelect = false;
            this.gridContasCorrente.Name = "gridContasCorrente";
            this.gridContasCorrente.ReadOnly = true;
            this.gridContasCorrente.RowHeadersVisible = false;
            this.gridContasCorrente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridContasCorrente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContasCorrente.ShowCellErrors = false;
            this.gridContasCorrente.ShowCellToolTips = false;
            this.gridContasCorrente.ShowEditingIcon = false;
            this.gridContasCorrente.ShowRowErrors = false;
            this.gridContasCorrente.Size = new System.Drawing.Size(220, 68);
            this.gridContasCorrente.TabIndex = 30;
            this.gridContasCorrente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContasCorrente_CellContentClick);
            // 
            // F_ViewContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 400);
            this.Controls.Add(this.gridContasCorrente);
            this.Controls.Add(this.tbox_saldoAtual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Name = "F_ViewContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Correntes";
            this.Load += new System.EventHandler(this.F_ViewContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContasCorrente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbox_contaCorrente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbox_agencia;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbox_banco;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbox_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbox_saldoInicial;
        public System.Windows.Forms.TextBox tbox_saldoAtual;
        public System.Windows.Forms.DataGridView gridContasCorrente;
    }
}