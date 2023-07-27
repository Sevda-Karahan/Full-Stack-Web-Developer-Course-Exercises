using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Fatura.Items.Add("Ad-Soyad: " + textBox1.Text);
            form2.Fatura.Items.Add("Yaş: " + textBox2.Text);
            form2.Fatura.Items.Add("Adres: " + textBox3.Text);
            form2.Show();
            
        }
    }
}
