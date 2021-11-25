using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void checkBoxSame_Click(object sender, EventArgs e)
        {
            if (checkBoxSame.Checked)
            {
                textBox1PerAddress.Enabled = false;
                textBoxCity.Enabled = false;
                textBoxProv.Enabled = false;
                textBoxZip.Enabled = false;
                textBox1PerAddress.Text = textBoxPresAddress.Text;
                textBoxCity.Text = textBoxPresCity.Text;
                textBoxProv.Text = textBoxPresProv.Text;
                textBoxZip.Text = textBoxPresZip.Text;
            }
            else
            {
                textBox1PerAddress.Enabled = true;
                textBoxCity.Enabled = true;
                textBoxProv.Enabled = true;
                textBoxZip.Enabled = true;
                textBox1PerAddress.Text = "";
                textBoxCity.Text = "";
                textBoxProv.Text = "";
                textBoxZip.Text = "";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
    }

