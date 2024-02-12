using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string count = textBox1.Text;
            int calck = Convert.ToInt32(count);
            calck = (int) Math.Pow(calck, 2)+3;
            textBox2.Text = calck.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            textBox3.Text = "ушел";
            textBox4.Text = "пришел";

        }
        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            textBox4.Text = " ";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            textBox3.Text = "пришел";
            textBox4.Text = "ушел";

        }
        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            textBox4.Text = " ";

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = RandomColor();

        }
        private Color RandomColor()
        {
            Random rnd = new Random();
            return Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }

}
