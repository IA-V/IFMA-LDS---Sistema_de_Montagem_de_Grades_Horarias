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
    public partial class frmCadastroDisciplinas : Form
    {
        public frmCadastroDisciplinas(DisciplinaTecnica disc)
        {
            InitializeComponent();
            if(disc != null)
            {
                preencherCampos(disc);
            }
        }

        private void preencherCampos(DisciplinaTecnica disc)
        {
            txtIdDisciplina.Text = disc.getIdDisciplinaTecnica().ToString();
            txtNome.Text = disc.getNome();
            txtSigla.Text = disc.getSigla();
            txtCargaHoraria.Text = disc.getCargaHoraria().ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnPadraoSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            int idDisciplina = Int32.Parse(txtIdDisciplina.Text);
            string sigla = txtSigla.Text;
            string nome = txtNome.Text;
            int ch = Int32.Parse(txtCargaHoraria.Text);
                
            DisciplinaTecnica disc = new DisciplinaTecnica(idDisciplina, nome, sigla, ch);

            DaoDisciplinaTecnica daoDisciplina = new DaoDisciplinaTecnica();
            int resultado = 0;
            if (idDisciplina > 0)
                resultado = daoDisciplina.alterarDisciplinaTecnicaBD(disc);
            else
                resultado = daoDisciplina.salvarDisciplinaTecnicaBD(disc);

            if (resultado > 0)
            {
                MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chamarTelaConsultaDisciplinas();

            }
            else
                MessageBox.Show("Verifique a sigla e o nome inseridos, talvez algum já exista.", "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chamarTelaConsultaDisciplinas()
        {
            frmConsultaDisciplinas consDisc = new frmConsultaDisciplinas();
            consDisc.MdiParent = Program.frmTelaPrincipal;
            consDisc.Show();
            this.Dispose();
        }
    }
}
