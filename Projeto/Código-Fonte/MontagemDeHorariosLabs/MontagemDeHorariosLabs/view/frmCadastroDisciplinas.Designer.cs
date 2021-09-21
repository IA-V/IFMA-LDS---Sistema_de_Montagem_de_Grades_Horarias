namespace MontagemDeHorariosLabs.view
{
    partial class frmCadastroDisciplinas
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPadraoDisciplinas = new System.Windows.Forms.ToolStrip();
            this.btnPadraoSalvar = new System.Windows.Forms.ToolStripButton();
            this.txtIdDisciplina = new System.Windows.Forms.TextBox();
            this.btnPadraoDisciplinas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(166, 183);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSigla
            // 
            this.txtSigla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Location = new System.Drawing.Point(144, 139);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(213, 26);
            this.txtSigla.TabIndex = 15;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(93, 147);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 18);
            this.lblCPF.TabIndex = 14;
            this.lblCPF.Text = "Sigla:";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargaHoraria.Location = new System.Drawing.Point(144, 98);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(213, 26);
            this.txtCargaHoraria.TabIndex = 13;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(26, 101);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(112, 18);
            this.lblMatricula.TabIndex = 12;
            this.lblMatricula.Text = "Carga Horária:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(144, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 26);
            this.txtNome.TabIndex = 11;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(84, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // btnPadraoDisciplinas
            // 
            this.btnPadraoDisciplinas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoSalvar});
            this.btnPadraoDisciplinas.Location = new System.Drawing.Point(0, 0);
            this.btnPadraoDisciplinas.Name = "btnPadraoDisciplinas";
            this.btnPadraoDisciplinas.Size = new System.Drawing.Size(400, 25);
            this.btnPadraoDisciplinas.TabIndex = 17;
            this.btnPadraoDisciplinas.Text = "toolStrip1";
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
            // txtIdDisciplina
            // 
            this.txtIdDisciplina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDisciplina.Location = new System.Drawing.Point(303, 183);
            this.txtIdDisciplina.Name = "txtIdDisciplina";
            this.txtIdDisciplina.Size = new System.Drawing.Size(73, 26);
            this.txtIdDisciplina.TabIndex = 18;
            this.txtIdDisciplina.Visible = false;
            // 
            // frmCadastroDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 248);
            this.Controls.Add(this.txtIdDisciplina);
            this.Controls.Add(this.btnPadraoDisciplinas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastroDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Disciplinas";
            this.btnPadraoDisciplinas.ResumeLayout(false);
            this.btnPadraoDisciplinas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ToolStrip btnPadraoDisciplinas;
        private System.Windows.Forms.ToolStripButton btnPadraoSalvar;
        private System.Windows.Forms.TextBox txtIdDisciplina;
    }
}