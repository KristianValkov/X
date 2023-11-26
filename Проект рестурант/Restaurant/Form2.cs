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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
        }
    }
}
