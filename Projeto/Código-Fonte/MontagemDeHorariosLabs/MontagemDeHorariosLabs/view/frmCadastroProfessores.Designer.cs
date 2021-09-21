namespace MontagemDeHorariosLabs.view
{
    partial class frmCadastroProfessores
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.barraPadraoProfessor = new System.Windows.Forms.ToolStrip();
            this.btnPadraoSalvar = new System.Windows.Forms.ToolStripButton();
            this.txtIdProfessor = new System.Windows.Forms.TextBox();
            this.barraPadraoProfessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(62, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(122, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(122, 81);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(213, 26);
            this.txtMatricula.TabIndex = 6;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(42, 85);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(74, 18);
            this.lblMatricula.TabIndex = 5;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(122, 127);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(213, 26);
            this.txtCPF.TabIndex = 8;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(71, 130);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(45, 18);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(145, 181);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // barraPadraoProfessor
            // 
            this.barraPadraoProfessor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoSalvar});
            this.barraPadraoProfessor.Location = new System.Drawing.Point(0, 0);
            this.barraPadraoProfessor.Name = "barraPadraoProfessor";
            this.barraPadraoProfessor.Size = new System.Drawing.Size(382, 25);
            this.barraPadraoProfessor.TabIndex = 10;
            this.barraPadraoProfessor.Text = "toolStrip1";
            // 
            // btnPadraoSalvar
            // 
            this.btnPadraoSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoSalvar.Image = global::MontagemDeHorariosLabs.Properties.Resources.Save_32;
            this.btnPadraoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoSalvar.Name = "btnPadraoSalvar";
            this.btnPadraoSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnPadraoSalvar.Text = "btnPadraoSalvar";
            this.btnPadraoSalvar.Click += new System.EventHandler(this.btnPadraoSalvar_Click);
            // 
            // txtIdProfessor
            // 
            this.txtIdProfessor.Location = new System.Drawing.Point(266, 177);
            this.txtIdProfessor.Name = "txtIdProfessor";
            this.txtIdProfessor.Size = new System.Drawing.Size(68, 20);
            this.txtIdProfessor.TabIndex = 11;
            this.txtIdProfessor.Visible = false;
            // 
            // frmCadastroProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 229);
            this.Controls.Add(this.txtIdProfessor);
            this.Controls.Add(this.barraPadraoProfessor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastroProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.barraPadraoProfessor.ResumeLayout(false);
            this.barraPadraoProfessor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolStrip barraPadraoProfessor;
        private System.Windows.Forms.ToolStripButton btnPadraoSalvar;
        private System.Windows.Forms.TextBox txtIdProfessor;
    }
}