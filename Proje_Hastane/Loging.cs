using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class Loging : Form
    {
        public Loging()
        {
            InitializeComponent();
        }

        private void btnPat_Click(object sender, EventArgs e)
        {
            PatientLogin plg = new PatientLogin();
            plg.Show();
            this.Hide();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            DoctorLogin dlg = new DoctorLogin();
            dlg.Show();
            this.Hide();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            SecretaryLogin slg = new SecretaryLogin();
            slg.Show();
            this.Hide();
        }
    }
}
