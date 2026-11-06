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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
