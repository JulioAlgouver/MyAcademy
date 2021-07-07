
namespace MyAcademy
{
    partial class F_PlanoContas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.viewPlanoContas = new System.Windows.Forms.TreeView();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_propriedades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.btn_propriedades);
            this.splitContainer1.Panel2.Controls.Add(this.btn_remover);
            this.splitContainer1.Panel2.Controls.Add(this.btn_adicionar);
            this.splitContainer1.Panel2.Controls.Add(this.viewPlanoContas);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // viewPlanoContas
            // 
            this.viewPlanoContas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewPlanoContas.Location = new System.Drawing.Point(189, 12);
            this.viewPlanoContas.Name = "viewPlanoContas";
            this.viewPlanoContas.Size = new System.Drawing.Size(599, 324);
            this.viewPlanoContas.TabIndex = 0;
            this.viewPlanoContas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.viewPlanoContas_AfterSelect);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_adicionar.Location = new System.Drawing.Point(21, 26);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(141, 41);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.DarkGray;
            this.btn_remover.FlatAppearance.BorderSize = 0;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_remover.Location = new System.Drawing.Point(21, 85);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(141, 41);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            // 
            // btn_propriedades
            // 
            this.btn_propriedades.BackColor = System.Drawing.Color.DarkGray;
            this.btn_propriedades.FlatAppearance.BorderSize = 0;
            this.btn_propriedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_propriedades.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            this.btn_propriedades.Location = new System.Drawing.Point(21, 145);
            this.btn_propriedades.Name = "btn_propriedades";
            this.btn_propriedades.Size = new System.Drawing.Size(141, 41);
            this.btn_propriedades.TabIndex = 3;
            this.btn_propriedades.Text = "Propriedades";
            this.btn_propriedades.UseVisualStyleBackColor = false;
            // 
            // F_PlanoContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_PlanoContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano de Contas";
            this.Load += new System.EventHandler(this.F_PlanoContas_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_propriedades;
        private System.Windows.Forms.Button btn_remover;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TreeView viewPlanoContas;
    }
}