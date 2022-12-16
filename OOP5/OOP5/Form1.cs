using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            numericUpDown1.Visible = false;
            button1.Enabled = false;
        }

        Zamestnanec zamestnanec;
        Vedouci vedouci;

        private void button4_Click(object sender, EventArgs e)
        {
            
            label1.Text = zamestnanec.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                zamestnanec.OdporacujHodiny((int)numericUpDown2.Value);
                label1.Text = zamestnanec.ToString();

            }
            if (radioButton2.Checked)
            {
                vedouci.OdporacujHodiny((int)numericUpDown2.Value);
                label1.Text = vedouci.ToString();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            numericUpDown1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            numericUpDown1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                zamestnanec = new Zamestnanec(textBox2.Text, textBox3.Text, dateTimePicker1.Value, (int)numericUpDown4.Value);
            }
            if(radioButton2.Checked)
            {
                vedouci = new Vedouci((int)numericUpDown1.Value,textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, (int)numericUpDown4.Value);
            }
            button1.Enabled = true;
        }
    }
}
