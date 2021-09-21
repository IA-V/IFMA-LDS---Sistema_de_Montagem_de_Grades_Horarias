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
        private DaoGradeHoraria daoGh;
        private frmListagem frmLista;

        public frmEscolhaHorario()
        {
            InitializeComponent();
        }

        private bool condicoesParaConsulta()
        {
            if (cmbHorario.SelectedIndex == -1)
            {
                MessageBox.Show("Você presa selecionar um intervalo de horário específico para a consulta!", "Campo não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHorario.Focus();
            }
            else if (cmbDiaSemana.SelectedIndex == -1)
            {
                MessageBox.Show("Você presa selecionar um dia da semana específico para a consulta!", "Campo não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDiaSemana.Focus();
            }
            else
                return true;
            return false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string horario = cmbHorario.Text;
            string diaSemana = cmbDiaSemana.Text;
            if (condicoesParaConsulta())
            {
                this.daoGh = new DaoGradeHoraria();
                List<string> listaLaboratoriosLivres = this.daoGh.buscarLaboratoriosLivres(horario, diaSemana);
                if (listaLaboratoriosLivres.Count == 0)
                    MessageBox.Show("Nenhum laboratório livre!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                else
                {
                    if(!(frmLista == null))
                    {
                        frmLista.Dispose();
                    }
                    this.frmLista = new frmListagem(listaLaboratoriosLivres, "Laboratórios Livres");
                    frmLista.Show();
                }
            }
        }
    }
}
