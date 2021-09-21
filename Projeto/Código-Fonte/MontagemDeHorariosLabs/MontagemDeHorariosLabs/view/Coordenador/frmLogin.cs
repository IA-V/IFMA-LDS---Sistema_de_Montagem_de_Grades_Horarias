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
    public partial class frmLogin : Form
    {
        private DaoCoordenador daoCoord;
        private Coordenador coordenadorLogado;

        public Coordenador GetCoordenador()
        {
            return this.coordenadorLogado;
        }

        public void SetCoordenador(Coordenador coord)
        {
            this.coordenadorLogado = coord;
        }

        public frmLogin()
        {
            InitializeComponent();
            DaoProfessor daoP = new DaoProfessor();
            List<Professor> profs = daoP.buscarProfessorBD(null);
            MessageBox.Show(profs.Count.ToString());
        }

        private bool condicoesParaEntrar()
        {
            if (txtMatricula.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira a sua matrícula!", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
            }
            else if (txtSenha.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira a sua senha!", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
            }
            else
                return true;
            return false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (condicoesParaEntrar())
                entrar();
        }

        private void entrar()
        {
            string matricula = txtMatricula.Text;
            string senha = Utils.SHA256(txtSenha.Text);

            this.daoCoord = new DaoCoordenador();
            Coordenador coord = daoCoord.buscarCoordenadorBD(matricula);
            if (coord != null)
            {
                if (coord.isVigente())
                {
                    if (senha.Equals(coord.getSenha()))
                    {
                        this.SetCoordenador(coord);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Senha inserida não corresponde à matrícula!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Text = "";
                        txtSenha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Essa matrícula corresponde a um ex-coordenador! Insira a matrícula do coordenador atual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatricula.Text = "";
                    txtMatricula.Focus();
                }
            }
            else
            {
                MessageBox.Show("Matrícula inserida inexistente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Text = "";
                txtMatricula.Focus();
            }
        }
    }
}
