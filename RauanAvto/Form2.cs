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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            label2.Text = Class1.zakaz;
            label3.Text = Class1.zakaz2;
            label4.Text = Class1.zakaz3;

            label5.Text = Class1.zakaz4;
            label6.Text = Class1.zakaz5;
            label7.Text = Class1.zakaz6;
            label9.Text = Class1.price;
            
        }
    }
}
