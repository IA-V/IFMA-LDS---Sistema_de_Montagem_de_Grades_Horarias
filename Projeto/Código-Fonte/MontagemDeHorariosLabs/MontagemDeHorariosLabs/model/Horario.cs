using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemDeHorariosLabs
{
    public class Horario
    {
        private int idHorario;
        private string diaSemana;
        private string horario;
        private string turma;
        private Professor professor;
        private DisciplinaTecnica disciplina;

        public Horario(int idHorario, string diaSemana, string horario, string turma, Professor professor, DisciplinaTecnica disciplina)
        {
            this.idHorario = idHorario;
            this.diaSemana = diaSemana;
            this.horario = horario;
            this.turma = turma;
            this.professor = professor;
            this.disciplina = disciplina;
        }

        public int getIdHorario()
        {
            return this.idHorario;
        }

        public string getDiaSemana()
        {
            return this.diaSemana;
        }

        public string getTurma()
        {
            return this.turma;
        }

        public string getHorario()
        {
            return this.horario;
        }

        public Professor getProfessor()
        {
            return this.professor;
        }

        public DisciplinaTecnica getDisciplina()
        {
            return this.disciplina;
        }

        public void setProfessor(Professor novoProf)
        {
            this.professor = novoProf;
        }

        public void setDisciplinaTecnica(DisciplinaTecnica novaDT)
        {
            this.disciplina = novaDT;
        }

        public void setDiaSemana(string novoDia)
        {
            this.diaSemana = novoDia;
        }

        public void setHorario(string novoHorario)
        {
            this.horario = novoHorario;
        }

        public void setTurma(string novaTurma)
        {
            this.turma = novaTurma;
        }
    }
}
