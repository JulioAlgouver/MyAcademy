
namespace MyAcademy
{
    partial class F_GridTurma
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
            this.gridTurma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTurma
            // 
            this.gridTurma.AllowUserToAddRows = false;
            this.gridTurma.AllowUserToDeleteRows = false;
            this.gridTurma.AllowUserToResizeColumns = false;
            this.gridTurma.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTurma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTurma.ColumnHeadersVisible = false;
            this.gridTurma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridTurma.Location = new System.Drawing.Point(12, 12);
            this.gridTurma.MultiSelect = false;
            this.gridTurma.Name = "gridTurma";
            this.gridTurma.ReadOnly = true;
            this.gridTurma.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTurma.Size = new System.Drawing.Size(361, 161);
            this.gridTurma.TabIndex = 1;
            this.gridTurma.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTurma_CellContentDoubleClick);
            // 
            // F_GridTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.gridTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GridTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Turma";
            this.Load += new System.EventHandler(this.F_GridTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridTurma;
    }
}