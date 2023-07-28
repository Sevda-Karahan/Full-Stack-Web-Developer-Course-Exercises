using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
            groupBox1.Hide();
        }

        int adet = 0;
        int toplam_tutar1 = 0;
        int toplam_tutar2 = 0;
        int yFiyat = 0;
        int iFiyat = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            listBox1.Show();
            listBox1.Items.Add("Müşteri Bilgileri:");
            listBox1.Items.Add("Ad-Soyad: " + textBox1.Text + " " + textBox2.Text);
            listBox1.Items.Add("Ödeme Şekli: " + comboBox1.SelectedItem);
            listBox1.Items.Add("Spariş No: " + textBox4.Text);
            listBox1.Items.Add("Telefon: " + maskedTextBox1.Text);
            listBox1.Items.Add("Adres: " + textBox6.Text);
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            textBox4.Clear();
            maskedTextBox1.Clear();
            textBox6.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem.ToString() == "Lahmacun")
            {
                groupBox2.Show();
                groupBox4.Hide();
                groupBox3.Hide();
                yFiyat = 70;
            }
            else if (comboBox2.SelectedItem.ToString() == "Kebap")
            {
                groupBox3.Show();
                groupBox4.Hide();
                groupBox2.Hide();
                yFiyat = 150;
            }
            else if (comboBox2.SelectedItem.ToString() == "Pizza")
            {
                groupBox4.Show();
                groupBox3.Hide();
                groupBox2.Hide();
                yFiyat = 100;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem.ToString() == "Soda")
            {
                iFiyat = 10;
            }
            if (comboBox3.SelectedItem.ToString() == "Ayran")
            {
                iFiyat = 15;
            }
            if (comboBox3.SelectedItem.ToString() == "Kola")
            {
                iFiyat = 20;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fis fis = new Fis();
            foreach (var item in listBox1.Items)
            {
                fis.listBox1.Items.Add(item);
            }
            fis.listBox1.Items.Add("***YEMEK BİLGİLERİ***");

            if(comboBox2.SelectedItem.ToString() == "Lahmacun")
            {
                fis.listBox1.Items.Add("Yemek: " + comboBox2.SelectedItem.ToString());
                if(checkBox2.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown3.Value);
                    fis.listBox1.Items.Add(numericUpDown3.Value + " Adet: " + checkBox2.Text);
                    toplam_tutar1 += yFiyat * adet;
                }
                if (checkBox1.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown4.Value);
                    fis.listBox1.Items.Add(numericUpDown4.Value + " Adet: " + checkBox1.Text);
                    toplam_tutar1 += yFiyat * adet;
                }
            }
            else if (comboBox2.SelectedItem.ToString() == "Pizza")
            {
                fis.listBox1.Items.Add("Yemek: " + comboBox2.SelectedItem.ToString());
                if (checkBox4.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown5.Value);
                    fis.listBox1.Items.Add(numericUpDown5.Value + " Adet: " + checkBox4.Text);
                    toplam_tutar1 += yFiyat * adet;
                }
                if (checkBox3.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown6.Value);
                    fis.listBox1.Items.Add(numericUpDown6.Value + " Adet: " + checkBox3.Text);
                    toplam_tutar1 += yFiyat * adet;
                }
            }
            else if (comboBox2.SelectedItem.ToString() == "Kebap")
            {
                fis.listBox1.Items.Add("Yemek: " + comboBox2.SelectedItem.ToString());
                if (checkBox6.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown1.Value);
                    fis.listBox1.Items.Add(numericUpDown1.Value + " Adet: " + checkBox6.Text);
                    toplam_tutar1 += yFiyat * adet;
                }
                if (checkBox5.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown2.Value);
                    fis.listBox1.Items.Add(numericUpDown2.Value + " Adet: " + checkBox5.Text);
                    toplam_tutar1 += yFiyat * adet;
                }
            }
            fis.listBox1.Items.Add("Toplam Yemek Tutarı: " + toplam_tutar1);

            fis.listBox1.Items.Add("***İÇECEK BİLGİLERİ***");
            if (comboBox3.SelectedItem.ToString() == "Soda")
            {
                fis.listBox1.Items.Add("İçecek: " + comboBox3.SelectedItem.ToString());
            }
            else if (comboBox3.SelectedItem.ToString() == "Ayran")
            {
                fis.listBox1.Items.Add("İçecek: " + comboBox3.SelectedItem.ToString());
            }
            else if (comboBox3.SelectedItem.ToString() == "Kola")
            {
                fis.listBox1.Items.Add("İçecek: " + comboBox3.SelectedItem.ToString());
            }
            toplam_tutar2 = iFiyat;
            fis.listBox1.Items.Add("Toplam İçecek Tutarı: " + toplam_tutar2);

            fis.listBox1.Items.Add("***TUTAR***");
            fis.listBox1.Items.Add("Toplam Tutar: " + (toplam_tutar1 + toplam_tutar2) );

            fis.Show();
        }
    }
}
