using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MontagemDeHorariosLabs.dao;

namespace MontagemDeHorariosLabs.view
{
    public partial class frmConsultaProfessores : Form
    {
        public frmConsultaProfessores()
        {
            InitializeComponent();
            preencherDataGridView(null);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text.Trim() == "")
            {
                preencherDataGridView(null);
            }
            else
            {
                preencherDataGridView(txtMatricula.Text);
                if (dgvProfessores.Rows.Count == 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Professor inexistente. Você deseja criar um professor com essa matrícula?", "Criação de Professor", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Professor prof = new Professor(0, txtMatricula.Text, "", "", false);
                        chamarTelaCadastroProfessores(prof);
                    }
                    else
                    {
                        preencherDataGridView(null);
                    }
                }
            }
        }

        public void preencherDataGridView(string filtro)
        {
            DaoProfessor daoprofessor = new DaoProfessor();
            List<Professor> listaprofessores = daoprofessor.buscarProfessorBD(filtro);
            string[] dados = new string[4];
            dgvProfessores.Rows.Clear();

            foreach (Professor prof in listaprofessores)
            {
                if (prof.isStatus())
                {
                    dados[0] = prof.getIdProfessor().ToString();
                    dados[1] = prof.getNome();
                    dados[2] = prof.getMatricula();
                    dados[3] = prof.getCpf();
                    dgvProfessores.Rows.Add(dados);
                }
            }
        }

        private void btnBarraDeletar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            DaoProfessor daoProfessor = new DaoProfessor();
            foreach (DataGridViewRow linha in dgvProfessores.Rows)
            {
                if (Convert.ToBoolean(linha.Cells[4].EditedFormattedValue))
                {
                    int idProfessor = Int32.Parse(linha.Cells[0].Value.ToString());
                    string nome = linha.Cells[1].Value.ToString();
                    string matricula = linha.Cells[2].Value.ToString();
                    string cpf = linha.Cells[3].Value.ToString();
                    Professor p = new Professor(idProfessor, matricula, nome, cpf, false);

                    resultado = daoProfessor.alterarProfessorBD(p);
                }
            }
            if (resultado > 0)
            {
                MessageBox.Show("Professor(es) desligado(s) com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            preencherDataGridView(null);
        }

        private void dgvProfessores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProfessor = Int32.Parse(dgvProfessores.CurrentRow.Cells[0].Value.ToString());
            string nome = dgvProfessores.CurrentRow.Cells[1].Value.ToString();
            string matricula = dgvProfessores.CurrentRow.Cells[2].Value.ToString();
            string cpf = dgvProfessores.CurrentRow.Cells[3].Value.ToString();
            Professor p = new Professor(idProfessor, matricula, nome, cpf, true);

            chamarTelaCadastroProfessores(p);
        }

        private void chamarTelaCadastroProfessores(Professor prof)
        {
            frmCadastroProfessores cadProf = new frmCadastroProfessores(prof);
            cadProf.MdiParent = Program.frmTelaPrincipal;
            cadProf.Show();
            this.Dispose();
        }
    }
}
