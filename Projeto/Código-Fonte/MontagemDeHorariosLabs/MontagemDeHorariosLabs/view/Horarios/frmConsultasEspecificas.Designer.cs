namespace MontagemDeHorariosLabs.view
{
    partial class frmConsultasEspecificas
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
            this.gbEscolha = new System.Windows.Forms.GroupBox();
            this.rbHorariosLivres = new System.Windows.Forms.RadioButton();
            this.rbDisciplinasTecnicas = new System.Windows.Forms.RadioButton();
            this.rbProfessores = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.gbEscolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEscolha
            // 
            this.gbEscolha.Controls.Add(this.rbHorariosLivres);
            this.gbEscolha.Controls.Add(this.rbDisciplinasTecnicas);
            this.gbEscolha.Controls.Add(this.rbProfessores);
            this.gbEscolha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEscolha.Location = new System.Drawing.Point(30, 25);
            this.gbEscolha.Name = "gbEscolha";
            this.gbEscolha.Size = new System.Drawing.Size(200, 151);
            this.gbEscolha.TabIndex = 0;
            this.gbEscolha.TabStop = false;
            this.gbEscolha.Text = "Escolha";
            // 
            // rbHorariosLivres
            // 
            this.rbHorariosLivres.AutoSize = true;
            this.rbHorariosLivres.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHorariosLivres.Location = new System.Drawing.Point(30, 100);
            this.rbHorariosLivres.Name = "rbHorariosLivres";
            this.rbHorariosLivres.Size = new System.Drawing.Size(124, 21);
            this.rbHorariosLivres.TabIndex = 2;
            this.rbHorariosLivres.Text = "Horários Livres";
            this.rbHorariosLivres.UseVisualStyleBackColor = true;
            // 
            // rbDisciplinasTecnicas
            // 
            this.rbDisciplinasTecnicas.AutoSize = true;
            this.rbDisciplinasTecnicas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisciplinasTecnicas.Location = new System.Drawing.Point(30, 64);
            this.rbDisciplinasTecnicas.Name = "rbDisciplinasTecnicas";
            this.rbDisciplinasTecnicas.Size = new System.Drawing.Size(161, 21);
            this.rbDisciplinasTecnicas.TabIndex = 1;
            this.rbDisciplinasTecnicas.Text = "Disciplinas Técnicas";
            this.rbDisciplinasTecnicas.UseVisualStyleBackColor = true;
            // 
            // rbProfessores
            // 
            this.rbProfessores.AutoSize = true;
            this.rbProfessores.Checked = true;
            this.rbProfessores.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfessores.Location = new System.Drawing.Point(30, 28);
            this.rbProfessores.Name = "rbProfessores";
            this.rbProfessores.Size = new System.Drawing.Size(106, 21);
            this.rbProfessores.TabIndex = 0;
            this.rbProfessores.TabStop = true;
            this.rbProfessores.Text = "Professores";
            this.rbProfessores.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(91, 194);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 1;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmConsultasEspecificas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 243);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.gbEscolha);
            this.Name = "frmConsultasEspecificas";
            this.Text = "Listar";
            this.gbEscolha.ResumeLayout(false);
            this.gbEscolha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEscolha;
        private System.Windows.Forms.RadioButton rbHorariosLivres;
        private System.Windows.Forms.RadioButton rbDisciplinasTecnicas;
        private System.Windows.Forms.RadioButton rbProfessores;
        private System.Windows.Forms.Button btnContinuar;
    }
}