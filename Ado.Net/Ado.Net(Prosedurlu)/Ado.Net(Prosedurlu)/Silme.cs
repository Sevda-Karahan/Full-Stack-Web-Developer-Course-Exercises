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
    public partial class Silme : Form
    {
        public Silme()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-6QG82K9\\SQLEXPRESS; Database=OKUL3; integrated security=true;");

        private void BtnEvet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Ogr_Sil", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ID", label1.Tag);
            cmd.ExecuteNonQuery();
            connection.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void BtnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
