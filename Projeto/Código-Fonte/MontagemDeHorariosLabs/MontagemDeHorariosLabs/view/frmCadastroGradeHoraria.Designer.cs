namespace MontagemDeHorariosLabs.view
{
    partial class frmCadastroGradeHoraria
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
            this.listaHorarioslbl = new System.Windows.Forms.Label();
            this.dgvGradeHoraria = new System.Windows.Forms.DataGridView();
            this.colIdGradeHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorarioInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorarioFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaDaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoSemestrelbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIncluirHorario = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeHoraria)).BeginInit();
            this.SuspendLayout();
            // 
            // listaHorarioslbl
            // 
            this.listaHorarioslbl.AutoSize = true;
            this.listaHorarioslbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaHorarioslbl.Location = new System.Drawing.Point(220, 32);
            this.listaHorarioslbl.Name = "listaHorarioslbl";
            this.listaHorarioslbl.Size = new System.Drawing.Size(128, 18);
            this.listaHorarioslbl.TabIndex = 0;
            this.listaHorarioslbl.Text = "Lista de Horários";
            // 
            // dgvGradeHoraria
            // 
            this.dgvGradeHoraria.AllowUserToAddRows = false;
            this.dgvGradeHoraria.AllowUserToDeleteRows = false;
            this.dgvGradeHoraria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeHoraria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdGradeHoraria,
            this.colDisciplina,
            this.colProfessor,
            this.colHorarioInicio,
            this.colHorarioFim,
            this.colDiaDaSemana});
            this.dgvGradeHoraria.Location = new System.Drawing.Point(12, 68);
            this.dgvGradeHoraria.Name = "dgvGradeHoraria";
            this.dgvGradeHoraria.ReadOnly = true;
            this.dgvGradeHoraria.Size = new System.Drawing.Size(545, 150);
            this.dgvGradeHoraria.TabIndex = 1;
            // 
            // colIdGradeHoraria
            // 
            this.colIdGradeHoraria.Frozen = true;
            this.colIdGradeHoraria.HeaderText = "ID";
            this.colIdGradeHoraria.Name = "colIdGradeHoraria";
            this.colIdGradeHoraria.ReadOnly = true;
            this.colIdGradeHoraria.Visible = false;
            // 
            // colDisciplina
            // 
            this.colDisciplina.Frozen = true;
            this.colDisciplina.HeaderText = "Disciplina";
            this.colDisciplina.Name = "colDisciplina";
            this.colDisciplina.ReadOnly = true;
            // 
            // colProfessor
            // 
            this.colProfessor.Frozen = true;
            this.colProfessor.HeaderText = "Professor";
            this.colProfessor.Name = "colProfessor";
            this.colProfessor.ReadOnly = true;
            // 
            // colHorarioInicio
            // 
            this.colHorarioInicio.Frozen = true;
            this.colHorarioInicio.HeaderText = "Horário de Inicio";
            this.colHorarioInicio.Name = "colHorarioInicio";
            this.colHorarioInicio.ReadOnly = true;
            // 
            // colHorarioFim
            // 
            this.colHorarioFim.Frozen = true;
            this.colHorarioFim.HeaderText = "Horário de Término";
            this.colHorarioFim.Name = "colHorarioFim";
            this.colHorarioFim.ReadOnly = true;
            // 
            // colDiaDaSemana
            // 
            this.colDiaDaSemana.Frozen = true;
            this.colDiaDaSemana.HeaderText = "Dia da Semana";
            this.colDiaDaSemana.Name = "colDiaDaSemana";
            this.colDiaDaSemana.ReadOnly = true;
            // 
            // anoSemestrelbl
            // 
            this.anoSemestrelbl.AutoSize = true;
            this.anoSemestrelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoSemestrelbl.Location = new System.Drawing.Point(12, 243);
            this.anoSemestrelbl.Name = "anoSemestrelbl";
            this.anoSemestrelbl.Size = new System.Drawing.Size(112, 18);
            this.anoSemestrelbl.TabIndex = 2;
            this.anoSemestrelbl.Text = "Ano/Semestre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnIncluirHorario
            // 
            this.btnIncluirHorario.Location = new System.Drawing.Point(438, 242);
            this.btnIncluirHorario.Name = "btnIncluirHorario";
            this.btnIncluirHorario.Size = new System.Drawing.Size(119, 23);
            this.btnIncluirHorario.TabIndex = 4;
            this.btnIncluirHorario.Text = "Incluir Horário";
            this.btnIncluirHorario.UseVisualStyleBackColor = true;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(241, 289);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(93, 23);
            this.btnConcluir.TabIndex = 5;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            // 
            // frmMontarGradeHoraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 333);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnIncluirHorario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.anoSemestrelbl);
            this.Controls.Add(this.dgvGradeHoraria);
            this.Controls.Add(this.listaHorarioslbl);
            this.Name = "frmMontarGradeHoraria";
            this.Text = "Montar Grade Horária";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeHoraria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listaHorarioslbl;
        private System.Windows.Forms.DataGridView dgvGradeHoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdGradeHoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorarioInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorarioFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaDaSemana;
        private System.Windows.Forms.Label anoSemestrelbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIncluirHorario;
        private System.Windows.Forms.Button btnConcluir;
    }
}