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
    public partial class frmDanhmuc : Form
    {
        SqlConnection conn;
        DataTable dtLoaiMon;
        bool ktThem;
        string sql, macu;
        DataGridViewCellMouseEventArgs vt;

        public void XoaTrang()
        {
            txtMaLoai.Text = ""; txtTenLoai.Text = "";
        }
        public void KhoaMo(bool b)
        {
            dgLoaiMon.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKT.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
            txtMaLoai.ReadOnly = b; txtTenLoai.ReadOnly = b;
        }
        public void LayNguon()
        {
            sql = "select MaLoai,TenLoai from LoaiMonAn order by MaLoai Asc";
            dtLoaiMon = Ketnoi.getdata(sql);
            dgLoaiMon.DataSource = dtLoaiMon;
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            ktThem = true;
            KhoaMo(false);
            txtMaLoai.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "") return;
            ktThem = false;
            macu = txtMaLoai.Text;
            KhoaMo(false);
            txtMaLoai.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "") return;
            macu = txtMaLoai.Text;
            if (MessageBox.Show("Bạn có muốn xóa loại món không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from loaimonan where maloai = N'" + macu + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "" || txtTenLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                return;
            }
            if (Ketnoi.kttrungma("LoaiMonAn", "MaLoai", ktThem, txtMaLoai.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLoai.Focus();
                return;
            }
            if (ktThem == true)//" + gt + "
                sql = "insert into loaimonan(maloai,tenloai) values(N'" + txtMaLoai.Text + "',N'" + txtTenLoai.Text + "')";
            else
                sql = "update loaimonan set maloai=N'" + txtMaLoai.Text + "', tenloai=N'" + txtTenLoai.Text + "' where maloai=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            LayNguon();
            try
            {
                dgLoaiMon_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaMo(true);
                dgLoaiMon_CellMouseClick(sender, vt);
            }
            catch (Exception ex)
            { }
        }

        private void cmdKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhmuc_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            KhoaMo(true);
            LayNguon();
        }

        private void dgLoaiMon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgLoaiMon.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgLoaiMon.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells[0].Value.ToString();
                txtTenLoai.Text = row.Cells[1].Value.ToString();
            }
        }

        public frmDanhmuc()
        {
            InitializeComponent();
        }


    }
}
