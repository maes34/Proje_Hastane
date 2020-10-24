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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }
        sqlcon bgl = new sqlcon();
        private void PatLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doctors Where dtc=@p1 and dpass=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", DocTc.Text);
            komut.Parameters.AddWithValue("@p2", DocPass.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                DoctorDetail dd = new DoctorDetail();
                dd.tc = DocTc.Text;
                dd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc veya Şifre hatalı.");
            }
            bgl.baglanti().Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Loging lgn = new Loging();
            lgn.Show();
            this.Hide();
        }

        private void DoctorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
