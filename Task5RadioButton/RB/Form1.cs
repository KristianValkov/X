using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int all = n2 + n;
            if(radioButton1.Checked== true)
            {
                lblB.Text = textBox2.Text;
            }
            if (radioButton2.Checked == true)
            {
                lblB.Text = textBox1.Text;
            }
            if (radioButton3.Checked == true)
            {
                lblB.Text = all.ToString();
                
            }
        }
    }
}
