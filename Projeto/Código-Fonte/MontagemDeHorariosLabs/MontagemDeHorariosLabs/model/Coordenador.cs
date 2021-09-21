using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemDeHorariosLabs
{
    public class Coordenador
    {
        private int idCoordenador;
        private bool vigencia;
        private Professor professor;
        private string senha;

        public Coordenador(int idCoordenador, bool vigencia, Professor professor, string senha)
        {
            this.idCoordenador = idCoordenador;
            this.vigencia = vigencia;
            this.professor = professor;
            this.senha = senha;
        }

        public int getIdCoordenador()
        {
            return this.idCoordenador;
        }

        public Professor getProfessor()
        {
            return this.professor;
        }

        public string getSenha()
        {
            return this.senha;
        }

        public bool isVigente()
        {
            return this.vigencia;
        }

        public void setVigencia(bool novaVigencia)
        {
            this.vigencia = novaVigencia;
        }
    }
}
