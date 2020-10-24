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
    public partial class DoctorDetail : Form
    {
        public DoctorDetail()
        {
            InitializeComponent();
        }

        private void Btnİnf_Click(object sender, EventArgs e)
        {
            
            İnformation inf = new İnformation();
            inf.Show();

        }
        public string tc;
        sqlcon bgl = new sqlcon();
        private void DoctorDetail_Load(object sender, EventArgs e)
        {
            dtc.Text = tc;
            //Ad Soyad
            SqlCommand komut = new SqlCommand("Select dname,dsurname From Tbl_Doctors where dtc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dtc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dname.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where rdoctor='"+dname.Text + "'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Duyuru Sayısı
            SqlCommand toplam = new SqlCommand("Select count (*) From Tbl_Duyurular", bgl.baglanti());
            SqlDataReader drt = toplam.ExecuteReader();
            while (drt.Read())
            {
                Btnİnf.Text = "Duyurular" + " " + "(" + drt[0].ToString() + ")" ;
            }
            bgl.baglanti().Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DoctorİnformationEdit dinf = new DoctorİnformationEdit();
            dinf.tcNo = dtc.Text;
            dinf.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loging lgn = new Loging();
            lgn.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            PatDetails.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
