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
    public partial class frmMontagemGradeHoraria : Form
    {
        private enum diasSemanas {segunda, terca, quarta, quinta, sexta, sabado};

        private int numeroLab;

        public frmMontagemGradeHoraria(int numeroLab)
        {
            InitializeComponent();
            this.numeroLab = numeroLab;
            this.lblListaHorarios.Text = "Lista de Horários [Laboratório " + numeroLab + "]";
            this.preencherCampoAnoSemestre();
            this.preencherDGVColunaHorarios();
        }

        private void preencherDGVColunaHorarios()
        {
            string[] dados = new string[7];
            for(int i = 0; i < 9; i++)
            {
                if(i == 0)
                    dados[0] = "07:15 - 08:05";
                if (i == 1)
                    dados[0] = "08:05 - 08:55";
                if (i == 2)
                    dados[0] = "08:55 - 09:45";
                if (i == 3)
                    dados[0] = "09:45 - 10:35";
                if (i == 4)
                    dados[0] = "10:50 - 12:30";
                if (i == 5)
                    dados[0] = "13:10 - 14:00";
                if (i == 6)
                    dados[0] = "14:00 - 14:50";
                if (i == 7)
                    dados[0] = "14:50 - 15:40";
                if (i == 8)
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

        }

        private void btnIncluirHorario_Click(object sender, EventArgs e)
        {
            frmIncluirHorario frmIncluirHorario = new frmIncluirHorario();
            if(frmIncluirHorario.ShowDialog() == DialogResult.OK)
            {
                this.incluirHorarioNaGradeEmMontagem(frmIncluirHorario.GetHorario());
            }
        }

        private void incluirHorarioNaGradeEmMontagem(Horario horario)
        {
            
        }

    }
}
