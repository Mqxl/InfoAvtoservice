using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RauanAvto
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            



            string s = textBox1.Text;
            int n = Convert.ToInt32(s);

            string d = textBox2.Text;
            int z = Convert.ToInt32(d);

            string b = textBox3.Text;
            int x = Convert.ToInt32(b);

            int h = n += z += x;

            string g = Convert.ToString(h);


            string a = Convert.ToString(comboBox1.Text);
            Class1.zakaz = a;
            string p = Convert.ToString(comboBox2.Text);
            Class1.zakaz2 = p;
            string q = Convert.ToString(comboBox1.Text);
            Class1.zakaz3 = q;
            string m = Convert.ToString(textBox1.Text);
            Class1.zakaz4 = m;
            string l = Convert.ToString(textBox2.Text);
            Class1.zakaz5 = l;
            string o = Convert.ToString(textBox3.Text);
            Class1.zakaz6 = o;




            Class1.price = g;

            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
           
            
            





            
            comboBox1.DataSource = priceBindingSource;
            comboBox1.DisplayMember = "Названия";
            comboBox2.DataSource = priceBindingSource1;
            comboBox2.DisplayMember = "Названия";
            comboBox3.DataSource = priceBindingSource2;
            comboBox3.DisplayMember = "Названия";
            this.priceTableAdapter.Fill(this.remontDataSet.Price);
            textBox1.DataBindings.Add("Text", priceBindingSource, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", priceBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("Text", priceBindingSource2, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
