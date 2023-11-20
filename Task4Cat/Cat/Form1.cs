using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здрасти " + txtN.Text + "!!! \nТова е голямото ти постижение!");
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.ImageLocation = openPictureDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "*.rtf";

            saveFileDialog.Filter = "RTF Files|*.rtf";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK

             && (saveFileDialog.FileName.Length > 0))

            {
                try
                {
                    richTxtComment.SaveFile(saveFileDialog.FileName);
                }
                catch (Exception)
                { }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string str = "Hello " + txtN.Text.Trim();
            SecondForm secondForm = new SecondForm(str);
            secondForm.Show();
            secondForm.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            //string str = "Hello " + txtN.Text.Trim();
            //SecondForm secondForm = new SecondForm(str);
            //secondForm.ShowDialog();
            string str = "Hello " + txtN.Text.Trim();
            SecondForm secondForm = new SecondForm(str);
            if (DialogResult.Yes == secondForm.ShowDialog())

            {

                MessageBox.Show("Вие натиснахте бутона Oooooooo");

            }
            else MessageBox.Show("Вие затворихте прозореца без да натиснете бутона Ooooooo\\");
            { 
            }  
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            foreach (var item in gbUser.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
                if (item is RichTextBox) ((RichTextBox)item).Clear();
                //if (item is Label) ((Label)item).Text = "...";
                //if (item is Button) ((Button)item).BackColor = Color.Aqua;
            }
        }

        private void richTxtComment_TextChanged(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)

            {
                if (richTxtComment.SelectedText == "")

                {

                    richTxtComment.Font = fontDialog.Font;

                }
                else
                { 
                    richTxtComment.SelectionFont = fontDialog.Font;
                }
            }
        }
    
    }
}
