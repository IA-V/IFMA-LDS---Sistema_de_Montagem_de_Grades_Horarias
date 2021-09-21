using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemDeHorariosLabs
{
    public class DisciplinaTecnica
    {
        private int idDisciplina;
        private string nome;
        private string sigla;
        private int cargaHoraria;

        public DisciplinaTecnica(int idDisciplina, string nome, string sigla, int cargaHoraria)
        {
            this.idDisciplina = idDisciplina;
            this.nome = nome;
            this.sigla = sigla;
            this.cargaHoraria = cargaHoraria;
        }

        public int getIdDisciplinaTecnica()
        {
            return this.idDisciplina;
        } 

        public int getCargaHoraria()
        {
            return this.cargaHoraria;
        }

        public string getSigla()
        {
            return this.sigla;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setIdDisciplinaTecnica(int novoId)
        {
            this.idDisciplina = novoId;
        }

        public void setCargaHoraria(int novaCarga)
        {
            this.cargaHoraria = novaCarga;
        }

        public void setNome(string novoNome)
        {
            this.nome = novoNome;
        }

        public void setSigla(string novaSigla)
        {
            this.sigla = novaSigla;
        }
    }
}
