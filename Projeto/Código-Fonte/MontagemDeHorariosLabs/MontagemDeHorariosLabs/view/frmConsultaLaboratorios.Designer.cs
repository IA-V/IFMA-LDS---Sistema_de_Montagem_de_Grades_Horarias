namespace MontagemDeHorariosLabs.view
{
    partial class frmConsultaLaboratorios
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dgvLabs = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantMaquinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(367, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(103, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(258, 26);
            this.txtNumero.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(30, 32);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(67, 18);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Número:";
            // 
            // dgvLabs
            // 
            this.dgvLabs.AllowUserToAddRows = false;
            this.dgvLabs.AllowUserToDeleteRows = false;
            this.dgvLabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNumero,
            this.colQuantMaquinas,
            this.colLocalizacao});
            this.dgvLabs.Location = new System.Drawing.Point(33, 79);
            this.dgvLabs.Name = "dgvLabs";
            this.dgvLabs.ReadOnly = true;
            this.dgvLabs.Size = new System.Drawing.Size(409, 174);
            this.dgvLabs.TabIndex = 10;
            this.dgvLabs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLabs_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 70;
            // 
            // colQuantMaquinas
            // 
            this.colQuantMaquinas.HeaderText = "Quant. de Máquinas";
            this.colQuantMaquinas.Name = "colQuantMaquinas";
            this.colQuantMaquinas.ReadOnly = true;
            this.colQuantMaquinas.Width = 70;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            this.colLocalizacao.Width = 225;
            // 
            // frmConsultaLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 304);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.dgvLabs);
            this.Name = "frmConsultaLaboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Laboratórios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DataGridView dgvLabs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantMaquinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
    }
}