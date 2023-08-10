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
    public partial class Guncelleme : Form
    {
        public Guncelleme()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-6QG82K9\\SQLEXPRESS; Database=OKUL3; integrated security=true;");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Ogr_Guncelle", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ID", TxtOgrNo.Tag);
            cmd.Parameters.AddWithValue("OgrenciNo", TxtOgrNo.Text);
            cmd.Parameters.AddWithValue("AdSoyad", TxtAd.Text);
            cmd.Parameters.AddWithValue("Sinif", TxtSinif.Text);
            cmd.Parameters.AddWithValue("Matematik", TxtNot1.Text);
            cmd.Parameters.AddWithValue("Turkce", TxtNot2.Text);
            cmd.Parameters.AddWithValue("Tarih", TxtNot3.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void BtnUygKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
