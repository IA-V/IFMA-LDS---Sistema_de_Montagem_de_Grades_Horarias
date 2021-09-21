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
        public frmCadastroProfessores(Professor prof)
        {
            InitializeComponent();
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
            int idprofessor = Int32.Parse(txtIdProfessor.Text);
            string matricula = txtMatricula.Text;
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;

            if (Utils.verificaCPF(cpf))
            {
                if((matricula.Length == 6))
                {
                    Professor professor = new Professor(idprofessor, matricula, nome, cpf, true);

                    DaoProfessor daoprofessor = new DaoProfessor();
                    int resultado = 0;
                    if (idprofessor > 0)
                        resultado = daoprofessor.alterarProfessorBD(professor);
                    else
                        resultado = daoprofessor.salvarProfessorBD(professor);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chamarTelaConsultaProfessores();

                    }
                    else
                        MessageBox.Show("Verifique a matrícula e o CPF inseridos, talvez algum já exista.", "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Matrícula inserida inválida!");
                    txtMatricula.Text = "";
                }
            }
            else
            {
                MessageBox.Show("CPF inserido inválido!");
                txtCPF.Text = "";
            }
        }

        private void chamarTelaConsultaProfessores()
        {
            frmConsultaProfessores consProf = new frmConsultaProfessores();
            consProf.MdiParent = Program.frmTelaPrincipal;
            consProf.Show();
            this.Dispose();
        }
    }
}
