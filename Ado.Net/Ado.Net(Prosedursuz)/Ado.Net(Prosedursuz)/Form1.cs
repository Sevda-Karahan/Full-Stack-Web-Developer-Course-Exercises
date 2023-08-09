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

namespace Ado.Net_Prosedursuz_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-6QG82K9\\SQLEXPRESS;Database=IbbIstirak;integrated security=true;");
        //SqlConnection connection = new SqlConnection("Server=DESKTOP-6QG82K9\SQLEXPRESS;Database=IbbIstirak;uid=kullaniciadi;pwd=sifre;");

        public void List()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Istirakler", connection); //Listeleme gibi durumlarda veri çekmek için kullanılır. Verirleri düzensiz çeker.
            //Verileri düzenli hale getirmeliyiz
            DataTable table = new DataTable(); // Düzensiz veriyi düzenli hale getirir.
            adapter.Fill(table);
            dataGridView1.DataSource = table; // datagridview içerisine düzenli veriyi attık.
        }

        public void MyClearMethod()
        {
            TxtAdi.Clear();
            TxtTanim.Clear();
            TxtSayi.Clear();
            Tarih.Value = DateTime.Now;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Istirakler (IstirakAdi, IstirakTanim, CalisanSayisi, Tarih) values (@IstirakAdi, @IstirakTanim, @CalisanSayisi, @Tarih)", connection);//SQL e veri göndermek veya veri güncellemek için kullanılır.
            command.Parameters.AddWithValue("@IstirakAdi", TxtAdi.Text);
            command.Parameters.AddWithValue("@IstirakTanim", TxtTanim.Text);
            command.Parameters.AddWithValue("@CalisanSayisi", Convert.ToInt32(TxtSayi.Text));
            command.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(Tarih.Text));
            command.ExecuteNonQuery(); // Insert, update, delete işlemlerinde kesinlikle kullanılır.
            // ExecuteNonQuery() yukarıdaki yazma işlemini gerçekleştirir. Yazma işlemi başarılı olduysa 1, değilse 0 değeri döndüren bir methodtur.
            connection.Close();

            List();
            MyClearMethod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            TxtAdi.Tag = row.Cells["IstirakID"].Value.ToString();
            TxtAdi.Text = row.Cells["IstirakAdi"].Value.ToString();
            TxtTanim.Text = row.Cells["IstirakTanim"].Value.ToString();
            TxtSayi.Text = row.Cells["CalisanSayisi"].Value.ToString();
            Tarih.Text = row.Cells["Tarih"].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Istirakler set IstirakAdi=@IstirakAdi, IstirakTanim=@IstirakTanim, CalisanSayisi=@CalisanSayisi, Tarih=@Tarih where IstirakID=@IstirakID", connection); //insert, update, delete gibi Cloud işlemlerinde kullanılır.
            command.Parameters.AddWithValue("@IstirakID", TxtAdi.Tag);
            command.Parameters.AddWithValue("@IstirakAdi", TxtAdi.Text);
            command.Parameters.AddWithValue("@IstirakTanim", TxtTanim.Text);
            command.Parameters.AddWithValue("@CalisanSayisi", Convert.ToInt32(TxtSayi.Text));
            command.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(Tarih.Text));
            command.ExecuteNonQuery();
            connection.Close();

            List();
            MyClearMethod();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from Istirakler where IstirakID=@IstirakID", connection); //insert, update, delete yaparken kullanılır.
            command.Parameters.AddWithValue("@IstirakID", TxtAdi.Tag);
            command.ExecuteNonQuery();
            connection.Close();

            List();
            MyClearMethod();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Istirakler where IstirakAdi like '%" + TxtAdi.Text + "%'", connection); //Veri çekmek için kullanılır. Verirleri düzensiz çeker.
            //Verileri düzenli hale getirmeliyiz
            DataTable table = new DataTable(); // Düzensiz veriyi düzenli hale getirir.
            adapter.Fill(table);
            dataGridView1.DataSource = table; // datagridview içerisine düzenli veriyi attık.
            MyClearMethod();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            MyClearMethod();
        }

        private void BtnResim_Click(object sender, EventArgs e)
        {
            Logo logo = new Logo();
            logo.Show();
        }
    }
}
