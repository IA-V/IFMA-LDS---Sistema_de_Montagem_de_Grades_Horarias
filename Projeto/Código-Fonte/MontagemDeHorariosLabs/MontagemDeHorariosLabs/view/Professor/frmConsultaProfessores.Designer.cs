namespace MontagemDeHorariosLabs.view
{
    partial class frmConsultaProfessores
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
            this.dgvProfessores = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesligar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.barraPadrao = new System.Windows.Forms.ToolStrip();
            this.btnBarraDeletar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.barraPadrao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.AllowUserToAddRows = false;
            this.dgvProfessores.AllowUserToDeleteRows = false;
            this.dgvProfessores.AllowUserToResizeColumns = false;
            this.dgvProfessores.AllowUserToResizeRows = false;
            this.dgvProfessores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfessores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colMatricula,
            this.colCPF,
            this.colDesligar});
            this.dgvProfessores.Location = new System.Drawing.Point(33, 78);
            this.dgvProfessores.MinimumSize = new System.Drawing.Size(495, 131);
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.RowHeadersVisible = false;
            this.dgvProfessores.Size = new System.Drawing.Size(509, 131);
            this.dgvProfessores.TabIndex = 0;
            this.dgvProfessores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessores_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colId.Visible = false;
            // 
            // colNome
            // 
            this.colNome.FillWeight = 165.2217F;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMatricula
            // 
            this.colMatricula.FillWeight = 76.99442F;
            this.colMatricula.HeaderText = "Matrícula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCPF
            // 
            this.colCPF.FillWeight = 119.8138F;
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDesligar
            // 
            this.colDesligar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDesligar.FillWeight = 37.9701F;
            this.colDesligar.HeaderText = "Desligar";
            this.colDesligar.Name = "colDesligar";
            this.colDesligar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDesligar.Width = 48;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatricula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(110, 39);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(351, 26);
            this.txtMatricula.TabIndex = 3;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(30, 42);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(74, 18);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(467, 41);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // barraPadrao
            // 
            this.barraPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBarraDeletar});
            this.barraPadrao.Location = new System.Drawing.Point(0, 0);
            this.barraPadrao.Name = "barraPadrao";
            this.barraPadrao.Size = new System.Drawing.Size(571, 25);
            this.barraPadrao.TabIndex = 6;
            this.barraPadrao.Text = "toolStrip1";
            // 
            // btnBarraDeletar
            // 
            this.btnBarraDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBarraDeletar.Image = global::MontagemDeHorariosLabs.Properties.Resources.delete_32;
            this.btnBarraDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBarraDeletar.Name = "btnBarraDeletar";
            this.btnBarraDeletar.Size = new System.Drawing.Size(23, 22);
            this.btnBarraDeletar.Text = "toolStripButton1";
            this.btnBarraDeletar.ToolTipText = "Clique aqui para excluir os professores selecionados.";
            this.btnBarraDeletar.Click += new System.EventHandler(this.btnBarraDeletar_Click);
            // 
            // frmConsultaProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 253);
            this.Controls.Add(this.barraPadrao);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.dgvProfessores);
            this.MinimumSize = new System.Drawing.Size(587, 291);
            this.Name = "frmConsultaProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Professores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.barraPadrao.ResumeLayout(false);
            this.barraPadrao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfessores;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ToolStrip barraPadrao;
        private System.Windows.Forms.ToolStripButton btnBarraDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDesligar;
    }
}