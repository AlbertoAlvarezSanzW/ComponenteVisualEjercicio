using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponenteVisualEjercicio
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string decision = "Has seleccionado: ";

            if (radioButton1.Checked){
                decision += radioButton1.Text + ", buena suerte !";
                pictureBox1.Image = Image.FromFile("C:/Users/Alberto/Desktop/foticos/diablo.png");
            }
            if (radioButton2.Checked){
                decision += radioButton2.Text + ", buena suerte !";
                pictureBox1.Image = Image.FromFile("C:/Users/Alberto/Desktop/foticos/diablo2.png");
            }
            if (radioButton3.Checked){
                decision += radioButton3.Text + ", buena suerte !";
                pictureBox1.Image = Image.FromFile("C:/Users/Alberto/Desktop/foticos/diablo3.png");
            }
            if (radioButton4.Checked){
                decision += radioButton4.Text + ", buena suerte !";
                pictureBox1.Image = Image.FromFile("C:/Users/Alberto/Desktop/foticos/diablo4.png");
            }
            MessageBox.Show(decision);
        }
    }
}
