namespace MontagemDeHorariosLabs.view
{
    partial class frmCadastroLaboratorios
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
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.txtQuantMaquinas = new System.Windows.Forms.TextBox();
            this.lblQuantNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnPadraoLaboratorios = new System.Windows.Forms.ToolStrip();
            this.btnPadraoSalvar = new System.Windows.Forms.ToolStripButton();
            this.txtIdLaboratorio = new System.Windows.Forms.TextBox();
            this.btnPadraoLaboratorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(169, 178);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalizacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacao.Location = new System.Drawing.Point(169, 129);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(329, 26);
            this.txtLocalizacao.TabIndex = 22;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacao.Location = new System.Drawing.Point(67, 132);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(96, 18);
            this.lblLocalizacao.TabIndex = 21;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // txtQuantMaquinas
            // 
            this.txtQuantMaquinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantMaquinas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantMaquinas.Location = new System.Drawing.Point(169, 81);
            this.txtQuantMaquinas.Name = "txtQuantMaquinas";
            this.txtQuantMaquinas.Size = new System.Drawing.Size(329, 26);
            this.txtQuantMaquinas.TabIndex = 20;
            // 
            // lblQuantNumero
            // 
            this.lblQuantNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantNumero.AutoSize = true;
            this.lblQuantNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantNumero.Location = new System.Drawing.Point(12, 84);
            this.lblQuantNumero.Name = "lblQuantNumero";
            this.lblQuantNumero.Size = new System.Drawing.Size(151, 18);
            this.lblQuantNumero.TabIndex = 19;
            this.lblQuantNumero.Text = "Quant. de Máquinas:";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(169, 32);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(329, 26);
            this.txtNumero.TabIndex = 18;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(96, 35);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(67, 18);
            this.lblNumero.TabIndex = 17;
            this.lblNumero.Text = "Número:";
            // 
            // btnPadraoLaboratorios
            // 
            this.btnPadraoLaboratorios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoSalvar});
            this.btnPadraoLaboratorios.Location = new System.Drawing.Point(0, 0);
            this.btnPadraoLaboratorios.Name = "btnPadraoLaboratorios";
            this.btnPadraoLaboratorios.Size = new System.Drawing.Size(513, 25);
            this.btnPadraoLaboratorios.TabIndex = 24;
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
            // txtIdLaboratorio
            // 
            this.txtIdLaboratorio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdLaboratorio.Location = new System.Drawing.Point(285, 175);
            this.txtIdLaboratorio.Name = "txtIdLaboratorio";
            this.txtIdLaboratorio.Size = new System.Drawing.Size(97, 26);
            this.txtIdLaboratorio.TabIndex = 25;
            this.txtIdLaboratorio.Visible = false;
            // 
            // frmCadastroLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 222);
            this.Controls.Add(this.txtIdLaboratorio);
            this.Controls.Add(this.btnPadraoLaboratorios);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.txtQuantMaquinas);
            this.Controls.Add(this.lblQuantNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 266);
            this.MinimumSize = new System.Drawing.Size(520, 260);
            this.Name = "frmCadastroLaboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Laboratórios";
            this.btnPadraoLaboratorios.ResumeLayout(false);
            this.btnPadraoLaboratorios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.TextBox txtQuantMaquinas;
        private System.Windows.Forms.Label lblQuantNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ToolStrip btnPadraoLaboratorios;
        private System.Windows.Forms.ToolStripButton btnPadraoSalvar;
        private System.Windows.Forms.TextBox txtIdLaboratorio;
    }
}