
namespace MyAcademy
{
    partial class F_GridHorarioOnCadTurma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridHorarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHorarios
            // 
            this.gridHorarios.AllowUserToAddRows = false;
            this.gridHorarios.AllowUserToDeleteRows = false;
            this.gridHorarios.AllowUserToResizeColumns = false;
            this.gridHorarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHorarios.ColumnHeadersVisible = false;
            this.gridHorarios.Location = new System.Drawing.Point(12, 12);
            this.gridHorarios.MultiSelect = false;
            this.gridHorarios.Name = "gridHorarios";
            this.gridHorarios.ReadOnly = true;
            this.gridHorarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHorarios.Size = new System.Drawing.Size(361, 161);
            this.gridHorarios.TabIndex = 1;
            this.gridHorarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHorarios_CellContentDoubleClick);
            // 
            // F_GridHorarioOnCadTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.gridHorarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GridHorarioOnCadTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GridHorarioOnCadTurma";
            this.Load += new System.EventHandler(this.F_GridHorarioOnCadTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridHorarios;
    }
}