
namespace MyAcademy
{
    partial class F_CadPlanoContas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_receita = new System.Windows.Forms.RadioButton();
            this.radio_despesa = new System.Windows.Forms.RadioButton();
            this.radio_grupo = new System.Windows.Forms.RadioButton();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.button1.Location = new System.Drawing.Point(59, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.button2.Location = new System.Drawing.Point(200, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // tbox_descricao
            // 
            this.tbox_descricao.Location = new System.Drawing.Point(15, 71);
            this.tbox_descricao.Name = "tbox_descricao";
            this.tbox_descricao.Size = new System.Drawing.Size(354, 20);
            this.tbox_descricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            // 
            // radio_receita
            // 
            this.radio_receita.AutoSize = true;
            this.radio_receita.Location = new System.Drawing.Point(112, 103);
            this.radio_receita.Name = "radio_receita";
            this.radio_receita.Size = new System.Drawing.Size(62, 17);
            this.radio_receita.TabIndex = 5;
            this.radio_receita.TabStop = true;
            this.radio_receita.Text = "Receita";
            this.radio_receita.UseVisualStyleBackColor = true;
            // 
            // radio_despesa
            // 
            this.radio_despesa.AutoSize = true;
            this.radio_despesa.Location = new System.Drawing.Point(213, 103);
            this.radio_despesa.Name = "radio_despesa";
            this.radio_despesa.Size = new System.Drawing.Size(67, 17);
            this.radio_despesa.TabIndex = 6;
            this.radio_despesa.TabStop = true;
            this.radio_despesa.Text = "Despesa";
            this.radio_despesa.UseVisualStyleBackColor = true;
            // 
            // radio_grupo
            // 
            this.radio_grupo.AutoSize = true;
            this.radio_grupo.Location = new System.Drawing.Point(314, 103);
            this.radio_grupo.Name = "radio_grupo";
            this.radio_grupo.Size = new System.Drawing.Size(54, 17);
            this.radio_grupo.TabIndex = 7;
            this.radio_grupo.TabStop = true;
            this.radio_grupo.Text = "Grupo";
            this.radio_grupo.UseVisualStyleBackColor = true;
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Enabled = false;
            this.tbox_codigo.Location = new System.Drawing.Point(15, 26);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.ReadOnly = true;
            this.tbox_codigo.Size = new System.Drawing.Size(161, 20);
            this.tbox_codigo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código";
            // 
            // F_CadPlanoContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 197);
            this.Controls.Add(this.tbox_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radio_grupo);
            this.Controls.Add(this.radio_despesa);
            this.Controls.Add(this.radio_receita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CadPlanoContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Plano de Contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_receita;
        private System.Windows.Forms.RadioButton radio_despesa;
        private System.Windows.Forms.RadioButton radio_grupo;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.Label label3;
    }
}