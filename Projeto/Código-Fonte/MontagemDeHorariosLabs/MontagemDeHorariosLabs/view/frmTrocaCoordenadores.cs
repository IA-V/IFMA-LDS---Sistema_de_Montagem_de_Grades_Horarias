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
            txtSenhaCoordAtual.Focus();
            this.daoCoordenador = new DaoCoordenador();
            this.daoProfessor = new DaoProfessor();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string matriculaNovoCoord = txtMatriculaNovoCoord.Text;
            string senhaCoordAtual = Utils.SHA256(txtSenhaCoordAtual.Text);
            string senhaNovoCoord = Utils.SHA256(txtSenhaNovoCoord.Text);
            string confirmarSenhaNovoCoord = Utils.SHA256(txtConfirmarSenhaNovoCoord.Text);
           
            if (senhaCoordAtual.Equals(coordenadorAtual.getSenha()))
            {
                Professor profNaoCoordenador = this.extrairProfessor(daoProfessor.buscarProfessorBD(matriculaNovoCoord));
                if(profNaoCoordenador != null)
                {
                    if (senhaNovoCoord.Equals(confirmarSenhaNovoCoord))
                    {
                        Coordenador novoCoordenador = new Coordenador(0, true, profNaoCoordenador, senhaNovoCoord);
                        int resultado = daoCoordenador.salvarCoordenadorBD(novoCoordenador);
                        if(resultado > 0)
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
                        txtConfirmarSenhaNovoCoord.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Matrícula do Novo Coordenador não existente!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtMatriculaNovoCoord.Text = "";
                }
            }
            else
            {
               MessageBox.Show("Senha do Coordenador Atual não corresponde à matrícula inserida!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
               txtSenhaCoordAtual.Text = "";
            }
        }

        private Professor extrairProfessor(List<Professor> listaProfessor)
        {
            foreach(Professor prof in listaProfessor)
                return prof;
            return null;
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
