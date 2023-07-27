using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                listBox1.Items.Add("Medeni durum: " + radioButton1.Text);
            }
            else
            {
                listBox1.Items.Add("Medeni durum: " + radioButton2.Text);
            }

            string ehliyet_durumu = "Ehliyet durumu:";
            if (checkBox1.Checked == true)
            {
                ehliyet_durumu += " " + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                ehliyet_durumu += " " + checkBox2.Text;
            }
            listBox1.Items.Add(ehliyet_durumu);
        }
    }
}
