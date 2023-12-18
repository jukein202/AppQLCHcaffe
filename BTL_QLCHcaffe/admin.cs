using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLCHcaffe
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhmuc frm = new frmDanhmuc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthucan frm = new frmthucan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan frm = new frmBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQLHD_Click(object sender, EventArgs e)
        {
            frmQLHoadon frm = new frmQLHoadon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtaikhoan frm = new frmtaikhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tKMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKMonAn frm = new frmTKMonAn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThu frm = new frmDoanhThu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
