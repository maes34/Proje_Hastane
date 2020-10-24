using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class SecretaryLogin : Form
    {
        public SecretaryLogin()
        {
            InitializeComponent();
        }
        sqlcon bgl = new sqlcon();
        private void PerLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Secretary where secretarytc=@p1 and secretarypass=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", PerTc.Text);
            komut.Parameters.AddWithValue("@p2", PerPass.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SecretaryDetail sd = new SecretaryDetail();
                sd.Tcnumara = PerTc.Text;
                sd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı veya Şifre");
            }
            bgl.baglanti().Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Loging lgn = new Loging();
            lgn.Show();
            this.Hide();
        }
    }
}
