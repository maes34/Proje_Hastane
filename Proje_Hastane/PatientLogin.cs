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
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
        }
        sqlcon bgl = new sqlcon();
        private void PatReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegister prg = new PatientRegister();
            prg.Show();
        }
        
        private void PatLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Patients Where ptc=@p1 and ppass=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", PatTc.Text);
            komut.Parameters.AddWithValue("@p2", PatPass.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                PatientDetail pdet = new PatientDetail();
                pdet.tc = PatTc.Text;
                pdet.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Tc veya Şifre Hatalı");
            }
            bgl.baglanti().Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Loging lgn = new Loging();
            lgn.Show();
            this.Hide();
        }

        private void PatientLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
