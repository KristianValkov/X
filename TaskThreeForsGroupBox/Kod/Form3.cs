using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kod
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "Kristian Valkov";
            string b = "2222";
            string c = "kv333@edu1.pgzaimov.com";
            if (textBox1.Text==a && textBox2.Text==b && textBox3.Text==b && textBox4.Text==c) 
            {
                MessageBox.Show("Всичко е точно!");
                //Form2 form2 = new Form2();
                //Form1 form1 = new Form1(); За скриване на първата форма
                //form1.Hide();
                //form2.Show();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
                MessageBox.Show("Въведи правилно потребителско име или парола!", "Error");
            }
        }
    }
}
