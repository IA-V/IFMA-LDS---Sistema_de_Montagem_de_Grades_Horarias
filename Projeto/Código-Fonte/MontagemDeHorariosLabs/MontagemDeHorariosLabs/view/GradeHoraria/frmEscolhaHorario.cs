using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MontagemDeHorariosLabs.dao;
using System.Windows.Forms;

namespace MontagemDeHorariosLabs.view
{
    public partial class frmEscolhaHorario : Form
    {
        public frmEscolhaHorario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string horario = cmbHorario.Text;
            string diaSemana = cmbDiaSemana.Text;
            if (DialogResult.Yes == MessageBox.Show("Você deseja listar lab. livres no horário " + horario + " do(a) " + diaSemana + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DaoGradeHoraria daoGh = new DaoGradeHoraria();
                List<string> listaLaboratoriosLivres = daoGh.buscarLaboratoriosLivres(horario, diaSemana);
                if(listaLaboratoriosLivres.Count == 0)
                {
                    MessageBox.Show("Nenhum laboratório livre!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    frmListagem form = new frmListagem(listaLaboratoriosLivres, "Laboratórios Livres");
                    form.Show();
                }
            }
        }
    }
}
