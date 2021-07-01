
namespace MyAcademy
{
    partial class F_GridAlunosOnFormGestaoTurma
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
            this.gridAlunos = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_selecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAlunos
            // 
            this.gridAlunos.AllowUserToAddRows = false;
            this.gridAlunos.AllowUserToDeleteRows = false;
            this.gridAlunos.AllowUserToResizeColumns = false;
            this.gridAlunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlunos.EnableHeadersVisualStyles = false;
            this.gridAlunos.Location = new System.Drawing.Point(12, 12);
            this.gridAlunos.MultiSelect = false;
            this.gridAlunos.Name = "gridAlunos";
            this.gridAlunos.ReadOnly = true;
            this.gridAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridAlunos.RowHeadersVisible = false;
            this.gridAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlunos.Size = new System.Drawing.Size(445, 240);
            this.gridAlunos.TabIndex = 2;
            this.gridAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlunos_CellContentClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(73, 267);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 37);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Location = new System.Drawing.Point(245, 267);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(141, 37);
            this.btn_selecionar.TabIndex = 4;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // F_GridAlunosOnFormGestaoTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 316);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gridAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GridAlunosOnFormGestaoTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de aluno";
            this.Load += new System.EventHandler(this.F_GridAlunosOnFormGestaoTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridAlunos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_selecionar;
    }
}