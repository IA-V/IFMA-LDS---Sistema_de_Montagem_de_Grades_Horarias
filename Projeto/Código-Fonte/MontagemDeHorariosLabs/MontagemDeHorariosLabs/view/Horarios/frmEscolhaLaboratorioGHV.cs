using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MontagemDeHorariosLabs.dao;

namespace MontagemDeHorariosLabs.view
{
    public partial class frmEscolhaLaboratorioGHV : Form
    {
        private DaoLaboratorio daoLaboratorio;
        private DaoGradeHoraria daoGH;

        public frmEscolhaLaboratorioGHV()
        {
            InitializeComponent();
            this.preencherComboBox();
        }

        private void preencherComboBox()
        {
            daoLaboratorio = new DaoLaboratorio();
            List<Laboratorio> laboratorios = daoLaboratorio.buscarLaboratoriosBD(-1);
            foreach (Laboratorio lab in laboratorios)
                if (lab != null)
                    cmbNumeroLaboratorio.Items.Add(lab.getNumero());
                else
                    MessageBox.Show("Você precisa cadastrar algum laboratório para poder usar essa funcionalidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbNumeroLaboratorio.SelectedIndex != -1)
            {
                this.daoGH = new DaoGradeHoraria();
                int numeroLab = Int32.Parse(cmbNumeroLaboratorio.Text);
                string anoSemestre = this.daoGH.pegarAnoSemestreMaisRecente(numeroLab);

                if (anoSemestre == null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Não há grade horária cadastrada! Você deseja cadastrar?", "Sem grade horária para este laboratório", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        Program.frmTelaPrincipal.abrirFormulario(new frmMontagemGradeHoraria(numeroLab, null));
                }
                else
                {
                    Program.frmTelaPrincipal.abrirFormulario(new frmConsultaGradeHorarioVigente(numeroLab, anoSemestre));
                }
            }
            else
                MessageBox.Show("Selecione um número de laboratório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
