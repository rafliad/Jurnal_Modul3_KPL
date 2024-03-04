using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurnal_Modul3_KPL
{
    public partial class Form1 : Form
    {
        int hasil, nomor;
        bool isi = false;
        bool equal = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isi){
                labelOutput.Text = "" + 1;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 1;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 2;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 3;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 4;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 5;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 6;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 6;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 7;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 7;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 8;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 8;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 9;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 9;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!isi)
            {
                labelOutput.Text = "" + 0;
                isi = true;
            }
            else
            {
                labelOutput.Text = labelOutput.Text + "" + 0;
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!equal)
            {
                nomor = Convert.ToInt32(labelOutput.Text);
                hasil = hasil + nomor;
                labelOutput.Text = "";
                isi = false;
            }
            else
            {
                nomor = Convert.ToInt32(labelOutput.Text);
                labelOutput.Text = "";
                isi = false;
            }
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            nomor = Convert.ToInt32(labelOutput.Text);
            hasil = hasil + nomor;
            labelOutput.Text = "" + hasil;
            equal = true;
        }
    }
}
