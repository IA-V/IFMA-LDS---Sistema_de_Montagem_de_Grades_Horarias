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
        private DaoProfessor daoProfessor;
        private DaoDisciplinaTecnica daoDisciplinaTecnica;

        private Horario horario;
        public Horario GetHorario()
        {
            return this.horario;
        }
        public void SetHorario(Horario novoHorario)
        {
            this.horario = novoHorario;
        }

        public frmIncluirHorario(Horario horario)
        {
            InitializeComponent();

            this.daoProfessor = new DaoProfessor();
            this.daoDisciplinaTecnica = new DaoDisciplinaTecnica();

            preencherComboBoxNomeProfessor();
            preencherComboBoxSiglaDisciplina();
            txtIDHorario.Text = "0";

            this.horario = horario;
            if (horario != null)
                preencherCampos(horario);
        }

        private void preencherComboBoxNomeProfessor()
        {
            List<Professor> professores = daoProfessor.buscarProfessoresVigentesBD();
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
                    cmbSiglaDisciplina.Items.Add(disc.getSigla());
                else
                    MessageBox.Show("Você precisa cadastrar alguma disciplina para poder usar essa funcionalidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void preencherCampos(Horario horario)
        {
            txtIDHorario.Text = horario.getIdHorario().ToString();
            if(horario.getTurma() != null)
                txtTurma.Text = horario.getTurma();
            if(horario.getProfessor() != null)
                cmbNomeProfessor.SelectedItem = horario.getProfessor().getNome();
            if(horario.getDisciplina() != null)
                cmbSiglaDisciplina.SelectedItem = horario.getDisciplina().getSigla();
            cmbHorario.SelectedItem = horario.getHorario();
            cmbDiaSemana.SelectedItem = horario.getDiaSemana();
        }

        private bool verificaCondicoesParaSalvar()
        {
            if (cmbNomeProfessor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um nome para o professor!", "Campo não selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNomeProfessor.Focus();
            }
            else if (cmbSiglaDisciplina.Text.Trim().Equals(""))
            {
                MessageBox.Show("Selecione uma sigla para a disciplina!", "Campo não selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSiglaDisciplina.Focus();
            }
            else if (txtTurma.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira uma turma para o horário sendo incluído!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTurma.Focus();
            }
            else if (cmbHorario.Text.Trim().Equals(""))
            {
                MessageBox.Show("Selecione um intervalo de horários!", "Campo não selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHorario.Focus();
            }
            else if (cmbDiaSemana.Text.Trim().Equals(""))
            {
                MessageBox.Show("Selecione um dia da semana!", "Campo não selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDiaSemana.Focus();
            }
            else
                return true;
            return false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (verificaCondicoesParaSalvar())
                salvar();
        }

        private void salvar()
        {
            int idHorario = Int32.Parse(txtIDHorario.Text);
            string siglaDisciplina = cmbSiglaDisciplina.Text;
            string nomeProfessor = cmbNomeProfessor.Text;
            string turma = txtTurma.Text;
            string intervaloHorario = cmbHorario.Text;
            string diaSemana = cmbDiaSemana.Text;

            DisciplinaTecnica discTec = daoDisciplinaTecnica.buscarDisciplinaTecnicaBD(siglaDisciplina);
            Professor prof = daoProfessor.buscarProfessorPeloNomeBD(nomeProfessor);

            this.horario = new Horario(idHorario, diaSemana, intervaloHorario, turma, prof, discTec);
            if (DialogResult.Yes == MessageBox.Show("Deseja incluir esse horário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
