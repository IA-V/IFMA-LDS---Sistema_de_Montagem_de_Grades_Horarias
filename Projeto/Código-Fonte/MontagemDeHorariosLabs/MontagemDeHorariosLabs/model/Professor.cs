using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemDeHorariosLabs
{
    public class Professor
    {
        private int idProfessor;
        private string matricula;
        private string nome;
        private string cpf;
        private bool status;

        public Professor(int idProfessor, string matricula, string nome, string cpf, bool status)
        {
            this.idProfessor = idProfessor;
            this.matricula = matricula;
            this.nome = nome;
            this.cpf = cpf;
            this.status = status;
        }

        public int getIdProfessor()
        {
            return this.idProfessor;
        }

        public void setIdProfessor(int idProfessor)
        {
            this.idProfessor = idProfessor;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string novoNome)
        {
            this.nome = novoNome;
        }

        public string getMatricula()
        {
            return this.matricula;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public bool isStatus()
        {
            return this.status;
        }

        public void setStatus(bool novoStatus)
        {
            this.status = novoStatus;
        }
    }
}
