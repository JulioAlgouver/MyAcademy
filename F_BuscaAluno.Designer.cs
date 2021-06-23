
namespace MyAcademy
{
    partial class F_BuscaAluno
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tab_codigoUsuario = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_nomeUsuario = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_apelidoUsuario = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tbox_apelido = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.tab_codigoUsuario.SuspendLayout();
            this.tab_nomeUsuario.SuspendLayout();
            this.tab_apelidoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione o tipo de busca a ser realizada:";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tab_codigoUsuario);
            this.TabControl1.Controls.Add(this.tab_nomeUsuario);
            this.TabControl1.Controls.Add(this.tab_apelidoUsuario);
            this.TabControl1.Location = new System.Drawing.Point(18, 42);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(330, 159);
            this.TabControl1.TabIndex = 6;
            // 
            // tab_codigoUsuario
            // 
            this.tab_codigoUsuario.Controls.Add(this.checkBox1);
            this.tab_codigoUsuario.Controls.Add(this.tbox_codigo);
            this.tab_codigoUsuario.Controls.Add(this.button1);
            this.tab_codigoUsuario.Controls.Add(this.label2);
            this.tab_codigoUsuario.Location = new System.Drawing.Point(4, 22);
            this.tab_codigoUsuario.Name = "tab_codigoUsuario";
            this.tab_codigoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_codigoUsuario.Size = new System.Drawing.Size(322, 133);
            this.tab_codigoUsuario.TabIndex = 0;
            this.tab_codigoUsuario.Text = "Código";
            this.tab_codigoUsuario.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Exibir cadastros inativos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Location = new System.Drawing.Point(23, 40);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.Size = new System.Drawing.Size(276, 20);
            this.tbox_codigo.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Por favor, informe o código do aluno:";
            // 
            // tab_nomeUsuario
            // 
            this.tab_nomeUsuario.Controls.Add(this.checkBox2);
            this.tab_nomeUsuario.Controls.Add(this.tbox_nome);
            this.tab_nomeUsuario.Controls.Add(this.button2);
            this.tab_nomeUsuario.Controls.Add(this.label3);
            this.tab_nomeUsuario.Location = new System.Drawing.Point(4, 22);
            this.tab_nomeUsuario.Name = "tab_nomeUsuario";
            this.tab_nomeUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_nomeUsuario.Size = new System.Drawing.Size(322, 133);
            this.tab_nomeUsuario.TabIndex = 1;
            this.tab_nomeUsuario.Text = "Nome";
            this.tab_nomeUsuario.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(139, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Exibir cadastros inativos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(23, 40);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(276, 20);
            this.tbox_nome.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Por favor, informe o nome do aluno:";
            // 
            // tab_apelidoUsuario
            // 
            this.tab_apelidoUsuario.Controls.Add(this.checkBox3);
            this.tab_apelidoUsuario.Controls.Add(this.tbox_apelido);
            this.tab_apelidoUsuario.Controls.Add(this.button3);
            this.tab_apelidoUsuario.Controls.Add(this.label4);
            this.tab_apelidoUsuario.Location = new System.Drawing.Point(4, 22);
            this.tab_apelidoUsuario.Name = "tab_apelidoUsuario";
            this.tab_apelidoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_apelidoUsuario.Size = new System.Drawing.Size(322, 133);
            this.tab_apelidoUsuario.TabIndex = 2;
            this.tab_apelidoUsuario.Text = "Apelido";
            this.tab_apelidoUsuario.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 64);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(139, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Exibir cadastros inativos";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tbox_apelido
            // 
            this.tbox_apelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_apelido.Location = new System.Drawing.Point(23, 40);
            this.tbox_apelido.Name = "tbox_apelido";
            this.tbox_apelido.Size = new System.Drawing.Size(276, 20);
            this.tbox_apelido.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Por favor, informe o apelido do aluno:";
            // 
            // F_BuscaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_BuscaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Aluno";
            this.TabControl1.ResumeLayout(false);
            this.tab_codigoUsuario.ResumeLayout(false);
            this.tab_codigoUsuario.PerformLayout();
            this.tab_nomeUsuario.ResumeLayout(false);
            this.tab_nomeUsuario.PerformLayout();
            this.tab_apelidoUsuario.ResumeLayout(false);
            this.tab_apelidoUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tab_codigoUsuario;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab_nomeUsuario;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tab_apelidoUsuario;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox tbox_apelido;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}