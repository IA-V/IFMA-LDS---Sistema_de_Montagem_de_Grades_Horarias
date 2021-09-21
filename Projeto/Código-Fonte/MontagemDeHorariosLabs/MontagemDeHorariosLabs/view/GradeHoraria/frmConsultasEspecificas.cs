using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontagemDeHorariosLabs.view
{
    public partial class frmConsultasEspecificas : Form
    {
        private GradeHoraria gh;
        public frmConsultasEspecificas(GradeHoraria gh)
        {
            InitializeComponent();
            this.gh = gh;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            List<string> pedidos = new List<string>();
            string titulo = null;
            if (rbProfessores.Checked)
            {
                titulo = "Professores";
                foreach(Horario horario in this.gh.GetListaHorarios())
                {
                    string nomeProf = horario.getProfessor().getNome();
                    if(pedidos.IndexOf(nomeProf) == -1)
                        pedidos.Add(nomeProf);
                }
            }
            else if (rbDisciplinasTecnicas.Checked)
            {
                titulo = "Disciplinas Técnicas";
                foreach (Horario horario in this.gh.GetListaHorarios())
                {
                    string discTec = horario.getDisciplina().getNome();
                    if (pedidos.IndexOf(discTec) == -1)
                        pedidos.Add(discTec);
                }
            }
            else if(rbHorariosLivres.Checked)
            {
                titulo = "Horários Livres";
                List<string> horariosLivres = montarListaComTodosHorarios();
                foreach (Horario horario in this.gh.GetListaHorarios())
                {
                    string horarioOcupado = horario.getDiaSemana() + " / " + horario.getHorario();
                    horariosLivres.Remove(horarioOcupado);
                }
                pedidos = horariosLivres;
            }
            frmListagem form = new frmListagem(pedidos, titulo);
            form.Show();
        }

        public List<string> montarListaComTodosHorarios()
        {
            List<string> horariosLivres = new List<string>();

            horariosLivres.Add("Segunda / 07:15 - 08:55");
            horariosLivres.Add("Segunda / 08:55 - 10:35");
            horariosLivres.Add("Segunda / 10:50 - 12:30");
            horariosLivres.Add("Segunda / 13:10 - 14:50");
            horariosLivres.Add("Segunda / 14:50 - 16:30");

            horariosLivres.Add("Terça / 07:15 - 08:55");
            horariosLivres.Add("Terça / 08:55 - 10:35");
            horariosLivres.Add("Terça / 10:50 - 12:30");
            horariosLivres.Add("Terça / 13:10 - 14:50");
            horariosLivres.Add("Terça / 14:50 - 16:30");

            horariosLivres.Add("Quarta / 07:15 - 08:55");
            horariosLivres.Add("Quarta / 08:55 - 10:35");
            horariosLivres.Add("Quarta / 10:50 - 12:30");
            horariosLivres.Add("Quarta / 13:10 - 14:50");
            horariosLivres.Add("Quarta / 14:50 - 16:30");

            horariosLivres.Add("Quinta / 07:15 - 08:55");
            horariosLivres.Add("Quinta / 08:55 - 10:35");
            horariosLivres.Add("Quinta / 10:50 - 12:30");
            horariosLivres.Add("Quinta / 13:10 - 14:50");
            horariosLivres.Add("Quinta / 14:50 - 16:30");

            horariosLivres.Add("Sexta / 07:15 - 08:55");
            horariosLivres.Add("Sexta / 08:55 - 10:35");
            horariosLivres.Add("Sexta / 10:50 - 12:30");
            horariosLivres.Add("Sexta / 13:10 - 14:50");
            horariosLivres.Add("Sexta / 14:50 - 16:30");

            horariosLivres.Add("Sábado / 07:15 - 08:55");
            horariosLivres.Add("Sábado / 08:55 - 10:35");
            horariosLivres.Add("Sábado / 10:50 - 12:30");
            horariosLivres.Add("Sábado / 13:10 - 14:50");
            horariosLivres.Add("Sábado / 14:50 - 16:30");

            return horariosLivres;

        }
    }
}
