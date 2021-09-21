namespace MontagemDeHorariosLabs.view
{
    partial class frmConsultaDisciplinas
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargaHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(425, 35);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtSigla
            // 
            this.txtSigla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Location = new System.Drawing.Point(91, 33);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(323, 26);
            this.txtSigla.TabIndex = 8;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigla.Location = new System.Drawing.Point(37, 36);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(48, 18);
            this.lblSigla.TabIndex = 7;
            this.lblSigla.Text = "Sigla:";
            // 
            // dgvDisciplinas
            // 
            this.dgvDisciplinas.AllowUserToAddRows = false;
            this.dgvDisciplinas.AllowUserToDeleteRows = false;
            this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colCargaHoraria,
            this.colSigla});
            this.dgvDisciplinas.Location = new System.Drawing.Point(40, 83);
            this.dgvDisciplinas.Name = "dgvDisciplinas";
            this.dgvDisciplinas.ReadOnly = true;
            this.dgvDisciplinas.Size = new System.Drawing.Size(460, 131);
            this.dgvDisciplinas.TabIndex = 6;
            this.dgvDisciplinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisciplinas_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 275;
            // 
            // colCargaHoraria
            // 
            this.colCargaHoraria.HeaderText = "C. H.";
            this.colCargaHoraria.Name = "colCargaHoraria";
            this.colCargaHoraria.ReadOnly = true;
            this.colCargaHoraria.Width = 70;
            // 
            // colSigla
            // 
            this.colSigla.HeaderText = "Sigla";
            this.colSigla.Name = "colSigla";
            this.colSigla.ReadOnly = true;
            this.colSigla.Width = 70;
            // 
            // frmConsultaDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 253);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.dgvDisciplinas);
            this.Name = "frmConsultaDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Disciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.DataGridView dgvDisciplinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargaHoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSigla;
    }
}