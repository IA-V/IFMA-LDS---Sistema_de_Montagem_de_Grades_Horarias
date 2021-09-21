namespace MontagemDeHorariosLabs.view
{
    partial class frmConsultaGradeHorarioVigente
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
            this.dgvGradeHoraria = new System.Windows.Forms.DataGridView();
            this.listaHorarioslbl = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnMudarGrade = new System.Windows.Forms.Button();
            this.colHorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegunda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeHoraria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGradeHoraria
            // 
            this.dgvGradeHoraria.AllowUserToAddRows = false;
            this.dgvGradeHoraria.AllowUserToDeleteRows = false;
            this.dgvGradeHoraria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeHoraria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHorarios,
            this.colSegunda,
            this.colTerca,
            this.colQuarta,
            this.colQuinta,
            this.colSexta,
            this.colSabado});
            this.dgvGradeHoraria.Location = new System.Drawing.Point(29, 106);
            this.dgvGradeHoraria.Name = "dgvGradeHoraria";
            this.dgvGradeHoraria.ReadOnly = true;
            this.dgvGradeHoraria.Size = new System.Drawing.Size(744, 284);
            this.dgvGradeHoraria.TabIndex = 3;
            // 
            // listaHorarioslbl
            // 
            this.listaHorarioslbl.AutoSize = true;
            this.listaHorarioslbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaHorarioslbl.Location = new System.Drawing.Point(261, 50);
            this.listaHorarioslbl.Name = "listaHorarioslbl";
            this.listaHorarioslbl.Size = new System.Drawing.Size(236, 18);
            this.listaHorarioslbl.TabIndex = 2;
            this.listaHorarioslbl.Text = "Lista de Horários [Laboratório X]";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(348, 429);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnMudarGrade
            // 
            this.btnMudarGrade.Location = new System.Drawing.Point(29, 429);
            this.btnMudarGrade.Name = "btnMudarGrade";
            this.btnMudarGrade.Size = new System.Drawing.Size(164, 23);
            this.btnMudarGrade.TabIndex = 17;
            this.btnMudarGrade.Text = "Mudar Grade Horária vigente";
            this.btnMudarGrade.UseVisualStyleBackColor = true;
            this.btnMudarGrade.Click += new System.EventHandler(this.btnMudarGrade_Click);
            // 
            // colHorarios
            // 
            this.colHorarios.Frozen = true;
            this.colHorarios.HeaderText = "Horários";
            this.colHorarios.Name = "colHorarios";
            this.colHorarios.ReadOnly = true;
            // 
            // colSegunda
            // 
            this.colSegunda.Frozen = true;
            this.colSegunda.HeaderText = "Segunda";
            this.colSegunda.Name = "colSegunda";
            this.colSegunda.ReadOnly = true;
            // 
            // colTerca
            // 
            this.colTerca.Frozen = true;
            this.colTerca.HeaderText = "Terça";
            this.colTerca.Name = "colTerca";
            this.colTerca.ReadOnly = true;
            // 
            // colQuarta
            // 
            this.colQuarta.Frozen = true;
            this.colQuarta.HeaderText = "Quarta";
            this.colQuarta.Name = "colQuarta";
            this.colQuarta.ReadOnly = true;
            // 
            // colQuinta
            // 
            this.colQuinta.Frozen = true;
            this.colQuinta.HeaderText = "Quinta";
            this.colQuinta.Name = "colQuinta";
            this.colQuinta.ReadOnly = true;
            // 
            // colSexta
            // 
            this.colSexta.Frozen = true;
            this.colSexta.HeaderText = "Sexta";
            this.colSexta.Name = "colSexta";
            this.colSexta.ReadOnly = true;
            // 
            // colSabado
            // 
            this.colSabado.HeaderText = "Sábado";
            this.colSabado.Name = "colSabado";
            this.colSabado.ReadOnly = true;
            // 
            // frmConsultaGradeHorarioVigente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 492);
            this.Controls.Add(this.btnMudarGrade);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvGradeHoraria);
            this.Controls.Add(this.listaHorarioslbl);
            this.Name = "frmConsultaGradeHorarioVigente";
            this.Text = "Consulta de Grade Horária";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeHoraria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGradeHoraria;
        private System.Windows.Forms.Label listaHorarioslbl;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnMudarGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegunda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSabado;
    }
}