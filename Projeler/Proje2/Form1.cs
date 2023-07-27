using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            string islem = textBox3.Text;

            if(islem == "+")
            {
                label4.Text = "Toplam:";
                label5.Text = Convert.ToString(sayi1 + sayi2);
            }
            else if(islem == "-")
            {
                label4.Text = "Fark:";
                //label5.Text = Convert.ToString(sayi1 - sayi2);
                label5.Text = (sayi1 - sayi2).ToString();
            }
            else if (islem == "*")
            {
                label4.Text = "Çarpım:";
                label5.Text = Convert.ToString(sayi1 * sayi2);
            }
            else if (islem == "/")
            {
                label4.Text = "Bölüm:";
                label5.Text = Convert.ToString(sayi1 / sayi2);
            }
            else 
            {
                label4.Text = "";
                label5.Text = "";
                MessageBox.Show("İşlem kısmına +, -, * veya / yazdığınıza emin olunuz!");
            }
        }
    }
}
