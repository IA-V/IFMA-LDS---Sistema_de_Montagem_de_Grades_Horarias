using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemDeHorariosLabs
{
    public class GradeHoraria
    {
        private int idGradeHoraria;
        private string anoSemestre;
        private List<Horario> listaHorarios;
        private Laboratorio laboratorio;
        private bool status;

        public GradeHoraria(int idGradeHoraria, string anoSemestre, List<Horario> listaHorarios, Laboratorio laboratorio, bool status)
        {
            this.idGradeHoraria = idGradeHoraria;
            this.anoSemestre = anoSemestre;
            this.listaHorarios = listaHorarios;
            this.laboratorio = laboratorio;
            this.status = status;
        }

        public int getIdGradeHoraria()
        {
            return this.idGradeHoraria;
        }

        public string getanoSemestre()
        {
            return this.anoSemestre;
        }

        public Laboratorio getLaboratorio()
        {
            return this.laboratorio;
        }

        public void adicionarHorario(Horario horario)
        {
            this.listaHorarios.Add(horario);
        }

        public List<Horario> GetListaHorarios()
        {
            return this.listaHorarios;
        }

        public void SetListaHorarios(List<Horario> listaHorarios)
        {
            this.listaHorarios = listaHorarios;
        }

        public bool isStatus()
        {
            return this.status;
        }

        public void setStatus(bool status)
        {
            this.status = status;
        }
    }
}
