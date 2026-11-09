using LabWindowsForms.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWindowsForms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(Login usuarioAutenticado)
        {
            InitializeComponent();

            this.str_Funcionario.Text = usuarioAutenticado.Username;
            this.str_Funcao.Text = usuarioAutenticado.UserProfile;
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajuda não disponível no momento.");
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPessoaJuridica frmCadPessoaJuridica = new FrmCadPessoaJuridica();
            frmCadPessoaJuridica.ShowDialog();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
