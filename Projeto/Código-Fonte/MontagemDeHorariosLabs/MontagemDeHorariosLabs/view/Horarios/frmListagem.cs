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
    public partial class frmListagem : Form
    {
        public frmListagem(List<string> pedidos, string titulo)
        {
            InitializeComponent();

            lblLista.Text = "Lista de " + titulo;
            preencherDataGridView(pedidos);
        }

        public void preencherDataGridView(List<string> itens)
        {
            string[] dados = new string[1];
            foreach (string item in itens)
            {
                dados[0] = item;
                dgvLista.Rows.Add(dados);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
