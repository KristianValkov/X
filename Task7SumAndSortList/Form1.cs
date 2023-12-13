using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7SumAndSortList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text);
            label3.Text = "" + sum;
            listBox1.Items.Add(sum);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list= new List<int>();
            
            foreach(int item in listBox1.Items)
            {
                list.Add(item);
            }
            listBox1.Items.Clear();
            list.Sort();
            foreach (int item in list)
            {
                listBox1.Items.Add((int)item);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
