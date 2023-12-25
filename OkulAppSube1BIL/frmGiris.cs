using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnOgr_Click(object sender, EventArgs e)
        {
            frmOgrKayit frm = new frmOgrKayit();
            frm.Show();
        }

        private void btnOgrt_Click(object sender, EventArgs e)
        {
            frmOgrtKayit frm2 = new frmOgrtKayit();
            frm2.Show();
        }
    }
}
