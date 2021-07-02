
namespace MyAcademy
{
    partial class F_GestãoContas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 45);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(9, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_adicionar);
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nova Conta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.btn_localizar);
            this.tabPage2.Location = new System.Drawing.Point(4, 49);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Contas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_adicionar.Location = new System.Drawing.Point(104, 97);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(169, 56);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar Conta";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_localizar
            // 
            this.btn_localizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_localizar.FlatAppearance.BorderSize = 0;
            this.btn_localizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_localizar.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_localizar.Location = new System.Drawing.Point(206, 173);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(121, 48);
            this.btn_localizar.TabIndex = 0;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_cancelar.Location = new System.Drawing.Point(55, 173);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(121, 48);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // F_GestãoContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 316);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestãoContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Contas (Pagar/Receber)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_adicionar;
    }
}