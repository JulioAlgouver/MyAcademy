
namespace MyAcademy
{
    partial class F_GridProfessores
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
            this.gridProfessores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfessores
            // 
            this.gridProfessores.AllowUserToAddRows = false;
            this.gridProfessores.AllowUserToDeleteRows = false;
            this.gridProfessores.AllowUserToResizeColumns = false;
            this.gridProfessores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProfessores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProfessores.ColumnHeadersVisible = false;
            this.gridProfessores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridProfessores.Location = new System.Drawing.Point(12, 12);
            this.gridProfessores.MultiSelect = false;
            this.gridProfessores.Name = "gridProfessores";
            this.gridProfessores.ReadOnly = true;
            this.gridProfessores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProfessores.Size = new System.Drawing.Size(361, 161);
            this.gridProfessores.TabIndex = 0;
            this.gridProfessores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfessores_CellContentDoubleClick);
            // 
            // F_GridProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.gridProfessores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GridProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Professores";
            this.Load += new System.EventHandler(this.F_GridProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridProfessores;
    }
}