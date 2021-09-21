using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MontagemDeHorariosLabs.dao;

namespace MontagemDeHorariosLabs.view
{
    public partial class frmCadastroProfessores : Form
    {
        private DaoProfessor daoprofessor;

        public frmCadastroProfessores(Professor prof)
        {
            InitializeComponent();
            txtMatricula.Enabled = false;

            if (prof != null)
                preencherCampos(prof);
        }

        private void preencherCampos(Professor prof)
        {
            txtIdProfessor.Text = prof.getIdProfessor().ToString();
            txtNome.Text = prof.getNome();
            txtCPF.Text = prof.getCpf();
            txtMatricula.Text = prof.getMatricula();
        }

        private bool verificaCondicoesParaSalvar()
        {
            if (txtNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira um nome para o professor!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else if (txtCPF.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira um cpf para o professor!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
            }
            else if (txtMatricula.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira uma matrícula para o professor!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
            }
            else if (!Utils.verificaCPF(txtCPF.Text))
            {
                MessageBox.Show("CPF inserido inválido!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
            }
            else if (txtMatricula.Text.Length != 6)
            {
                MessageBox.Show("Matrícula inserida inválida!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
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
            int idprofessor = Int32.Parse(txtIdProfessor.Text);
            string matricula = txtMatricula.Text;
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            Professor professor = new Professor(idprofessor, matricula, nome, cpf, true);

            this.daoprofessor = new DaoProfessor();
            int resultado = 0;
            if (idprofessor > 0)
                resultado = daoprofessor.alterarProfessorBD(professor);
            else
                resultado = daoprofessor.salvarProfessorBD(professor);

            if (resultado > 0)
            {
                MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.frmTelaPrincipal.abrirFormulario(new frmConsultaProfessores());
            }
            else
            {   
                MessageBox.Show("Verifique o CPF inserido, talvez ele já exista.", "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
