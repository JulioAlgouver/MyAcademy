
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_bucarHorario = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 35;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(176, 82);
            this.maskedTextBox1.Mask = "(99) 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(126, 20);
            this.maskedTextBox1.TabIndex = 37;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(176, 130);
            this.maskedTextBox2.Mask = "(99) 00000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(126, 20);
            this.maskedTextBox2.TabIndex = 39;
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
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.comboBox1.Location = new System.Drawing.Point(231, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Text = "Sim";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 43;
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
            // 
            // F_CadProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 230);
            this.Controls.Add(this.btn_bucarHorario);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_bucarHorario;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
    }
}