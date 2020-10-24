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
    public partial class DoctorİnformationEdit : Form
    {
        public DoctorİnformationEdit()
        {
            InitializeComponent();
        }
        sqlcon bgl = new sqlcon();
        public string tcNo;
        private void DocUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doctors set dname=@p1,dsurname=@p2,dbranch=@p3,dpass=@p4 where dtc=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", DocName.Text);
            komut.Parameters.AddWithValue("@p2", DocSurname.Text);
            komut.Parameters.AddWithValue("@p3", DocBranch.Text);
            komut.Parameters.AddWithValue("@p4", DocPass.Text);
            komut.Parameters.AddWithValue("@p5", DocTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void DoctorİnformationEdit_Load(object sender, EventArgs e)
        {
            DocTc.Text = tcNo;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doctors where dtc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", DocTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                DocName.Text = dr[1].ToString();
                DocSurname.Text = dr[2].ToString();
                DocBranch.Text = dr[3].ToString();
                DocPass.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        
    }
}
