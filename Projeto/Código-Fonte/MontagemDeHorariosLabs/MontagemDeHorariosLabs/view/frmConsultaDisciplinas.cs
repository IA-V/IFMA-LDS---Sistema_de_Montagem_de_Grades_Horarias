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
    public partial class frmConsultaDisciplinas : Form
    {
        public frmConsultaDisciplinas()
        {
            InitializeComponent();
            preencherDataGridView(null);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtSigla.Text.Trim() == "")
            {
                preencherDataGridView(null);
            }
            else
            {
                preencherDataGridView(txtSigla.Text);
                if (dgvDisciplinas.Rows.Count == 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Disciplina inexistente. Você deseja criar uma disciplina com essa sigla?", "Criação de Disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        DisciplinaTecnica disc = new DisciplinaTecnica(0, "", txtSigla.Text, 0);
                        chamarTelaCadastroDisciplinas(disc);
                    }
                    else
                    {
                        preencherDataGridView(null);
                    }
                }
            }
        }

        private void preencherDataGridView(string filtro)
        {
            DaoDisciplinaTecnica daoDisc = new DaoDisciplinaTecnica();
            List<DisciplinaTecnica> listaDisciplinas = daoDisc.buscarDisciplinasTecnicasBD(filtro);
            string[] dados = new string[4];
            dgvDisciplinas.Rows.Clear();

            foreach (DisciplinaTecnica disc in listaDisciplinas)
            {
                dados[0] = disc.getIdDisciplinaTecnica().ToString();
                dados[1] = disc.getNome();
                dados[2] = disc.getCargaHoraria().ToString();
                dados[3] = disc.getSigla();
                dgvDisciplinas.Rows.Add(dados);
                
            }
        }

        private void chamarTelaCadastroDisciplinas(DisciplinaTecnica disc)
        {
            frmCadastroDisciplinas frmCadDisc = new frmCadastroDisciplinas(disc);
            frmCadDisc.MdiParent = Program.frmTelaPrincipal;
            frmCadDisc.Show();
            this.Dispose();
        }

        private void dgvDisciplinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idDisc = Int32.Parse(dgvDisciplinas.CurrentRow.Cells[0].Value.ToString());
            string nome = dgvDisciplinas.CurrentRow.Cells[1].Value.ToString();
            int ch = Int32.Parse(dgvDisciplinas.CurrentRow.Cells[2].Value.ToString());
            string sigla = dgvDisciplinas.CurrentRow.Cells[3].Value.ToString();
            DisciplinaTecnica disc = new DisciplinaTecnica(idDisc, nome, sigla, ch);
            chamarTelaCadastroDisciplinas(disc);
        }
    }
}
