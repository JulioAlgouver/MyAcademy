
namespace MyAcademy
{
    partial class F_CadConvenio
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
            this.cbox_ativo = new System.Windows.Forms.ComboBox();
            this.tbox_desconto = new System.Windows.Forms.TextBox();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(11, 126);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 39);
            this.btn_cancelar.TabIndex = 25;
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
            this.btn_salvar.Location = new System.Drawing.Point(175, 126);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(129, 39);
            this.btn_salvar.TabIndex = 24;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // cbox_ativo
            // 
            this.cbox_ativo.Enabled = false;
            this.cbox_ativo.FormattingEnabled = true;
            this.cbox_ativo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbox_ativo.Location = new System.Drawing.Point(210, 83);
            this.cbox_ativo.Name = "cbox_ativo";
            this.cbox_ativo.Size = new System.Drawing.Size(96, 21);
            this.cbox_ativo.TabIndex = 33;
            this.cbox_ativo.Text = "Sim";
            // 
            // tbox_desconto
            // 
            this.tbox_desconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_desconto.Location = new System.Drawing.Point(15, 83);
            this.tbox_desconto.Name = "tbox_desconto";
            this.tbox_desconto.Size = new System.Drawing.Size(67, 20);
            this.tbox_desconto.TabIndex = 31;
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(15, 34);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(290, 20);
            this.tbox_nome.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Desconto (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome";
            // 
            // F_CadConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 184);
            this.Controls.Add(this.cbox_ativo);
            this.Controls.Add(this.tbox_desconto);
            this.Controls.Add(this.tbox_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CadConvenio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Convênio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox cbox_ativo;
        private System.Windows.Forms.TextBox tbox_desconto;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}