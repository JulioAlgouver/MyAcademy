
namespace MyAcademy
{
    partial class F_GestãoTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAlunosMatriculados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridTurmas = new System.Windows.Forms.DataGridView();
            this.btn_matricular = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunosMatriculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAlunosMatriculados
            // 
            this.gridAlunosMatriculados.AllowUserToAddRows = false;
            this.gridAlunosMatriculados.AllowUserToDeleteRows = false;
            this.gridAlunosMatriculados.AllowUserToResizeColumns = false;
            this.gridAlunosMatriculados.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlunosMatriculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridAlunosMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlunosMatriculados.Location = new System.Drawing.Point(272, 44);
            this.gridAlunosMatriculados.MultiSelect = false;
            this.gridAlunosMatriculados.Name = "gridAlunosMatriculados";
            this.gridAlunosMatriculados.ReadOnly = true;
            this.gridAlunosMatriculados.RowHeadersVisible = false;
            this.gridAlunosMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlunosMatriculados.ShowCellErrors = false;
            this.gridAlunosMatriculados.ShowCellToolTips = false;
            this.gridAlunosMatriculados.ShowEditingIcon = false;
            this.gridAlunosMatriculados.ShowRowErrors = false;
            this.gridAlunosMatriculados.Size = new System.Drawing.Size(250, 300);
            this.gridAlunosMatriculados.StandardTab = true;
            this.gridAlunosMatriculados.TabIndex = 0;
            this.gridAlunosMatriculados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlunosMatriculados_CellContentClick);
            this.gridAlunosMatriculados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlunosMatriculados_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alunos matriculados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione uma turma:";
            // 
            // gridTurmas
            // 
            this.gridTurmas.AllowUserToAddRows = false;
            this.gridTurmas.AllowUserToDeleteRows = false;
            this.gridTurmas.AllowUserToResizeColumns = false;
            this.gridTurmas.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTurmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTurmas.Location = new System.Drawing.Point(16, 44);
            this.gridTurmas.MultiSelect = false;
            this.gridTurmas.Name = "gridTurmas";
            this.gridTurmas.ReadOnly = true;
            this.gridTurmas.RowHeadersVisible = false;
            this.gridTurmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTurmas.ShowCellErrors = false;
            this.gridTurmas.ShowCellToolTips = false;
            this.gridTurmas.ShowEditingIcon = false;
            this.gridTurmas.ShowRowErrors = false;
            this.gridTurmas.Size = new System.Drawing.Size(231, 124);
            this.gridTurmas.StandardTab = true;
            this.gridTurmas.TabIndex = 3;
            this.gridTurmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTurmas_CellContentClick);
            this.gridTurmas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTurmas_CellContentDoubleClick);
            // 
            // btn_matricular
            // 
            this.btn_matricular.BackColor = System.Drawing.SystemColors.Control;
            this.btn_matricular.FlatAppearance.BorderSize = 0;
            this.btn_matricular.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matricular.Location = new System.Drawing.Point(44, 191);
            this.btn_matricular.Name = "btn_matricular";
            this.btn_matricular.Size = new System.Drawing.Size(176, 47);
            this.btn_matricular.TabIndex = 4;
            this.btn_matricular.Text = "Matricular aluno";
            this.btn_matricular.UseVisualStyleBackColor = false;
            this.btn_matricular.Click += new System.EventHandler(this.btn_matricular_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.SystemColors.Control;
            this.btn_remover.FlatAppearance.BorderSize = 0;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_remover.Location = new System.Drawing.Point(44, 263);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(176, 47);
            this.btn_remover.TabIndex = 5;
            this.btn_remover.Text = "Remover aluno";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // F_GestãoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_matricular);
            this.Controls.Add(this.gridTurmas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAlunosMatriculados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestãoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.F_GestãoTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunosMatriculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_matricular;
        private System.Windows.Forms.Button btn_remover;
        public System.Windows.Forms.DataGridView gridAlunosMatriculados;
        public System.Windows.Forms.DataGridView gridTurmas;
    }
}