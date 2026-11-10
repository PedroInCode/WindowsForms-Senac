using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Frm_Login frmLogin = new Frm_Login();
            
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMenuPrincipal(frmLogin.usuarioEncontrado));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
