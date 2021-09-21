namespace MontagemDeHorariosLabs.view
{
    partial class frmTelaPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.inicioTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasTecnicasTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.montarGradeHorariaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.acoesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLaboratoriosLivresTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarCoordenadorEmVigenciaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatoriosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioTSMI,
            this.consultarTSMI,
            this.acoesTSMI});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipal.Size = new System.Drawing.Size(679, 25);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // inicioTSMI
            // 
            this.inicioTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairDoSistemaTSMI});
            this.inicioTSMI.Name = "inicioTSMI";
            this.inicioTSMI.Size = new System.Drawing.Size(49, 21);
            this.inicioTSMI.Text = "Início";
            // 
            // sairDoSistemaTSMI
            // 
            this.sairDoSistemaTSMI.Name = "sairDoSistemaTSMI";
            this.sairDoSistemaTSMI.Size = new System.Drawing.Size(162, 22);
            this.sairDoSistemaTSMI.Text = "Sair do Sistema";
            this.sairDoSistemaTSMI.ToolTipText = "Clique aqui para sair do sistema.";
            this.sairDoSistemaTSMI.Click += new System.EventHandler(this.sairDoSistemaTSMI_Click);
            // 
            // consultarTSMI
            // 
            this.consultarTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasTecnicasTSMI,
            this.montarGradeHorariaTSMI,
            this.laboratoriosTSMI,
            this.professoresTSMI});
            this.consultarTSMI.Name = "consultarTSMI";
            this.consultarTSMI.Size = new System.Drawing.Size(71, 21);
            this.consultarTSMI.Text = "Registros";
            // 
            // disciplinasTecnicasTSMI
            // 
            this.disciplinasTecnicasTSMI.Name = "disciplinasTecnicasTSMI";
            this.disciplinasTecnicasTSMI.Size = new System.Drawing.Size(214, 22);
            this.disciplinasTecnicasTSMI.Text = "Disciplinas Técnicas";
            this.disciplinasTecnicasTSMI.ToolTipText = "Clique aqui para consultar disciplinas técnicas.";
            this.disciplinasTecnicasTSMI.Click += new System.EventHandler(this.disciplinasTecnicasTSMI_Click);
            // 
            // montarGradeHorariaTSMI
            // 
            this.montarGradeHorariaTSMI.Name = "montarGradeHorariaTSMI";
            this.montarGradeHorariaTSMI.Size = new System.Drawing.Size(214, 22);
            this.montarGradeHorariaTSMI.Text = "Grades Horárias Vigentes";
            this.montarGradeHorariaTSMI.ToolTipText = "Clique aqui para consultar grades horárias vigentes.";
            this.montarGradeHorariaTSMI.Click += new System.EventHandler(this.montarGradeHorariaTSMI_Click);
            // 
            // laboratoriosTSMI
            // 
            this.laboratoriosTSMI.Name = "laboratoriosTSMI";
            this.laboratoriosTSMI.Size = new System.Drawing.Size(214, 22);
            this.laboratoriosTSMI.Text = "Laboratórios";
            this.laboratoriosTSMI.ToolTipText = "Clique aqui para consultar laboratórios.";
            this.laboratoriosTSMI.Click += new System.EventHandler(this.laboratoriosTSMI_Click);
            // 
            // professoresTSMI
            // 
            this.professoresTSMI.Name = "professoresTSMI";
            this.professoresTSMI.Size = new System.Drawing.Size(214, 22);
            this.professoresTSMI.Text = "Professores";
            this.professoresTSMI.ToolTipText = "Clique aqui para consultar professores.";
            this.professoresTSMI.Click += new System.EventHandler(this.professoresTSMI_Click);
            // 
            // acoesTSMI
            // 
            this.acoesTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarLaboratoriosLivresTSMI,
            this.trocarCoordenadorEmVigenciaTSMI,
            this.gerarRelatoriosTSMI});
            this.acoesTSMI.Name = "acoesTSMI";
            this.acoesTSMI.Size = new System.Drawing.Size(53, 21);
            this.acoesTSMI.Text = "Ações";
            // 
            // consultarLaboratoriosLivresTSMI
            // 
            this.consultarLaboratoriosLivresTSMI.Name = "consultarLaboratoriosLivresTSMI";
            this.consultarLaboratoriosLivresTSMI.Size = new System.Drawing.Size(255, 22);
            this.consultarLaboratoriosLivresTSMI.Text = "Consultar Laboratórios livres";
            this.consultarLaboratoriosLivresTSMI.ToolTipText = "Clique aqui para consultar laboratórios livres.";
            this.consultarLaboratoriosLivresTSMI.Click += new System.EventHandler(this.consultarLaboratoriosLivresTSMI_Click);
            // 
            // trocarCoordenadorEmVigenciaTSMI
            // 
            this.trocarCoordenadorEmVigenciaTSMI.Name = "trocarCoordenadorEmVigenciaTSMI";
            this.trocarCoordenadorEmVigenciaTSMI.Size = new System.Drawing.Size(255, 22);
            this.trocarCoordenadorEmVigenciaTSMI.Text = "Trocar Coordenador em Vigência";
            this.trocarCoordenadorEmVigenciaTSMI.ToolTipText = "Clique aqui para trocar o coordenador em vigência.";
            this.trocarCoordenadorEmVigenciaTSMI.Click += new System.EventHandler(this.trocarCoordenadorEmVigenciaTSMI_Click);
            // 
            // gerarRelatoriosTSMI
            // 
            this.gerarRelatoriosTSMI.Name = "gerarRelatoriosTSMI";
            this.gerarRelatoriosTSMI.Size = new System.Drawing.Size(255, 22);
            this.gerarRelatoriosTSMI.Text = "Gerar Relatórios";
            this.gerarRelatoriosTSMI.ToolTipText = "Clique aqui para gerar relatórios.";
            this.gerarRelatoriosTSMI.Click += new System.EventHandler(this.gerarRelatoriosTSMI_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 407);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmTelaPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem inicioTSMI;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaTSMI;
        private System.Windows.Forms.ToolStripMenuItem consultarTSMI;
        private System.Windows.Forms.ToolStripMenuItem disciplinasTecnicasTSMI;
        private System.Windows.Forms.ToolStripMenuItem montarGradeHorariaTSMI;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosTSMI;
        private System.Windows.Forms.ToolStripMenuItem professoresTSMI;
        private System.Windows.Forms.ToolStripMenuItem acoesTSMI;
        private System.Windows.Forms.ToolStripMenuItem consultarLaboratoriosLivresTSMI;
        private System.Windows.Forms.ToolStripMenuItem trocarCoordenadorEmVigenciaTSMI;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatoriosTSMI;
    }
}