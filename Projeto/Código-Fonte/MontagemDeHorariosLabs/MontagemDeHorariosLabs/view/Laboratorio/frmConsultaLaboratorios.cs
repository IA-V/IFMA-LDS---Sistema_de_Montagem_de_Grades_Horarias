using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MontagemDeHorariosLabs.dao;

namespace MontagemDeHorariosLabs.view
{
    public partial class frmConsultaLaboratorios : Form
    {
        private DaoLaboratorio daoLab;

        public frmConsultaLaboratorios()
        {
            InitializeComponent();
            preencherDataGridView(-1);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Trim() == "")
                preencherDataGridView(-1);
            else
            {
                int numero = Int32.Parse(txtNumero.Text);
                preencherDataGridView(numero);
                if (dgvLabs.Rows.Count == 0)
                    if (DialogResult.Yes == MessageBox.Show("Laboratório inexistente. Você deseja criar um laboratório com esse número?", "Criação de Laboratório", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Laboratorio lab = new Laboratorio(0, numero, 0, "");
                        chamarTelaCadastroLaboratorios(lab);
                    }
                    else
                        preencherDataGridView(-1);
            }
        }

        private void preencherDataGridView(int filtro)
        {
            this.daoLab = new DaoLaboratorio();
            List<Laboratorio> listaLabs = this.daoLab.buscarLaboratoriosBD(filtro);
            string[] dados = new string[4];
            dgvLabs.Rows.Clear();

            foreach (Laboratorio lab in listaLabs)
            {
                dados[0] = lab.getIdLaboratorio().ToString();
                dados[1] = lab.getNumero().ToString();
                dados[2] = lab.getQuantComp().ToString();
                dados[3] = lab.getLocalizacao();
                dgvLabs.Rows.Add(dados);
            }
        }

        private void dgvLabs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idLab = Int32.Parse(dgvLabs.CurrentRow.Cells[0].Value.ToString());
            int numero = Int32.Parse(dgvLabs.CurrentRow.Cells[1].Value.ToString());
            int quantComp = Int32.Parse(dgvLabs.CurrentRow.Cells[2].Value.ToString());
            string localizacao = dgvLabs.CurrentRow.Cells[3].Value.ToString();
            Laboratorio lab = new Laboratorio(idLab, numero, quantComp, localizacao);
            chamarTelaCadastroLaboratorios(lab);
        }

        private void chamarTelaCadastroLaboratorios(Laboratorio lab)
        {
            Program.frmTelaPrincipal.abrirFormulario(new frmCadastroLaboratorios(lab));
        }
    }
}
