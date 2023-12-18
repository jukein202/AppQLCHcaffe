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
    public partial class frmBan : Form
    {
        SqlConnection conn;
        DataTable dtBanAn;
        bool ktThem;
        string sql, macu;
        DataGridViewCellMouseEventArgs vt;

        public void XoaTrang()
        {
            txtMaBan.Text = ""; txtTenBan.Text = ""; txtTrangThai.Text = "";
        }
        public void KhoaMo(bool b)
        {
            dgBanAn.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKT.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
            txtMaBan.ReadOnly = b; txtTenBan.ReadOnly = b;
            txtTrangThai.ReadOnly = b;
        }
        public void LayNguon()
        {
            sql = "select MaBan,TenBan,TrangThai from Ban order by TenBan Asc";
            dtBanAn = Ketnoi.getdata(sql);
            dgBanAn.DataSource = dtBanAn;
        }
        public frmBan()
        {
            InitializeComponent();
        }

        private void dgBanAn_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgBanAn.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgBanAn.Rows[e.RowIndex];
                txtMaBan.Text = row.Cells[0].Value.ToString();
                txtTenBan.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "1")
                    txtTrangThai.Text = "Có Người";
                else txtTrangThai.Text = "Trống";
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            ktThem = true;
            KhoaMo(false);
            txtMaBan.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "") return;
            ktThem = false;
            macu = txtMaBan.Text;
            KhoaMo(false);
            txtMaBan.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "") return;
            macu = txtMaBan.Text;
            if (MessageBox.Show("Bạn có muốn xóa bàn không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from ban where maban = N'" + macu + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "" || txtTenBan.Text == "" || txtTrangThai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBan.Focus();
                return;
            }
            if (Ketnoi.kttrungma("Ban", "MaBan", ktThem, txtMaBan.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaBan.Focus();
                return;
            }
            if (ktThem == true)//" + gt + "
                sql = "insert into ban(maban,tenban,trangthai) values(N'" + txtMaBan.Text + "',N'" + txtTenBan.Text + "',N'" + txtTrangThai.Text + "')";
            else
                sql = "update ban set maban=N'" + txtMaBan.Text + "', tenban=N'" + txtTenBan.Text + "', trangthai=N'" + txtTrangThai.Text + "' where maban=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            LayNguon();
            try
            {
                dgBanAn_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaMo(true);
                dgBanAn_CellMouseClick(sender, vt);
            }
            catch (Exception ex)
            { }
        }

        private void cmdKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            KhoaMo(true);
            LayNguon();
        }
    }
}
