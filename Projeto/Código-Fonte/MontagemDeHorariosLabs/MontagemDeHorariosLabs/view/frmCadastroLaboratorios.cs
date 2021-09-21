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
    public partial class frmCadastroLaboratorios : Form
    {
        public frmCadastroLaboratorios(Laboratorio lab)
        {
            InitializeComponent();
            if(lab != null)
            {
                preencherCampos(lab);
            }
        }

        private void preencherCampos(Laboratorio lab)
        {
            txtIdLaboratorio.Text = lab.getIdLaboratorio().ToString();
            txtNumero.Text = lab.getNumero().ToString();
            txtQuantMaquinas.Text = lab.getQuantComp().ToString();
            txtLocalizacao.Text = lab.getLocalizacao();
        }

        private void salvar()
        {
            int idLaboratorio = Int32.Parse(txtIdLaboratorio.Text);
            string localizacao = txtLocalizacao.Text;
            int quantComp = Int32.Parse(txtQuantMaquinas.Text);
            int numero = Int32.Parse(txtNumero.Text);

            Laboratorio lab = new Laboratorio(idLaboratorio, numero, quantComp, localizacao);

            DaoLaboratorio daoLaboratorio = new DaoLaboratorio();
            int resultado = 0;
            if (idLaboratorio > 0)
                resultado = daoLaboratorio.alterarLaboratorioBD(lab);
            else
                resultado = daoLaboratorio.salvarLaboratorioBD(lab);

            if (resultado > 0)
            {
                MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chamarTelaConsultaLaboratorios();

            }
            else
                MessageBox.Show("Verifique o número inserido, talvez ele já exista.", "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chamarTelaConsultaLaboratorios()
        {
            frmConsultaLaboratorios consLabs = new frmConsultaLaboratorios();
            consLabs.MdiParent = Program.frmTelaPrincipal;
            consLabs.Show();
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnPadraoSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}
