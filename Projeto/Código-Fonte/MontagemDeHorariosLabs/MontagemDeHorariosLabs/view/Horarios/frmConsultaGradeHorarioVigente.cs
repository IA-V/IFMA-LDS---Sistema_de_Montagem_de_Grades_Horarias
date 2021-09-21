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
    public partial class frmConsultaGradeHorarioVigente : Form
    {
        private int numeroLab;
        private string anoSemestre;
        private GradeHoraria grade;
        private frmIncluirHorario frmIncluirHorario;
        private DaoGradeHoraria daoGH = new DaoGradeHoraria();
        private DaoHorario daoH = new DaoHorario();

        public frmConsultaGradeHorarioVigente(int numeroLab, string anoSemestre)
        {
            InitializeComponent();

            this.numeroLab = numeroLab;
            listaHorarioslbl.Text = "Lista de Horários [Laboratório " + numeroLab + "]";

            if (anoSemestre != null)
            {
                this.anoSemestre = anoSemestre;
                preencherDataGridView();
            }
        }

        private void preencherDataGridView()
        {
            this.daoGH = new DaoGradeHoraria();

            GradeHoraria gh = this.daoGH.buscarGradeHoraria(this.numeroLab, this.anoSemestre);
            this.grade = gh;
            this.preencherDGVColunaHorarios();
            foreach (Horario horario in gh.GetListaHorarios())
                this.incluirHorarioNaGrade(horario);
        }

        public void preencherDGVColunaHorarios()
        {
            string[] dados = new string[7];
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    dados[0] = "07:15 - 08:05";
                if (i == 1)
                    dados[0] = "08:05 - 08:55";
                if (i == 2)
                    dados[0] = "08:55 - 09:45";
                if (i == 3)
                    dados[0] = "09:45 - 10:35";
                if (i == 4)
                    dados[0] = "10:50 - 11:40";
                if (i == 5)
                    dados[0] = "11:40 - 12:30";
                if (i == 6)
                    dados[0] = "13:10 - 14:00";
                if (i == 7)
                    dados[0] = "14:00 - 14:50";
                if (i == 8)
                    dados[0] = "14:50 - 15:40";
                if (i == 9)
                    dados[0] = "15:40 - 16:30";
                dados[1] = "";
                dados[2] = "";
                dados[3] = "";
                dados[4] = "";
                dados[5] = "";
                dados[6] = "";
                this.dgvGradeHoraria.Rows.Add(dados);
            }
        }

        public void incluirHorarioNaGrade(Horario horario)
        {
            int diaSemana = 0;

            if (horario.getDiaSemana().Equals("Segunda"))
                diaSemana = 1;
            else if (horario.getDiaSemana().Equals("Terça"))
                diaSemana = 2;
            else if (horario.getDiaSemana().Equals("Quarta"))
                diaSemana = 3;
            else if (horario.getDiaSemana().Equals("Quinta"))
                diaSemana = 4;
            else if (horario.getDiaSemana().Equals("Sexta"))
                diaSemana = 5;
            else if (horario.getDiaSemana().Equals("Sábado"))
                diaSemana = 6;

            int horario1 = 0, horario2 = 0;

            if (horario.getHorario().Equals("07:15 - 08:55"))
            {
                horario1 = 0;
                horario2 = 1;
            }
            else if (horario.getHorario().Equals("08:55 - 10:35"))
            {
                horario1 = 2;
                horario2 = 3;
            }
            else if (horario.getHorario().Equals("10:50 - 12:30"))
            {
                horario1 = 4;
                horario2 = 5;
            }
            else if (horario.getHorario().Equals("13:10 - 14:50"))
            {
                horario1 = 6;
                horario2 = 7;
            }
            else if (horario.getHorario().Equals("14:50 - 16:30"))
            {
                horario1 = 8;
                horario2 = 9;
            }
            dgvGradeHoraria.Rows[horario1].Cells[diaSemana].Value = horario.getDisciplina().getNome()
                + "/" + horario.getTurma() + "/" + horario.getProfessor().getNome();
            dgvGradeHoraria.Rows[horario2].Cells[diaSemana].Value = horario.getDisciplina().getNome()
                    + "/" + horario.getTurma() + "/" + horario.getProfessor().getNome();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            new frmConsultasEspecificas(this.grade).Show();
        }

        private void dgvGradeHoraria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string intervaloHorario = dgvGradeHoraria.CurrentRow.Cells[0].Value.ToString();
            string horarioCompleto = Utils.extrairHorarioCompleto(intervaloHorario);
            string diaSemana = dgvGradeHoraria.Columns[dgvGradeHoraria.CurrentCell.ColumnIndex].HeaderText;
            Horario horarioAntigo = null;

            int i = 0;
            string horarioExtenso = dgvGradeHoraria.CurrentCell.Value.ToString();
            if (horarioExtenso == "")
            {
                if (DialogResult.Yes == MessageBox.Show("Você deseja acrescentar um horário neste espaço?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    horarioAntigo = new Horario(0, diaSemana, horarioCompleto, null, null, null);
                    i++;
                }
            }
            else if (DialogResult.Yes == MessageBox.Show("Você deseja realmente alterar este horário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                i++;
                string[] horarioQuebrado = horarioExtenso.Split('/');
                string nomeDisciplina = horarioQuebrado[0];
                string turma = horarioQuebrado[1];
                string nomeProfessor = horarioQuebrado[2];
                foreach (Horario horario in grade.GetListaHorarios())
                {
                    if((horario.getHorario().Equals(horarioCompleto)) 
                        && (horario.getDisciplina().getNome().Equals(nomeDisciplina)) 
                        && (horario.getTurma().Equals(turma))
                        && (horario.getProfessor().getNome().Equals(nomeProfessor)) 
                        && (horario.getDiaSemana().Equals(diaSemana)))
                    {
                        horarioAntigo = horario;
                    }
                }
            }
            if(i > 0)
            {
                this.frmIncluirHorario = new frmIncluirHorario(horarioAntigo);
                if (this.frmIncluirHorario.ShowDialog() == DialogResult.OK)
                {
                    Horario horarioNovo = this.frmIncluirHorario.GetHorario();
                    if (!verificarExistenciaDeHorarioNaGrade(horarioNovo.getHorario(), horarioNovo.getDiaSemana()))
                    {
                        this.frmIncluirHorario.Dispose();
                        if (horarioAntigo.getIdHorario() == 0)
                        {
                            this.daoH.salvarHorarioBD(horarioNovo);
                            this.daoH.salvarHorario_GradeHorariaBD(this.daoH.buscarIDHorarioBD(horarioNovo), this.grade.getIdGradeHoraria());
                        }
                        else
                            this.daoH.alterarHorarioBD(horarioNovo);
                        dgvGradeHoraria.Rows.Clear();
                        this.preencherDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Já existe horários cadastrados nesse intervalo e dia da semana!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private bool verificarExistenciaDeHorarioNaGrade(string intervalohorario, string diaSemanaString)
        {
            int diaSemana = 0;

            if (diaSemanaString.Equals("Segunda"))
                diaSemana = 1;
            else if (diaSemanaString.Equals("Terça"))
                diaSemana = 2;
            else if (diaSemanaString.Equals("Quarta"))
                diaSemana = 3;
            else if (diaSemanaString.Equals("Quinta"))
                diaSemana = 4;
            else if (diaSemanaString.Equals("Sexta"))
                diaSemana = 5;
            else if (diaSemanaString.Equals("Sábado"))
                diaSemana = 6;

            int horario1 = 0;

            if (intervalohorario.Equals("07:15 - 08:55"))
            {
                horario1 = 0;
            }
            else if (intervalohorario.Equals("08:55 - 10:35"))
            {
                horario1 = 2;
            }
            else if (intervalohorario.Equals("10:50 - 12:30"))
            {
                horario1 = 4;
            }
            else if (intervalohorario.Equals("13:10 - 14:50"))
            {
                horario1 = 6;
            }
            else if (intervalohorario.Equals("14:50 - 16:30"))
            {
                horario1 = 8;
            }

            if (this.dgvGradeHoraria.Rows[horario1].Cells[diaSemana].Value.Equals(""))
                return false;
            else
                return true;
        }

        private void btnBarraMudarGHV_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Você deseja realmente mudar a grade horária em vigência?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Program.frmTelaPrincipal.abrirFormulario(new frmMontagemGradeHoraria(this.numeroLab, this.anoSemestre));
        }
    }
}
