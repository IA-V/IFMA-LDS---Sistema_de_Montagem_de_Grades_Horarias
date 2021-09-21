namespace MontagemDeHorariosLabs.view
{
    partial class frmMontagemGradeHoraria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListaHorarios = new System.Windows.Forms.Label();
            this.dgvGradeHorarioEmAndamento = new System.Windows.Forms.DataGridView();
            this.btnIncluirHorario = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lblAnoSemestre = new System.Windows.Forms.Label();
            this.txtAnoSemestre = new System.Windows.Forms.TextBox();
            this.colHorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegunda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeHorarioEmAndamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaHorarios
            // 
            this.lblListaHorarios.AutoSize = true;
            this.lblListaHorarios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaHorarios.Location = new System.Drawing.Point(277, 49);
            this.lblListaHorarios.Name = "lblListaHorarios";
            this.lblListaHorarios.Size = new System.Drawing.Size(292, 22);
            this.lblListaHorarios.TabIndex = 0;
            this.lblListaHorarios.Text = "Lista de Horários [ Laboratório X ]";
            // 
            // dgvGradeHorarioEmAndamento
            // 
            this.dgvGradeHorarioEmAndamento.AllowUserToAddRows = false;
            this.dgvGradeHorarioEmAndamento.AllowUserToDeleteRows = false;
            this.dgvGradeHorarioEmAndamento.AllowUserToResizeColumns = false;
            this.dgvGradeHorarioEmAndamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGradeHorarioEmAndamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGradeHorarioEmAndamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeHorarioEmAndamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHorarios,
            this.colSegunda,
            this.colTerca,
            this.colQuarta,
            this.colQuinta,
            this.colSexta,
            this.colSabado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGradeHorarioEmAndamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGradeHorarioEmAndamento.Location = new System.Drawing.Point(50, 114);
            this.dgvGradeHorarioEmAndamento.Name = "dgvGradeHorarioEmAndamento";
            this.dgvGradeHorarioEmAndamento.ReadOnly = true;
            this.dgvGradeHorarioEmAndamento.RowHeadersVisible = false;
            this.dgvGradeHorarioEmAndamento.Size = new System.Drawing.Size(746, 269);
            this.dgvGradeHorarioEmAndamento.TabIndex = 1;
            // 
            // btnIncluirHorario
            // 
            this.btnIncluirHorario.Location = new System.Drawing.Point(677, 418);
            this.btnIncluirHorario.Name = "btnIncluirHorario";
            this.btnIncluirHorario.Size = new System.Drawing.Size(119, 23);
            this.btnIncluirHorario.TabIndex = 3;
            this.btnIncluirHorario.Text = "Incluir Horário";
            this.btnIncluirHorario.UseVisualStyleBackColor = true;
            this.btnIncluirHorario.Click += new System.EventHandler(this.btnIncluirHorario_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(360, 471);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(119, 23);
            this.btnConcluir.TabIndex = 4;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblAnoSemestre
            // 
            this.lblAnoSemestre.AutoSize = true;
            this.lblAnoSemestre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoSemestre.Location = new System.Drawing.Point(26, 421);
            this.lblAnoSemestre.Name = "lblAnoSemestre";
            this.lblAnoSemestre.Size = new System.Drawing.Size(137, 22);
            this.lblAnoSemestre.TabIndex = 5;
            this.lblAnoSemestre.Text = "Ano/Semestre:";
            // 
            // txtAnoSemestre
            // 
            this.txtAnoSemestre.Location = new System.Drawing.Point(169, 421);
            this.txtAnoSemestre.Name = "txtAnoSemestre";
            this.txtAnoSemestre.Size = new System.Drawing.Size(126, 20);
            this.txtAnoSemestre.TabIndex = 6;
            // 
            // colHorarios
            // 
            this.colHorarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.colHorarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.colHorarios.FillWeight = 83.33334F;
            this.colHorarios.HeaderText = "Horários";
            this.colHorarios.Name = "colHorarios";
            this.colHorarios.ReadOnly = true;
            this.colHorarios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSegunda
            // 
            this.colSegunda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSegunda.FillWeight = 83.33334F;
            this.colSegunda.HeaderText = "Segunda";
            this.colSegunda.Name = "colSegunda";
            this.colSegunda.ReadOnly = true;
            this.colSegunda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTerca
            // 
            this.colTerca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTerca.FillWeight = 133.3333F;
            this.colTerca.HeaderText = "Terça";
            this.colTerca.Name = "colTerca";
            this.colTerca.ReadOnly = true;
            this.colTerca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuarta
            // 
            this.colQuarta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuarta.HeaderText = "Quarta";
            this.colQuarta.Name = "colQuarta";
            this.colQuarta.ReadOnly = true;
            this.colQuarta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuinta
            // 
            this.colQuinta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuinta.HeaderText = "Quinta";
            this.colQuinta.Name = "colQuinta";
            this.colQuinta.ReadOnly = true;
            this.colQuinta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSexta
            // 
            this.colSexta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSexta.HeaderText = "Sexta";
            this.colSexta.Name = "colSexta";
            this.colSexta.ReadOnly = true;
            this.colSexta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSabado
            // 
            this.colSabado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSabado.HeaderText = "Sábado";
            this.colSabado.Name = "colSabado";
            this.colSabado.ReadOnly = true;
            this.colSabado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmMontagemGradeHoraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 510);
            this.Controls.Add(this.txtAnoSemestre);
            this.Controls.Add(this.lblAnoSemestre);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnIncluirHorario);
            this.Controls.Add(this.dgvGradeHorarioEmAndamento);
            this.Controls.Add(this.lblListaHorarios);
            this.Name = "frmMontagemGradeHoraria";
            this.Text = "Montar Grade Horária";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeHorarioEmAndamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaHorarios;
        private System.Windows.Forms.DataGridView dgvGradeHorarioEmAndamento;
        private System.Windows.Forms.Button btnIncluirHorario;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label lblAnoSemestre;
        private System.Windows.Forms.TextBox txtAnoSemestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegunda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSabado;
    }
}

