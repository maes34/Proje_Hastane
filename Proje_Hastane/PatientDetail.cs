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
    public partial class PatientDetail : Form
    {
        public PatientDetail()
        {
            InitializeComponent();
        }

        public string tc;

        sqlcon bgl = new sqlcon();
        void rgecmis()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where ptc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void PatientDetail_Load(object sender, EventArgs e)
        {

            //Ad Soyad
            PatTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select pname,psurname From Tbl_Patients where ptc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", PatTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                PatNameSurname.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            rgecmis();

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select branchad From Tbl_Branch", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                PatBranch.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //Tarih Saat
            timer1.Enabled = true;
            label3.Text = DateTime.Now.ToString();

        }

        private void PatBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatDoctor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select dname,dsurname From Tbl_Doctors where dbranch=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", PatBranch.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                PatDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void PatDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where rbranch='" + PatBranch.Text + "'" + " and rdoctor='" + PatDoctor.Text + "' and rinformation=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void PatDetailEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientDetailEdit fr = new PatientDetailEdit();
            fr.TCno = PatTc.Text;
            fr.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void PatSend_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Appointment Set rinformation=1,ptc=@p1,rdetail=@p2 where rid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", PatTc.Text);
            komut.Parameters.AddWithValue("@p2", PatSubject.Text);
            komut.Parameters.AddWithValue("@p3", txtıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            rgecmis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loging lgn = new Loging();
            lgn.Show();
        }

    }
}
