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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-6QG82K9\\SQLEXPRESS; Database=IbbIstirak; integrated security=true;");

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserNamePass where UserName=@UserName and UserPassword=@UserPassword", connection);
            cmd.Parameters.AddWithValue("@UserName", TxtAd.Text);
            cmd.Parameters.AddWithValue("@UserPassword", TxtSifre.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();
            
            if (dataReader.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız!");
                TxtAd.Clear();
                TxtSifre.Clear();
            }

            connection.Close();
        }
    }
}
