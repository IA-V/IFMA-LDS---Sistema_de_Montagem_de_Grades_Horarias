using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemDeHorariosLabs
{
    public class Laboratorio
    {
        private int idLaboratorio;
        private int numero;
        private int quantComp;
        private string localizacao;

        public Laboratorio(int idLaboratorio, int numero, int quantComp, string localizacao)
        {
            this.idLaboratorio = idLaboratorio;
            this.numero = numero;
            this.quantComp = quantComp;
            this.localizacao = localizacao;
        }

        public int getIdLaboratorio()
        {
            return this.idLaboratorio;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public int getQuantComp()
        {
            return this.quantComp;
        }

        public String getLocalizacao()
        {
            return this.localizacao;
        }

        public void setNumero(int novoNum)
        {
            this.numero = novoNum;
        }

        public void setQuantComp(int novaQuantComp)
        {
            this.quantComp = novaQuantComp;
        }

        public void setLocalizacao(string novaLocalizacao)
        {
            this.localizacao = novaLocalizacao;
        }
    }
}
