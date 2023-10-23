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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string a = "Kristian Valkov";
            string b = "22222";
            if (txt1.Text == a && txt2.Text==b)
            {
                //MessageBox.Show("Всичко е точно!");

                Form2 form2 = new Form2();
                //Form1 form1 = new Form1(); За скриване на първата форма
                //form1.Hide();
                form2.Show();
                
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
                MessageBox.Show("Въведи правилно потребителско име или парола!","Error");
            }
            
        }
    }
}
