using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net_Prosedurlu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public void List()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter("Ogr_Listele", connection);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    dataGridView1.DataSource = table;
        //}

        public void List(string procedure)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(procedure, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-6QG82K9\\SQLEXPRESS; Database=OKUL3; integrated security=true;");

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Ogr_Kaydet", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("OgrenciNo", TxtOgrNo.Text);
            cmd.Parameters.AddWithValue("AdSoyad", TxtAd.Text);
            cmd.Parameters.AddWithValue("Sinif", TxtSinif.Text);
            cmd.Parameters.AddWithValue("Matematik", TxtNot1.Text);
            cmd.Parameters.AddWithValue("Turkce", TxtNot2.Text);
            cmd.Parameters.AddWithValue("Tarih", TxtNot3.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            List("Ogr_Listele");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List("Ogr_Listele");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (e.ColumnIndex==0) //Düzenle
            {
                Guncelleme guncelle = new Guncelleme();
                guncelle.Show();
                guncelle.TxtOgrNo.Tag = row.Cells["ID"].Value.ToString();
                guncelle.TxtOgrNo.Text = row.Cells["OgrenciNo"].Value.ToString();
                guncelle.TxtAd.Text = row.Cells["AdSoyad"].Value.ToString();
                guncelle.TxtSinif.Text = row.Cells["Sinif"].Value.ToString();
                guncelle.TxtNot1.Text = row.Cells["Matematik"].Value.ToString();
                guncelle.TxtNot2.Text = row.Cells["Turkce"].Value.ToString();
                guncelle.TxtNot3.Text = row.Cells["Tarih"].Value.ToString();
                this.Hide();
            }
            else if (e.ColumnIndex == 1)
            {
                Silme sil = new Silme();
                sil.Show();
                sil.label1.Tag = row.Cells["ID"].Value.ToString();
                sil.label1.Text = row.Cells["OgrenciNo"].Value.ToString();
                this.Hide();
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (ComboBoxAra.SelectedItem == "Öğrenci No")
            {
                SqlCommand command = new SqlCommand("AraOgrNo", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("OgrenciNo", TxtAra.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                TxtAra.Clear();
            }
            else if (ComboBoxAra.SelectedItem == "Ad Soyad")
            {
                SqlCommand command = new SqlCommand("AraOgrAd", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("AdSoyad", TxtAra.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                TxtAra.Clear();
            }
            else if (ComboBoxAra.SelectedItem == "Sınıf")
            {
                SqlCommand command = new SqlCommand("AraOgrSinif", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Sinif", TxtAra.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                TxtAra.Clear();
            }
        }

        private void BtnUygKapat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //Ana form olduğundan Application.Exit() yapmadan this.Close() ile de uygulama kapatılabilir.
            //Fakat Silme ve Guncelleme formlarında uygulamadan çıkmak için this.Close() sadece o formu kapatır. Uygulamayı kapatmaz. Uygulamayı kapatmak için Application.Exit() yapılmalıdır.
            this.Close();
        }
    }
}
