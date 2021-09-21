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
        private Coordenador coordenadorLogado;
        private DaoCoordenador daoCoord;

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
            this.daoCoord = new DaoCoordenador();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string senha = Utils.SHA256(txtSenha.Text);

            Coordenador coord = daoCoord.buscarCoordenadorBD(matricula);
            if (coord != null)
            {
                if (coord.isVigente())
                {
                    if (senha.Equals(coord.getSenha()))
                    {
                        this.SetCoordenador(coord);
                        MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Senha inserida não corresponde à matrícula!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Essa matrícula corresponde a um ex-coordenador! Insira a matrícula do coordenador atual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatricula.Text = "";
                }     
            }
            else
            {
                MessageBox.Show("Matrícula inserida inexistente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Text = "";
            }
        }
    }
}
