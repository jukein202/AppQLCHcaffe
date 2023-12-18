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
    public partial class frmChiTietHD : Form
    {
        public string Mahd;
        public string list;
        public string date;
        public string ban;
        public string KH;
        public string TT;
        public string SL;
        public string DG;
        public string tt;
        public frmChiTietHD()
        {
            InitializeComponent();
        }

        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            lbMaHD.Text = Mahd;
            lblv.Text = list;
            lbdate.Text = date;
            lbBan.Text = ban;
            lbKH.Text = KH;
            lbTT.Text = TT;
            lbSL.Text = SL;
            lbDG.Text = DG;
            lbThanhTien.Text = tt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
