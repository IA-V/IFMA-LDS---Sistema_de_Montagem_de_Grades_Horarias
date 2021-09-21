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
    public partial class frmTrocaCoordenadores : Form
    {
        Coordenador coordenadorAtual;
        DaoCoordenador daoCoordenador;
        DaoProfessor daoProfessor;

        public frmTrocaCoordenadores()
        {
            InitializeComponent();

            this.coordenadorAtual = Program.frmTelaPrincipal.GetCoordenador();
            txtMatriculaCoordAtual.Text = coordenadorAtual.getProfessor().getMatricula();
            txtMatriculaCoordAtual.Enabled = false;
            txtSenhaCoordAtual.Focus();
        }

        private bool condicoesParaConfirmar()
        {
            if (txtMatriculaCoordAtual.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira a matrícula do coordenador atual!", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatriculaCoordAtual.Focus();
            }
            else if (txtSenhaCoordAtual.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira a senha do coordenador atual!", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaCoordAtual.Focus();
            }
            else if (txtMatriculaNovoCoord.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira a matrícula do novo coordenador!", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatriculaNovoCoord.Focus();
            }
            else if (txtSenhaNovoCoord.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira a senha do novo coordenador!", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaNovoCoord.Focus();
            }
            else if (txtConfirmarSenhaNovoCoord.Text.Trim().Equals(""))
            {
                MessageBox.Show("Confirme a senha do novo coordenador!", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarSenhaNovoCoord.Focus();
            }
            else
                return true;
            return false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (condicoesParaConfirmar())
                confirmarTrocaCoordenadores();
        }

        private void confirmarTrocaCoordenadores()
        {
            this.daoCoordenador = new DaoCoordenador();
            this.daoProfessor = new DaoProfessor();

            string matriculaNovoCoord = txtMatriculaNovoCoord.Text;
            string senhaCoordAtual = Utils.SHA256(txtSenhaCoordAtual.Text);
            string senhaNovoCoord = Utils.SHA256(txtSenhaNovoCoord.Text);
            string confirmarSenhaNovoCoord = Utils.SHA256(txtConfirmarSenhaNovoCoord.Text);

            if (senhaCoordAtual.Equals(coordenadorAtual.getSenha()))
            {
                Professor profNaoCoordenador = daoProfessor.buscarProfessorPelaMatriculaBD(matriculaNovoCoord);
                if (profNaoCoordenador != null)
                {
                    if (!matriculaNovoCoord.Equals(txtMatriculaCoordAtual.Text))
                    {
                        if (profNaoCoordenador.isStatus())
                        {
                            if (senhaNovoCoord.Equals(confirmarSenhaNovoCoord))
                            {
                                Coordenador novoCoordenador = new Coordenador(0, true, profNaoCoordenador, senhaNovoCoord);
                                int resultado = daoCoordenador.salvarCoordenadorBD(novoCoordenador);
                                if (resultado > 0)
                                {
                                    this.coordenadorAtual.setVigencia(false);
                                    this.daoCoordenador.alterarCoordenadorBD(coordenadorAtual);
                                    MessageBox.Show("Novo Coordenador cadastrado com sucesso! Realize o login novamente para terminar a troca.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.relogar();
                                    this.Dispose();
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao salvar coordenador! Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Senhas do Novo Coordenador incompatíveis!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                txtSenhaNovoCoord.Text = "";
                                txtSenhaNovoCoord.Focus();
                                txtConfirmarSenhaNovoCoord.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("A matrícula inserida corresponde a um professor desligado!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            txtMatriculaNovoCoord.Text = "";
                            txtMatriculaNovoCoord.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A matrícula inserida é a do um coordenador atual!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        txtMatriculaNovoCoord.Text = "";
                        txtMatriculaNovoCoord.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Matrícula do Novo Coordenador não existente!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtMatriculaNovoCoord.Text = "";
                    txtMatriculaNovoCoord.Focus();
                }
            }
            else
            {
                MessageBox.Show("Senha do Coordenador Atual não corresponde à matrícula!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSenhaCoordAtual.Text = "";
                txtSenhaCoordAtual.Focus();
            }
        }

        private void relogar()
        {
            Program.frmTelaPrincipal.Hide();
            frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Program.frmTelaPrincipal.SetCoordenador(frmLogin.GetCoordenador());
                Program.frmTelaPrincipal.Show();
                frmLogin.Dispose();
            }
        }
    }
}
