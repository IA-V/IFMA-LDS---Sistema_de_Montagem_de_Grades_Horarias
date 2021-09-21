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
        private DaoLaboratorio daoLaboratorio;

        public frmCadastroLaboratorios(Laboratorio lab)
        {
            InitializeComponent();
            txtNumero.Enabled = false;

            if (lab != null)
                preencherCampos(lab);
        }

        private void preencherCampos(Laboratorio lab)
        {
            txtIdLaboratorio.Text = lab.getIdLaboratorio().ToString();
            txtNumero.Text = lab.getNumero().ToString();
            txtQuantMaquinas.Text = lab.getQuantComp().ToString();
            txtLocalizacao.Text = lab.getLocalizacao();
        }

        private bool verificaCondicoesParaSalvar()
        {
            if (txtNumero.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira um número para o laboratório!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
            }
            else if (txtQuantMaquinas.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira uma quantidade de máquinas para o laboratório!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantMaquinas.Focus();
            }
            else if (txtLocalizacao.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira uma localização para o laboratório!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocalizacao.Focus();
            }
            else if (Int32.Parse(txtQuantMaquinas.Text.Trim()) <= 0)
            {
                MessageBox.Show("Insira uma quantidade de computadores para o laboratório maior que 0!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantMaquinas.Focus();
            }
            else
                return true;
            return false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(verificaCondicoesParaSalvar())
                salvar();
        }
        private void btnPadraoSalvar_Click(object sender, EventArgs e)
        {
            if(verificaCondicoesParaSalvar())
                salvar();
        }
        private void salvar()
        {
            try
            {
                int idLaboratorio = Int32.Parse(txtIdLaboratorio.Text);
                string localizacao = txtLocalizacao.Text;
                int quantComp = Int32.Parse(txtQuantMaquinas.Text);
                int numero = Int32.Parse(txtNumero.Text);
                Laboratorio lab = new Laboratorio(idLaboratorio, numero, quantComp, localizacao);

                this.daoLaboratorio = new DaoLaboratorio();
                int resultado = 0;
                if (idLaboratorio > 0)
                    resultado = this.daoLaboratorio.alterarLaboratorioBD(lab);
                else
                    resultado = this.daoLaboratorio.salvarLaboratorioBD(lab);
                if (resultado > 0)
                {
                    MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.frmTelaPrincipal.abrirFormulario(new frmConsultaLaboratorios());
                }
                else
                    MessageBox.Show("Verifique o número inserido, talvez ele já exista.", "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FormatException fe)
            {
                MessageBox.Show("Verifique a quantidade de computadores inserida, ela não corresponde a um número!", "Formato incompatível!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
