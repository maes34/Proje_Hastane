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
    public partial class SecretaryDetail : Form
    {
        public SecretaryDetail()
        {
            InitializeComponent();
        }
        public string Tcnumara;
        sqlcon bgl = new sqlcon();
        private void SecretaryDetail_Load(object sender, EventArgs e)
        {
            PerTc.Text = Tcnumara;

            // Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select secretarynamesurname from Tbl_Secretary where secretarytc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", PerTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                PerAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşlar
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branch", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource=dt1;

            //Doktrorlar
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (dname + ' ' + dsurname )as 'Doktorlar', dbranch as 'Branşlar' From Tbl_Doctors", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branş Listesi
            SqlCommand komut2 = new SqlCommand("Select branchad From Tbl_Branch", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
                bgl.baglanti().Close();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Appointment (rdate,rtime,rbranch,rdoctor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            
            SqlCommand komut = new SqlCommand("Select dname,dsurname From Tbl_Doctors where dbranch=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            DoctorOptions dpnl = new DoctorOptions();
            dpnl.Show();
        }

        private void BtnBransListe_Click(object sender, EventArgs e)
        {
            BranchOption fbr = new BranchOption();
            fbr.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            İnformation inf = new İnformation();
            inf.Show();
        }

        private void BtnRandevuListesi_Click(object sender, EventArgs e)
        {
            RandevuList rlst = new RandevuList();
            rlst.Show();
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loging lgn = new Loging();
            lgn.Show();
        }
    }
}
