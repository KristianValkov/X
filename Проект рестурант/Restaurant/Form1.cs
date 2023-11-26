using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        string a = "";
        Form1 form1 = new Form1();
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            //MessageBox.Show("Попълни всичко");
            //Form1 f = new Form1();
            //f.Refresh();
            if (radioButton1.Checked )
            {
                a = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                a = radioButton2.Text;
            }
            //else
            //{
            //    form2.Hide();
            //}
            if (radioButton4.Checked)
            {
                a = radioButton4.Text;
                MessageBox.Show("Ще вземем 0,05лв. над сметката");
                //form2.Show();
            }
            if (radioButton3.Checked)
            {
                a = radioButton3.Text;
                MessageBox.Show("Ще оставите ли бакшиш?", "Събиране на бакшиши", MessageBoxButtons.YesNo);
                //form2.Show();
            }
            
            //if (radioButton3.Text=="" && radioButton4.Text=="")
            //{
            //    MessageBox.Show("Не сте отбелязали как ще платите");
            //}
            //else
            //{
            //    MessageBox.Show("Не сте отбелязали как ще платите");
            //}
            //Form1 form1 = new Form1();
            int n = int.Parse(txt1.Text);
            //if (txt1.Text == "")
            //{
            //    MessageBox.Show("Error");
            //}
            if (n>2&&n<15)
            {
                form2.Show();
                //form1.Close();
                return;
            }
            else
            {
                MessageBox.Show("Няма маса за толкова хора.","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show("Трябва да са от 3-14 души!");
                //form1.Refresh();
                //form2.Hide();
            }
            //if (txt1.Text == "")
            //{
            //    MessageBox.Show("Error");
            //}
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                MessageBox.Show(item.ToString());
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //form2.Show();
            //form1.Close();
        }
    }
}
