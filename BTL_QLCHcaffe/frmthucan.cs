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
    public partial class frmthucan : Form
    {
        SqlConnection conn;
        DataTable dtMonAn;
        bool ktThem;
        string sql, macu;
        DataGridViewCellMouseEventArgs vt;

        public void XoaTrang()
        {
            txtMaMon.Text = ""; txtTenMon.Text = "";
            txtMaLoai.Text = ""; txtGia.Text = "";
        }
        public void KhoaMo(bool b)
        {
            dgMonAn.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKT.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
            txtMaMon.ReadOnly = b; txtTenMon.ReadOnly = b;
            txtMaLoai.ReadOnly = b; txtGia.ReadOnly = b;
        }
        public void LayNguon()
        {
            sql = "select MaMonAn,TenMonAn,MaLoai,Gia from MonAn order by MaMonAn Asc";
            dtMonAn = Ketnoi.getdata(sql);
            dgMonAn.DataSource = dtMonAn;
        }
        public frmthucan()
        {
            InitializeComponent();
        }

        private void frmthucan_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            KhoaMo(true);
            LayNguon();
        }

        private void dgMonAn_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgMonAn.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgMonAn.Rows[e.RowIndex];
                txtMaMon.Text = row.Cells[0].Value.ToString();
                txtTenMon.Text = row.Cells[1].Value.ToString();
                txtMaLoai.Text = row.Cells[2].Value.ToString();
                txtGia.Text = row.Cells[3].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            ktThem = true;
            KhoaMo(false);
            txtMaMon.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "") return;
            ktThem = false;
            macu = txtMaMon.Text;
            KhoaMo(false);
            txtMaMon.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "") return;
            macu = txtMaMon.Text;
            if (MessageBox.Show("Bạn có muốn xóa món không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from monan where mamonan = N'" + macu + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "" || txtTenMon.Text == "" || txtMaLoai.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMon.Focus();
                return;
            }
            if (Ketnoi.kttrungma("MonAn", "MaMonAn", ktThem, txtMaMon.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaMon.Focus();
                return;
            }
            if (ktThem == true)//" + gt + "
                sql = "insert into monan(mamonan,tenmonan,maloai,gia) values(N'" + txtMaMon.Text + "',N'" + txtTenMon.Text + "',N'" + txtMaLoai.Text + "',N'" + txtGia.Text + "')";
            else
                sql = "update monan set mamonan=N'" + txtMaMon.Text + "', tenmonan=N'" + txtTenMon.Text + "', maloai=N'" + txtMaLoai.Text + "', gia=N'" + txtGia.Text + "' where mamonan=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            LayNguon();
            try
            {
                dgMonAn_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaMo(true);
                dgMonAn_CellMouseClick(sender, vt);
            }
            catch (Exception ex)
            { }
        }

        private void cmdKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
