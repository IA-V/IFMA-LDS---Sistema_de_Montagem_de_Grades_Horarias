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
    public partial class frmMontagemGradeHoraria : Form
    {
        private int numeroLab;
        private string anoSemestreAntigo;
        private List<Horario> listaHorarios;
        private DaoGradeHoraria daoGH = new DaoGradeHoraria();
        private DaoLaboratorio daoLab = new DaoLaboratorio();

        public frmMontagemGradeHoraria(int numeroLab, string anoSemestre)
        {
            InitializeComponent();

            this.listaHorarios = new List<Horario>();
            this.lblListaHorarios.Text = "Lista de Horários [Laboratório " + numeroLab + "]";

            this.numeroLab = numeroLab;
            this.anoSemestreAntigo = anoSemestre;
            this.preencherCampoAnoSemestre();
            this.preencherDGVColunaHorarios();
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
                dgvGradeHorarioEmAndamento.Rows.Add(dados);
            }
        }

        private void preencherCampoAnoSemestre()
        {
            if(this.anoSemestreAntigo != null)
            {
                string[] strQuebrado = this.anoSemestreAntigo.Split('.');
                int ano = Int32.Parse(strQuebrado[0]);
                int semestre = Int32.Parse(strQuebrado[1]);
                if (semestre == 1)
                    semestre = 2;
                else
                {
                    semestre = 1;
                    ano++;
                }
                txtAnoSemestre.Text = ano + "." + semestre;
                txtAnoSemestre.Enabled = false;
            }
        }

        private void btnIncluirHorario_Click(object sender, EventArgs e)
        {
            frmIncluirHorario frmIncluirHorario = new frmIncluirHorario(null);
            if (frmIncluirHorario.ShowDialog() == DialogResult.OK)
            {
                Horario horario = frmIncluirHorario.GetHorario();
                if (this.incluirHorarioNaGrade(horario))
                {
                    frmIncluirHorario.Dispose();
                }
                else
                    MessageBox.Show("Você escolheu um intervalo de horários que já possui dados cadastrados! Reescolha os horários.", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        public bool incluirHorarioNaGrade(Horario horario)
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

            if (this.dgvGradeHorarioEmAndamento.Rows[horario1].Cells[diaSemana].Value.Equals(""))
            {
                this.dgvGradeHorarioEmAndamento.Rows[horario1].Cells[diaSemana].Value = horario.getDisciplina().getNome()
                + "/" + horario.getTurma() + "/" + horario.getProfessor().getNome();
                this.dgvGradeHorarioEmAndamento.Rows[horario2].Cells[diaSemana].Value = horario.getDisciplina().getNome()
                    + "/" + horario.getTurma() + "/" + horario.getProfessor().getNome();
                this.listaHorarios.Add(horario);
                return true;
            }
            else
                return false;
        }

        private bool conficoesParaConcluir()
        {
            if (this.listaHorarios.Count == 0)
            {
                MessageBox.Show("Grade Horária sem horários cadastrados! Cadastre ao menos um horário para concluir.", "Sem horários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAnoSemestre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Insira o ano/semestre para concluir.", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnoSemestre.Focus();
            }
            else
                return true;
            return false;
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (conficoesParaConcluir())
            if (DialogResult.Yes == MessageBox.Show("Você deseja salvar a grade horária em construção?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string anoSemestre = txtAnoSemestre.Text;

                Laboratorio lab = daoLab.buscarLaboratorioPeloNumeroBD(this.numeroLab);
                GradeHoraria gradeHoraria = new GradeHoraria(0, anoSemestre, this.listaHorarios, lab, true);

                mudarStatusGradeHorariaAntiga(anoSemestre);
                daoGH.salvarGradeHorariaBD(gradeHoraria);

                MessageBox.Show("Grade Horária salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.frmTelaPrincipal.abrirFormulario(new frmConsultaGradeHorarioVigente(this.numeroLab, anoSemestre));
            }
        }

        public void mudarStatusGradeHorariaAntiga(string anoSemestre)
        {
            GradeHoraria gradeHorariaAntiga;
            if (anoSemestreAntigo != null)
            {
                gradeHorariaAntiga = daoGH.buscaSimplesGradeHoraria(this.numeroLab, anoSemestreAntigo);
                gradeHorariaAntiga.setStatus(false);
                daoGH.alterarGradeHorariaBD(gradeHorariaAntiga);
            }
        }

        private void dgvGradeHorarioEmAndamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!dgvGradeHorarioEmAndamento.CurrentCell.Value.ToString().Equals(""))
                if (DialogResult.Yes == MessageBox.Show("Você deseja alterar algum dado deste horário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string intervaloHorario = dgvGradeHorarioEmAndamento.CurrentRow.Cells[0].Value.ToString();
                    string horarioCompleto = Utils.extrairHorarioCompleto(intervaloHorario);
                    string diaSemana = dgvGradeHorarioEmAndamento.Columns[dgvGradeHorarioEmAndamento.CurrentCell.ColumnIndex].HeaderText;
                    string horarioExtenso = dgvGradeHorarioEmAndamento.CurrentCell.Value.ToString();
                    string[] horarioQuebrado = horarioExtenso.Split('/');
                    string nomeDisciplina = horarioQuebrado[0];
                    string turma = horarioQuebrado[1];
                    string nomeProfessor = horarioQuebrado[2];

                    Horario horariaAMudar = null;
                    foreach (Horario horario in listaHorarios)
                    {
                        if ((horario.getHorario().Equals(horarioCompleto))
                            && (horario.getDisciplina().getNome().Equals(nomeDisciplina))
                            && (horario.getTurma().Equals(turma))
                            && (horario.getProfessor().getNome().Equals(nomeProfessor))
                            && (horario.getDiaSemana().Equals(diaSemana)))
                        {
                            horariaAMudar = horario;
                        }
                    }

                    frmIncluirHorario frmIncluirHorario = new frmIncluirHorario(horariaAMudar);
                    if (frmIncluirHorario.ShowDialog() == DialogResult.OK)
                    {
                        this.listaHorarios.Remove(horariaAMudar);
                        this.zerarCelulas(diaSemana, horarioCompleto);
                        this.incluirHorarioNaGrade(frmIncluirHorario.GetHorario());
                        frmIncluirHorario.Dispose();
                    }
                }
        }

        private void zerarCelulas(string diaSemanaString, string intervaloHorario)
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

            int horario1 = 0, horario2 = 0;

            if (intervaloHorario.Equals("07:15 - 08:55"))
            {
                horario1 = 0;
                horario2 = 1;
            }
            else if (intervaloHorario.Equals("08:55 - 10:35"))
            {
                horario1 = 2;
                horario2 = 3;
            }
            else if (intervaloHorario.Equals("10:50 - 12:30"))
            {
                horario1 = 4;
                horario2 = 5;
            }
            else if (intervaloHorario.Equals("13:10 - 14:50"))
            {
                horario1 = 6;
                horario2 = 7;
            }
            else if (intervaloHorario.Equals("14:50 - 16:30"))
            {
                horario1 = 8;
                horario2 = 9;
            }

            this.dgvGradeHorarioEmAndamento.Rows[horario1].Cells[diaSemana].Value = "";
            this.dgvGradeHorarioEmAndamento.Rows[horario2].Cells[diaSemana].Value = "";
        }

    }
}
