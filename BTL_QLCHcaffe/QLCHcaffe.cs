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
    public partial class QLCHcaffe : Form
    {

        SqlConnection conn;
        DataTable dt;
        bool ktThem;
        string sql, macu;
        DataGridViewCellMouseEventArgs vt;
        private void xoatrang()
        {
            txtMaHD.Text = "";
            txttenKH.Text = "";
            cbbMaMA.SelectedIndex = -1;
            cbbMaDM.SelectedIndex = -1;
            cbbMaBan.SelectedIndex = -1;
            txttenKH.Text = "";
            txtSL.Text = "";
            txtDG.Text = "0";
            txtThanhtien.Text = "0";
            txtTongtien.Text = "0";
            listView1.Items.Clear();
        }
        private void khoamo(bool b)
        {
            txtMaHD.ReadOnly = !b;
            cbbMaBan.Enabled = !b;
            cbbMaDM.Enabled = !b;
            txttenKH.ReadOnly = b;
            cbbMaMA.Enabled = !b;
            txtMaHD.ReadOnly = b;
            cmdluu.Enabled = !b;
            txtSL.ReadOnly = b;
            cmdthem.Enabled = b;
            dtpdate.Enabled = !b;
            cmdTT.Enabled = !b;
        }
        public void TinhTT()
        {
            double tt, sl, dg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);
            if (txtDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDG.Text);
            tt = sl * dg;
            txtThanhtien.Text = tt.ToString();
        }
        public QLCHcaffe()
        {
            InitializeComponent();
        }

        private void mnudangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuadmin_Click(object sender, EventArgs e)
        {
            admin frm = new admin();
            frm.ShowDialog();
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            khoamo(false);
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã Hóa Đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return;
            }
            if (cbbMaBan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã Bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaBan.Focus();
                return;
            }
            if (txttenKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên Khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenKH.Focus();
                return;
            }
            if ((txtSL.Text.Length == 0) || (txtSL.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Text = "";
                txtSL.Focus();
                return;
            }
            if(Ketnoi.kttrungma("hoadon", "mahd", ktThem, txtMaHD.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHD.Focus();
                return;
            }
            ListViewItem itemlv;
            double tt, sl, dg;
            double TongTien = 0;
            string DLLV;
            sl = Convert.ToDouble(txtSL.Text);
            dg = Convert.ToDouble(txtDG.Text);
            tt = sl * dg;
            itemlv = new ListViewItem(new[] { "" + cbbMaMA.Text + "", "" + txtSL.Text + "", "" + txtDG.Text + "", "" + txtThanhtien.Text + "" });
            listView1.Items.Add(itemlv);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                TongTien += double.Parse(listView1.Items[i].SubItems[3].Text);
            }
            txtTongtien.Text = TongTien.ToString();
            sql = "insert into chitiethd(mahd,mamonan,soluong,thanhtien) values(N'" + txtMaHD.Text +
                "', N'" + cbbMaMA.SelectedValue + "', N'" + txtSL.Text + "', N'" + txtThanhtien.Text + "') ";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void cmdTT_Click(object sender, EventArgs e)
        {
            
            string dtngayban = dtpdate.Value.ToString("MM/dd/yyyy");
            sql = "insert into hoadon(mahd,ngayban,tenkh,maban,tongtien) values(N'" + txtMaHD.Text +
                "',N'" + dtngayban + "',N'" + txttenKH.Text + "' ,N'" + cbbMaBan.SelectedValue + "' ,N'" + txtTongtien.Text + "' )";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            frmChiTietHD frm = new frmChiTietHD();
            frm.Mahd = txtMaHD.Text;
            frm.date = dtpdate.Text;
            frm.ban = cbbMaBan.Text;
            frm.KH = txttenKH.Text;
            frm.TT = txtTongtien.Text;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                frm.list += "\n";
                frm.list += listView1.Items[i].Text;
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                frm.SL += "\n";
                frm.SL += listView1.Items[i].SubItems[1].Text;
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                frm.DG += "\n";
                frm.DG += listView1.Items[i].SubItems[2].Text;
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                frm.tt += "\n";
                frm.tt += listView1.Items[i].SubItems[3].Text;
            }
            xoatrang();
            frm.ShowDialog();
            khoamo(true);
        }

        private void cbbMaMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaMA.SelectedIndex < 0) return;
            string ma = cbbMaMA.SelectedValue.ToString();
            if (ma == "") return;
            sql = "select gia from monan where mamonan='" + ma + "'";
            DataTable dt = Ketnoi.getdata(sql);
            if (dt.Rows.Count > 0)
                txtDG.Text = dt.Rows[0]["Gia"].ToString();
            TinhTT();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            TinhTT();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cbbMaDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaDM.Text == "") return;
            string madm = cbbMaDM.SelectedValue.ToString();
            Ketnoi.FillCombo("SELECT MaMonAn, TenMonAn FROM MonAn where maloai='" + madm + "'", cbbMaMA, "MaMonAn", "TenMonAn");
        }

        private void QLCHcaffe_Load(object sender, EventArgs e)
        {
            khoamo(true);
            conn = Ketnoi.connectDB();
            Ketnoi.FillCombo("SELECT MaBan, TenBan FROM Ban", cbbMaBan, "MaBan", "TenBan");
            cbbMaBan.SelectedIndex = -1;
            Ketnoi.FillCombo("SELECT MaLoai, TenLoai FROM LoaiMonAn", cbbMaDM, "MaLoai", "TenLoai");
            cbbMaDM.SelectedIndex = -1;
            Ketnoi.FillCombo("SELECT MaMonAn, TenMonAn FROM MonAn", cbbMaMA, "MaMonAn", "TenMonAn");
            cbbMaMA.SelectedIndex = -1;
        }
    }
}
