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
    public partial class Frm_Login : Form
    {
        List<Login> users = new List<Login>();
        public Login usuarioEncontrado;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
            Login user1 = new Login(1, "Arthur Silva", "arthur@gmail.com", "1234", "Administrador");
            Login user2 = new Login(2, "Luan Bispo", "luan@gmail.com", "1234", "Operador");
            Login user3 = new Login(3, "Luffy Pirata", "luffy@gmail.com", "1234", "Operador");

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            var textoLogin = this.txt_Login.Text;
            var textoSenha = this.txt_Senha.Text;

            ValidarCampos(textoLogin, textoSenha);

            usuarioEncontrado = users.FirstOrDefault(user => user.Authenticate(textoLogin, textoSenha));

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuário NÃO encontrado",
                    "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                MessageBox.Show($"Bem-vindo {usuarioEncontrado.Username}!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        public void ValidarCampos(string textoLogin, string textoSenha)
        {
            if (string.IsNullOrWhiteSpace(textoLogin))
            {
                MessageBox.Show("O campo de login não pode estar vazio.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txt_Login.BackColor = Color.Red;

                this.txt_Login.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textoSenha))
            {

                MessageBox.Show("O campo de senha não pode estar vazio.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txt_Senha.BackColor = Color.Red;

                return;
            }
        }
        private void txt_Login_TextChanged(object sender, EventArgs e)
        {
            this.txt_Login.BackColor = Color.White;
        }
        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {
            this.txt_Senha.BackColor = Color.White;
        }

    }
}
