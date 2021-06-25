
namespace MyAcademy
{
    partial class F_GridConveniosOnFormBusca
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
            this.gridConvenios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridConvenios)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConvenios
            // 
            this.gridConvenios.AllowUserToAddRows = false;
            this.gridConvenios.AllowUserToDeleteRows = false;
            this.gridConvenios.AllowUserToResizeColumns = false;
            this.gridConvenios.AllowUserToResizeRows = false;
            this.gridConvenios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConvenios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridConvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConvenios.Location = new System.Drawing.Point(12, 12);
            this.gridConvenios.MultiSelect = false;
            this.gridConvenios.Name = "gridConvenios";
            this.gridConvenios.RowHeadersVisible = false;
            this.gridConvenios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridConvenios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConvenios.Size = new System.Drawing.Size(361, 161);
            this.gridConvenios.StandardTab = true;
            this.gridConvenios.TabIndex = 1;
            this.gridConvenios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConvenios_CellContentDoubleClick);
            // 
            // F_GridConveniosOnFormBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.gridConvenios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GridConveniosOnFormBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Convenio";
            this.Load += new System.EventHandler(this.F_GridConveniosOnFormBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConvenios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridConvenios;
    }
}