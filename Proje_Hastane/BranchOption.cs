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
    public partial class BranchOption : Form
    {
        public BranchOption()
        {
            InitializeComponent();
        }
        sqlcon bgl = new sqlcon();
        private void BranchOption_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branch", bgl.baglanti());
            da.Fill (dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branch (branchad) values (@b1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtbranch.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbranch.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Tbl_Branch set branchad=@b1 where branchid=@b2", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@b1", txtbranch.Text);
            guncelle.Parameters.AddWithValue("@b2", txtid.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("delete From Tbl_Branch where branchid=@b1",bgl.baglanti());
            delete.Parameters.AddWithValue("@b1", txtid.Text);
            delete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }
    }
}
