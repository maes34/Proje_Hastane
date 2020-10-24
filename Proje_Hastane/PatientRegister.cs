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
    public partial class PatientRegister : Form
    {
        public PatientRegister()
        {
            InitializeComponent();
        }

        sqlcon bgl = new sqlcon();

        private void PatSignUp_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "" || PatSurname.Text == "" || PatTc.Text == "" || PatPhoneNumber.Text == "" || PatPass.Text == "" || PatGender.Text == "")
            {
                PatName.BackColor = Color.Red;
                PatSurname.BackColor = Color.Red;
                PatTc.BackColor = Color.Red;
                PatPhoneNumber.BackColor = Color.Red;
                PatPass.BackColor = Color.Red;
                PatGender.BackColor = Color.Red;
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
            }
            else { 
            SqlCommand komut = new SqlCommand("insert into Tbl_Patients (pname,psurname,ptc,pphone,ppass,pgender) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",PatName.Text);
            komut.Parameters.AddWithValue("@p2",PatSurname.Text);
            komut.Parameters.AddWithValue("@p3",PatTc.Text);
            komut.Parameters.AddWithValue("@p4",PatPhoneNumber.Text);
            komut.Parameters.AddWithValue("@p5",PatPass.Text);
            komut.Parameters.AddWithValue("@p6",PatGender.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + PatPass.Text, "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            }
        }

        private void PatientRegister_Load(object sender, EventArgs e)
        {
           

        }
    }
}
