using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N
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

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = txt1.Text;
            switch (txt1.Text)
            {

                case "0": MessageBox.Show("Goood"); txt1.BackColor = Color.Green;lbl1.Text = "Нула"; break;
                case "1": MessageBox.Show("Goood"); txt1.BackColor = Color.Green; lbl1.Text = "Едно"; break;
                case "2": MessageBox.Show("Goood");txt1.BackColor = Color.Green; lbl1.Text = "Две"; break;
                case "3": MessageBox.Show("Goood"); txt1.BackColor = Color.Green; lbl1.Text = "Три"; break;
                case "4": MessageBox.Show("Goood"); txt1.BackColor = Color.Green; lbl1.Text = "Четири"; break;
                case "5": MessageBox.Show("Goood"); txt1.BackColor = Color.Green; lbl1.Text = "Пет"; break;
                case "6": MessageBox.Show("Goood"); txt1.BackColor = Color.Green; lbl1.Text = "Шест"; break;
                case "7": MessageBox.Show("Goood"); txt1.BackColor = Color.Green; lbl1.Text = "Седем"; break;
                case "8": MessageBox.Show("Goood"); txt1.BackColor = Color.Green; lbl1.Text = "Осем"; break;
                case "9": MessageBox.Show("Goood"); txt1.BackColor = Color.Green; lbl1.Text = "Девет"; break;
                default:
                    lbl1.Text = "Няма такова число";
                    txt1.BackColor = Color.Red;
                    MessageBox.Show("Fk-Въведи правилно число","Error",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
                    
                    break;
            }
            

        }
    }
}
