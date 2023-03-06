using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form newForm = new Form();
            newForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Hej";
            label1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
           
            i++;
            label2.Text = i.ToString();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            button5.BackColor = DefaultBackColor;
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, this.ClientSize.Width - label3.Width);
            int y = rnd.Next(0, this.ClientSize.Height - label3.Height);

            label3.Location = new Point(x,y);

        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Top -= 10;
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Left -= 10;
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Left += 10;
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Top += 10;
        }
    }
}
