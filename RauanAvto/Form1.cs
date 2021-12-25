using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RauanAvto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        { 


            panel2.Visible = true;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            userControl21.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl21.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = true;

        }
    }
}
