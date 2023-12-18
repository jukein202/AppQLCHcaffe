using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLCHcaffe
{
    public partial class frmQLHoadon : Form
    {
        DataTable dt;
        bool ktThem;
        string sql, macu;
        DataGridViewCellMouseEventArgs vt;
        public void xoatrang()
        {
            txtmahd.Text = ""; txtTenKH.Text = ""; txtmaBan.Text = ""; txtTongTien.Text = "";
            dtpNgayban.Value = DateTime.Today;
        }
        public void laynguon()
        {
            sql = "select mahd,ngayban,tenkh,maban,tongtien from hoadon ";
            dt = Ketnoi.getdata(sql);

            dghd.DataSource = dt;
        }
        public frmQLHoadon()
        {
            InitializeComponent();
        }

        private void frmQLHoadon_Load(object sender, EventArgs e)
        {
            laynguon();
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=CHCaffe;Integrated Security=True");
            c.Open();
            if (txtmahd.Text == "") return;
            macu = txtmahd.Text;
            if (MessageBox.Show("bạn có muốn xóa hóa đơn này không ?", "thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from hoadon where mahd = N'" + macu + "'";
                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.ExecuteNonQuery();
                dgchitiethd.DataSource = "";
                xoatrang();
                laynguon();
            }
        }

        private void cmdxem_Click(object sender, EventArgs e)
        {
            sql = "select * from chitiethd where mahd='" + txtmahd.Text + "'";
            DataTable dt = Ketnoi.getdata(sql);
            dgchitiethd.DataSource = dt;
        }

        private void cmdketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dghd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dghd.RowCount <= 0) return;
            if (e.RowIndex >= 0) //có chọn q dòng index nà đó
            {
                vt = e;
                DataGridViewRow row = dghd.Rows[e.RowIndex];
                txtmahd.Text = row.Cells[0].Value.ToString();
                dtpNgayban.Text = row.Cells[1].Value.ToString();
                txtTenKH.Text = row.Cells[2].Value.ToString();
                txtmaBan.Text = row.Cells[3].Value.ToString();
                txtTongTien.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
