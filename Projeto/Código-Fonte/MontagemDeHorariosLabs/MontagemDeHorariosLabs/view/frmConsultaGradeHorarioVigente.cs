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
    public partial class frmConsultaGradeHorarioVigente : Form
    {
        private int numeroLab;

        public frmConsultaGradeHorarioVigente(int numeroLab)
        {
            InitializeComponent();
            this.numeroLab = numeroLab;
            listaHorarioslbl.Text = "Lista de Horários [Laboratório " + numeroLab + "]";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnMudarGrade_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Você deseja realmente mudar a grade horária em vigência?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                Program.frmTelaPrincipal.abrirFormulario(new frmMontagemGradeHoraria(this.numeroLab));
        }
    }
}
