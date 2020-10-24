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
    public partial class PatientDetailEdit : Form
    {
        public PatientDetailEdit()
        {
            InitializeComponent();
        }
        public string TCno;
                sqlcon bgl = new sqlcon();

        private void PatientDetailEdit_Load(object sender, EventArgs e)
        {
            PatTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Patients where ptc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", PatTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                PatName.Text = dr[1].ToString();
                PatSurname.Text = dr[2].ToString();
                PatPhoneNumber.Text = dr[4].ToString();
                PatPass.Text = dr[5].ToString();
                PatGender.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }
        private void PatUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Patients set pname=@p1,psurname=@p2,pphone=@p3,ppass=@p4,pgender=@p5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", PatName.Text);
            komut2.Parameters.AddWithValue("@p2", PatSurname.Text);
            komut2.Parameters.AddWithValue("@p3", PatPhoneNumber.Text);
            komut2.Parameters.AddWithValue("@p4", PatPass.Text);
            komut2.Parameters.AddWithValue("@p5", PatGender.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            this.Hide();
        }
    }
}
