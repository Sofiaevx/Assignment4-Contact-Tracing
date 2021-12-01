using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

       

       

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            StreamWriter Output;
            string location = @"D:\This PC\Desktop\OutputFile\" + textBoxLn.Text + ", " + textBoxFn.Text + ".txt";
            Output = File.AppendText(location);
          
            Output.WriteLine("Date: " + dateTimePicker1.Value);
            Output.WriteLine("Name: " + textBoxLn.Text + ", " + textBoxFn.Text + " " + textBoxMi.Text + ". " + textBoxSuffix.Text);
            Output.WriteLine("Birthdate: " + bdatepicker.Value);
            Output.WriteLine("Age: " + numericUpDownage.Value);
            if (radioButtonMale.Checked)
            {
                Output.WriteLine("Gender: Male");
            }
            else
            {
                Output.WriteLine("Gender: Female");
            }
            Output.WriteLine("Phone Number: " + textBoxPn.Text);
            Output.WriteLine("Email: " + textBoxEmail.Text);
            Output.WriteLine("Present Address: " + textBoxPresAddress.Text + ", " + textBoxPresCity.Text + ", " + textBoxPresProv.Text + ", " + textBoxPresZip.Text);
            if (checkBoxSame.Checked)
            {
                Output.WriteLine("Permanent Address: " + textBoxPresAddress.Text + ", " + textBoxPresCity.Text + ", " + textBoxPresProv.Text + ", " + textBoxPresZip.Text);
            }
            else
            {
                Output.WriteLine("Permanent Address: " + textBox1PerAddress.Text + ", " + textBoxCity.Text + ", " + textBoxProv.Text + ", " + textBoxZip.Text);

            }

            Output.WriteLine("\n 1. Do you feel any of the following?");
            if (radioButton1no.Checked)
            {
                Output.WriteLine("\t" + labelcoughs.Text + ": No ");
            }
            else
            {
                Output.WriteLine("\t" + labelcoughs.Text + ": Yes ");
            }
            if (radioButton2no.Checked)
            {
                Output.WriteLine("\t" + labelchills.Text + ": No ");
            }
            else
            {
                Output.WriteLine("\t" + labelchills.Text + ": Yes ");
            }
            if (radioButton3no.Checked)
            {
                Output.WriteLine("\t" + labelsore.Text + ": No ");
            }
            else
            {
                Output.WriteLine("\t" + labelsore.Text + ": Yes ");
            }
            if (radioButton4no.Checked)
            {
                Output.WriteLine("\t" + labelshortness.Text + ": No ");
            }
            else
            {
                Output.WriteLine("\t" + labelshortness.Text + ": Yes ");
            }
            if (radioButton5no.Checked)
            {
                Output.WriteLine("\t" + labelrunny.Text + ": No ");
            }
            else
            {
                Output.WriteLine("\t" + labelrunny.Text + ": Yes ");
            }
            if (radioButton6no.Checked)
            {
                Output.WriteLine("\t" + labelheadache.Text + ": No ");
            }
            else
            {
                Output.WriteLine("\t" + labelheadache.Text + ": Yes ");
            }
            if (radioButton7no.Checked)
            {
                Output.WriteLine("\t" + labelfatigue.Text + ": No ");
            }
            else
            {
                Output.WriteLine("\t" + labelfatigue.Text + ": Yes ");
            }
            if (radioButton8no.Checked)
            {
                Output.WriteLine("\t" + labelloss.Text + ": No ");
            }
            else
            {
                Output.WriteLine("\t" + labelloss.Text + ": Yes ");
            }
            Output.Write("\n 2. Have you worked together or stayed together in the same closed environment of a confirmed Covid - 19 case?");
            if (rbnum2no.Checked)
            {
                Output.Write(" - No ");
            }
            else
            {
                Output.Write(" - Yes ");
            }
            Output.Write("\n 3. Have you had any contact with anyone with fever, cough, colds,and sore throat the past 2 weeks ?");
            if (rbnum3no.Checked)
            {
                Output.Write(" - No ");
            }
            else
            {
                Output.Write(" - Yes ");
            }
            Output.Write("\n 4. Have you travelled to any areas in NCR from your home?");
            if (rbnum4no.Checked)
            {
                Output.Write(" - No ");
            }
            else
            {
                Output.Write(" - Yes ");
            }
            Output.Write("\n 5. Have you travelled outside the Philippines in the last 14 days?");
            if (rbnum5no.Checked)
            {
                Output.Write(" - No ");
            }
            else
            {
                Output.Write(" - Yes ");
            }
            Output.Close();



            MessageBox.Show( "Created Successfully!!" );
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }

        private void checkBoxSame_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                buttonsubmit.Enabled = true;
            }
            else
            {
                buttonsubmit.Enabled = false;
            }
        }

        private void letters(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void num(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    }

