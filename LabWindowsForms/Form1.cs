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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("WINDOWS FORMS É UMA BOSTA.");

            SortColor(); 
        }

        private void SortColor()
        {
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Purple };

            Random random = new Random();

            int index = random.Next(colors.Length);

            this.BackColor = colors[index];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txt_Nome.Text;
            string endereco = this.txt_Endereco.Text;
            string cpf = this.mtb_Documento.Text;
            string telefone = this.mtb_Telefone.Text;
            string genero = this.cmb_Genero.Text;
            string nascimento = this.dtp_Nascimento.Value.ToShortDateString();

            MessageBox.Show($"Nome cadastrado: {nome} \n" +
                $"Endereço: {endereco} \n" +
                $"CPF: {cpf} \n" +
                $"Telefone: {telefone} \n" +
                $"Gênero: {genero} \n" +
                $"Nascimento: {nascimento}"
                );
        }
    }
}
