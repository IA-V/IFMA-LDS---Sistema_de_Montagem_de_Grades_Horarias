namespace MontagemDeHorariosLabs.view
{
    partial class frmEscolhaLaboratorioGHV
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
            this.lblNumeroLaboratorio = new System.Windows.Forms.Label();
            this.cmbNumeroLaboratorio = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroLaboratorio
            // 
            this.lblNumeroLaboratorio.AutoSize = true;
            this.lblNumeroLaboratorio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLaboratorio.Location = new System.Drawing.Point(28, 29);
            this.lblNumeroLaboratorio.Name = "lblNumeroLaboratorio";
            this.lblNumeroLaboratorio.Size = new System.Drawing.Size(174, 18);
            this.lblNumeroLaboratorio.TabIndex = 0;
            this.lblNumeroLaboratorio.Text = "Número do Laboratório:";
            // 
            // cmbNumeroLaboratorio
            // 
            this.cmbNumeroLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroLaboratorio.FormattingEnabled = true;
            this.cmbNumeroLaboratorio.Location = new System.Drawing.Point(208, 30);
            this.cmbNumeroLaboratorio.Name = "cmbNumeroLaboratorio";
            this.cmbNumeroLaboratorio.Size = new System.Drawing.Size(145, 21);
            this.cmbNumeroLaboratorio.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(145, 81);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmEscolhaLaboratorioGHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 126);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cmbNumeroLaboratorio);
            this.Controls.Add(this.lblNumeroLaboratorio);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 164);
            this.MinimumSize = new System.Drawing.Size(396, 164);
            this.Name = "frmEscolhaLaboratorioGHV";
            this.Text = "Escolha de Laboratório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroLaboratorio;
        private System.Windows.Forms.ComboBox cmbNumeroLaboratorio;
        private System.Windows.Forms.Button btnConfirmar;
    }
}