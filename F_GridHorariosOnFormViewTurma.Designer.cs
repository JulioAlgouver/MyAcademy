
namespace MyAcademy
{
    partial class F_GridHorariosOnFormViewTurma
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridHorarios.ColumnHeadersVisible = false;
            this.gridHorarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridHorarios.Location = new System.Drawing.Point(12, 12);
            this.gridHorarios.MultiSelect = false;
            this.gridHorarios.Name = "gridHorarios";
            this.gridHorarios.ReadOnly = true;
            this.gridHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHorarios.Size = new System.Drawing.Size(361, 161);
            this.gridHorarios.TabIndex = 1;
            this.gridHorarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHorarios_CellContentDoubleClick);
            // 
            // F_GridHorariosOnFormViewTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.gridHorarios);
            this.Name = "F_GridHorariosOnFormViewTurma";
            this.Text = "Lista de Horários";
            this.Load += new System.EventHandler(this.F_GridHorariosOnFormViewTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridHorarios;
    }
}