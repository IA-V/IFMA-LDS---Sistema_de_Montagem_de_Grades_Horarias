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
        private DaoDisciplinaTecnica daoDisciplina;

        public frmCadastroDisciplinas(DisciplinaTecnica disciplina)
        {
            InitializeComponent();
            txtSigla.Enabled = false;

            if (disciplina != null)
                preencherCampos(disciplina);
        }

        private void preencherCampos(DisciplinaTecnica disciplina)
        {
            txtIdDisciplina.Text = disciplina.getIdDisciplinaTecnica().ToString();
            txtNome.Text = disciplina.getNome();
            txtSigla.Text = disciplina.getSigla();
            txtCargaHoraria.Text = disciplina.getCargaHoraria().ToString();
        }

        private bool verificaCondicoesParaSalvar()
        {
            if (txtNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira um nome para a disciplina!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else if (txtSigla.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira uma sigla para a disciplina!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSigla.Focus();
            }
            else if (txtCargaHoraria.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira uma carga horária para a disciplina!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargaHoraria.Focus();
            }
            else if(Int32.Parse(txtCargaHoraria.Text.Trim()) <= 0)
            {
                MessageBox.Show("Insira uma carga horária para a disciplina maior que 0!", "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargaHoraria.Focus();
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
                int idDisciplina = Int32.Parse(txtIdDisciplina.Text);
                string sigla = txtSigla.Text;
                string nome = txtNome.Text;
                int ch = Int32.Parse(txtCargaHoraria.Text);
                DisciplinaTecnica disc = new DisciplinaTecnica(idDisciplina, nome, sigla, ch);

                this.daoDisciplina = new DaoDisciplinaTecnica();
                int resultado = 0;
                if (idDisciplina > 0)
                    resultado = this.daoDisciplina.alterarDisciplinaTecnicaBD(disc);
                else
                    resultado = this.daoDisciplina.salvarDisciplinaTecnicaBD(disc);

                if (resultado > 0)
                {
                    MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.frmTelaPrincipal.abrirFormulario(new frmConsultaDisciplinas());
                }
                else
                    MessageBox.Show("Verifique o nome inserido, talvez ele já exista.", "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Verifique a carga horária inserida, ela não corresponde a um número!", "Formato Incompatível!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
