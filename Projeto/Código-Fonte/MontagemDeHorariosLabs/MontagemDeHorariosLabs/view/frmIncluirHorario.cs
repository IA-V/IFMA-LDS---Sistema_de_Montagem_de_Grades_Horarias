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
    public partial class frmIncluirHorario : Form
    {
        private Horario horario;
        private DaoProfessor daoProfessor;
        private DaoDisciplinaTecnica daoDisciplinaTecnica;

        public Horario GetHorario()
        {
            return this.horario;
        }

        public void SetHorario(Horario novoHorario)
        {
            this.horario = novoHorario;
        }

        public frmIncluirHorario()
        {
            InitializeComponent();
            this.daoProfessor = new DaoProfessor();
            this.daoDisciplinaTecnica = new DaoDisciplinaTecnica();
            preencherComboBoxNomeProfessor();
            preencherComboBoxSiglaDisciplina();
        }

        private void preencherComboBoxNomeProfessor()
        {
            List<Professor> professores = daoProfessor.buscarProfessorBD(null);
            foreach (Professor prof in professores)
                if (prof != null)
                    cmbNomeProfessor.Items.Add(prof.getNome());
                else
                    MessageBox.Show("Você precisa cadastrar algum professor para poder usar essa funcionalidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void preencherComboBoxSiglaDisciplina()
        {
            List<DisciplinaTecnica> disciplinas = daoDisciplinaTecnica.buscarDisciplinasTecnicasBD(null);
            foreach (DisciplinaTecnica disc in disciplinas)
                if (disc != null)
                    cmbSiglaDisciplina.Items.Add(disc.getSigla() + " - " + disc.getNome());
                else
                    MessageBox.Show("Você precisa cadastrar alguma disciplina para poder usar essa funcionalidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string siglaDisciplina = cmbSiglaDisciplina.Text;
            string nomeProfessor = cmbNomeProfessor.Text;
            string turma = txtTurma.Text;
            string intervaloHorario = cmbHorario.Text;
            string diaSemana = cmbDiaSemana.Text;

            DisciplinaTecnica discTec = extrairDiscTec(daoDisciplinaTecnica.buscarDisciplinasTecnicasBD(siglaDisciplina));
            Professor prof = daoProfessor.buscarProfessorPeloNomeBD(nomeProfessor);

            this.horario = new Horario(0, diaSemana, intervaloHorario, turma, prof, discTec);

            this.DialogResult = DialogResult.OK;
        }

        private DisciplinaTecnica extrairDiscTec(List<DisciplinaTecnica> disciplinas)
        {
            foreach (DisciplinaTecnica discTec in disciplinas)
                return discTec;
            return null;
        }
    }
}
