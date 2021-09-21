namespace MontagemDeHorariosLabs.view
{
    partial class frmIncluirHorario
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
            this.lblSiglaDisc = new System.Windows.Forms.Label();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.cmbDiaSemana = new System.Windows.Forms.ComboBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.cmbSiglaDisciplina = new System.Windows.Forms.ComboBox();
            this.cmbNomeProfessor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSiglaDisc
            // 
            this.lblSiglaDisc.AutoSize = true;
            this.lblSiglaDisc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiglaDisc.Location = new System.Drawing.Point(32, 34);
            this.lblSiglaDisc.Name = "lblSiglaDisc";
            this.lblSiglaDisc.Size = new System.Drawing.Size(143, 18);
            this.lblSiglaDisc.TabIndex = 4;
            this.lblSiglaDisc.Text = "Sigla da Disciplina:";
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.Location = new System.Drawing.Point(27, 74);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(148, 18);
            this.lblNomeProfessor.TabIndex = 6;
            this.lblNomeProfessor.Text = "Nome do Professor:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(115, 119);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(55, 18);
            this.lblTurma.TabIndex = 8;
            this.lblTurma.Text = "Turma:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(48, 206);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(122, 18);
            this.lblDiaSemana.TabIndex = 12;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(137, 255);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(93, 23);
            this.btnIncluir.TabIndex = 14;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
            this.cmbDiaSemana.Location = new System.Drawing.Point(176, 206);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(145, 21);
            this.cmbDiaSemana.TabIndex = 17;
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "07:15 - 08:55",
            "08:55 - 10:35",
            "10:50 - 12:30",
            "13:10 - 14:50",
            "14:50 - 16:30"});
            this.cmbHorario.Location = new System.Drawing.Point(176, 161);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(145, 21);
            this.cmbHorario.TabIndex = 16;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(106, 164);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(64, 18);
            this.lblHorario.TabIndex = 10;
            this.lblHorario.Text = "Horário:";
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(176, 120);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(142, 20);
            this.txtTurma.TabIndex = 18;
            // 
            // cmbSiglaDisciplina
            // 
            this.cmbSiglaDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiglaDisciplina.FormattingEnabled = true;
            this.cmbSiglaDisciplina.Location = new System.Drawing.Point(176, 34);
            this.cmbSiglaDisciplina.Name = "cmbSiglaDisciplina";
            this.cmbSiglaDisciplina.Size = new System.Drawing.Size(142, 21);
            this.cmbSiglaDisciplina.TabIndex = 19;
            // 
            // cmbNomeProfessor
            // 
            this.cmbNomeProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeProfessor.FormattingEnabled = true;
            this.cmbNomeProfessor.Location = new System.Drawing.Point(176, 75);
            this.cmbNomeProfessor.Name = "cmbNomeProfessor";
            this.cmbNomeProfessor.Size = new System.Drawing.Size(142, 21);
            this.cmbNomeProfessor.TabIndex = 20;
            // 
            // frmIncluirHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 312);
            this.Controls.Add(this.cmbNomeProfessor);
            this.Controls.Add(this.cmbSiglaDisciplina);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.cmbDiaSemana);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblNomeProfessor);
            this.Controls.Add(this.lblSiglaDisc);
            this.Name = "frmIncluirHorario";
            this.Text = "Horário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSiglaDisc;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ComboBox cmbDiaSemana;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.ComboBox cmbSiglaDisciplina;
        private System.Windows.Forms.ComboBox cmbNomeProfessor;
    }
}