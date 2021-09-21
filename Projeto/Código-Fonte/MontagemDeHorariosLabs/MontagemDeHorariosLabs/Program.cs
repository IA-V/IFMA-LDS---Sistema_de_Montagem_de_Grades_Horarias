using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MontagemDeHorariosLabs.view;

namespace MontagemDeHorariosLabs
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        
        public static frmTelaPrincipal frmTelaPrincipal;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                frmTelaPrincipal = new frmTelaPrincipal(frmLogin.GetCoordenador());
                Application.Run(frmTelaPrincipal);
                frmLogin.Dispose();
            }
        }
    }
}
