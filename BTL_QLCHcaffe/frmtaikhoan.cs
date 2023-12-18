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
    public partial class frmtaikhoan : Form
    {
        SqlConnection conn;
        DataTable dtTaiKhoan;
        bool ktThem;
        string sql, macu;
        DataGridViewCellMouseEventArgs vt;

        public void XoaTrang()
        {
            txtTK.Text = ""; txtTenTK.Text = "";
            txtMK.Text = ""; txtLoaiTK.Text = "";
        }
        public void KhoaMo(bool b)
        {
            dgTaiKhoan.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKT.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
            txtTK.ReadOnly = b; txtTenTK.ReadOnly = b;
            txtMK.ReadOnly = b; txtLoaiTK.ReadOnly = b;
        }
        public void LayNguon()
        {
            sql = "select taikhoan,tentk,matkhau,loaitk from taikhoan order by taikhoan Asc";
            dtTaiKhoan = Ketnoi.getdata(sql);
            dgTaiKhoan.DataSource = dtTaiKhoan;
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            ktThem = true;
            KhoaMo(false);
            txtTK.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "") return;
            ktThem = false;
            macu = txtTK.Text;
            KhoaMo(false);
            txtTK.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "") return;
            macu = txtTK.Text;
            if (MessageBox.Show("Bạn có muốn xóa tài khoản không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from taikhoan where taikhoan = N'" + macu + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "" || txtTenTK.Text == "" || txtMK.Text == "" || txtLoaiTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
                return;
            }
            if (Ketnoi.kttrungma("TaiKhoan", "TaiKhoan", ktThem, txtTK.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTK.Focus();
                return;
            }
            if (ktThem == true)//" + gt + "
                sql = "insert into taikhoan(taikhoan,tentk,matkhau,loaitk) values(N'" + txtTK.Text + "',N'" + txtTenTK.Text + "',N'" + txtMK.Text + "',N'" + txtLoaiTK.Text + "')";
            else
                sql = "update taikhoan set taikhoan=N'" + txtTK.Text + "', tentk=N'" + txtTenTK.Text + "', matkhau=N'" + txtMK.Text + "', loaitk=N'" + txtLoaiTK.Text + "' where taikhoan=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            LayNguon();
            try
            {
                dgTaiKhoan_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaMo(true);
                dgTaiKhoan_CellMouseClick(sender, vt);
            }
            catch (Exception ex)
            { }
        }

        private void cmdKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmtaikhoan_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            KhoaMo(true);
            LayNguon();
        }

        private void dgTaiKhoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgTaiKhoan.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgTaiKhoan.Rows[e.RowIndex];
                txtTK.Text = row.Cells[0].Value.ToString();
                txtTenTK.Text = row.Cells[1].Value.ToString();
                txtMK.Text = row.Cells[2].Value.ToString();
                txtLoaiTK.Text = "Admin";
            }
        }

        public frmtaikhoan()
        {
            InitializeComponent();
        }
    }
}
