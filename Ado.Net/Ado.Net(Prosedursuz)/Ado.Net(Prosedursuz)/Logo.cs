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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-6QG82K9\\SQLEXPRESS; Database=IbbIstirak; integrated security=true;");

        private void BtnSec_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.ShowDialog(); 

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;
        }

        public void List(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List("Select * from Istirakler");
        }

        private void Logo_Load(object sender, EventArgs e)
        {
            List("Select * from Istirakler");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            TxtResim.Tag = row.Cells["IstirakID"].Value.ToString();
            TxtResim.Text = row.Cells["Resim"].Value.ToString();
            pictureBox1.ImageLocation = row.Cells["Resim"].Value.ToString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Istirakler set Resim=@Resim where IstirakID=@IstirakID", connection);
            cmd.Parameters.AddWithValue("@Resim", TxtResim.Text); 
            cmd.Parameters.AddWithValue("@IstirakID", TxtResim.Tag);
            cmd.ExecuteNonQuery();
            List("Select * from Istirakler");
            connection.Close();
        }

        private void TxtArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            List("Select * from Istirakler where IstirakAdi like '%" + TxtArama.Text +"%'");
        }
    }
}
