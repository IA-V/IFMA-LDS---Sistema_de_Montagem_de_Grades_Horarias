using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontagemDeHorariosLabs.view
{
    public partial class frmTelaPrincipal : Form
    {
        private Coordenador coordenadorLogado;
        public Coordenador GetCoordenador()
        {
            return this.coordenadorLogado;
        }
        public void SetCoordenador(Coordenador coord)
        {
            this.coordenadorLogado = coord;
        }

        public frmTelaPrincipal(Coordenador coord)
        {
            InitializeComponent();
            this.coordenadorLogado = coord;
        }

        private void professoresTSMI_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmConsultaProfessores());
        }
        private void disciplinasTecnicasTSMI_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmConsultaDisciplinas());
        }
        private void laboratoriosTSMI_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmConsultaLaboratorios());
        }
        private void trocarCoordenadorEmVigenciaTSMI_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmTrocaCoordenadores());
        }
        private void montarGradeHorariaTSMI_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmEscolhaLaboratorioGHV());
        }
        private void consultarLaboratoriosLivresTSMI_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmEscolhaHorario());
        }
        public void abrirFormulario(Form novoForm)
        {
            foreach (Form form in this.MdiChildren)
                form.Dispose();
            novoForm.MdiParent = this;
            novoForm.Show();
        }
        private void sairDoSistemaTSMI_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Você deseja realmente sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void gerarRelatoriosTSMI_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new frmRelatorioGrade());
        }
    }
}