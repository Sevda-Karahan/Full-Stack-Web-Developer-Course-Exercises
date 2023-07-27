using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            groupBox1.Visible = true;
            int fiyat = 0;
            if (comboBox1.SelectedItem == "Latte")
            {
                //groupBox1.Visible = true;
                fiyat = 120;
            }
            else if(comboBox1.SelectedItem == "Filtre")
            {
                fiyat = 100 ;
            }
            else
            {
                fiyat = 70;
            }
            textBox1.Text = fiyat.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Fatura.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fatura.Visible = true;
            if(comboBox1.SelectedItem == "Latte")
            {
                Fatura.Items.Add("Kahve: " + comboBox1.SelectedItem);
                Fatura.Items.Add("Fiyat: " + textBox1.Text);
            }
            else if (comboBox1.SelectedItem == "Filtre")
            {
                Fatura.Items.Add("Kahve: " + comboBox1.SelectedItem);
                Fatura.Items.Add("Fiyat: " + textBox1.Text);
            }
            else
            {
                Fatura.Items.Add("Kahve: " + comboBox1.SelectedItem);
                Fatura.Items.Add("Fiyat: " + textBox1.Text);
            }
        }
    }
}
