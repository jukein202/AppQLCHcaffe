using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_QLCHcaffe
{
    public partial class frmDoanhThu : Form
    {
        SqlConnection conn;
        SqlDataAdapter dab, dadg,da;
        DataTable dtb, dtdg,dt;
        string sql, mahd;
        string[] ArrLama = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] ArrNumber = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        //int len = ArrLama.Length;


        private void khoamo(bool b)
        {
            cmdTK.Enabled = b;
            cbbmahd.Enabled = b;
            cmdTKA.Enabled = b;
            for (int i=0; i < (ArrLama.Length - 1); i++)
            {
                if (ArrLama[i] == "M")
                    ArrNumber[i] = 1000;
            }
        }
        private void xoatrang()
        {
            txtTongTien.Text = "0";
            txtTongALL.Text = "0";
        }
        private void dtNhan_ValueChanged(object sender, EventArgs e)
        {
            string dtngaynhan = dtNhan.Value.ToString("MM/dd/yyyy");
            string dtngaytra = dtTra.Value.ToString("MM/dd/yyyy");
            xoatrang();
            sql = "select mahd from hoadon where ngayban between '" + dtngaynhan + "' and '" + dtngaytra + "'";
            dab = new SqlDataAdapter(sql, conn);
            dtb = new DataTable();
            dab.Fill(dtb);
            cbbmahd.DataSource = dtb;
            
            if (cbbmahd.Items.Count == 0)
            {
                cbbmahd.Text = "";
                khoamo(false);
            }
            else khoamo(true);
        }

        private void cmdTKA_Click(object sender, EventArgs e)
        {
            string dtngaynhan = dtNhan.Value.ToString("MM/dd/yyyy");
            string dtngaytra = dtTra.Value.ToString("MM/dd/yyyy");
            double tong = 0;
            lswhh.Items.Clear();
            lswHD.Items.Clear();
            sql = "select mahd from hoadon where ngayban between '" + dtngaynhan + "' and '" + dtngaytra + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dt = Ketnoi.getdata(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[0].ToString());
                lswhh.Items.Add(item);
            }
            
            for (int j=0;j<lswhh.Items.Count;j++)
            {
                lswHD.Items.Clear();
                mahd = lswhh.Items[j].SubItems[0].Text;
                ShowThucDon();
                double t = double.Parse(txtTongTien.Text);
                tong += t;
            }
            txtTongALL.Text = tong.ToString();
        }

        private void dtTra_ValueChanged(object sender, EventArgs e)
        {
            string dtngaynhan = dtNhan.Value.ToString("MM/dd/yyyy");
            string dtngaytra = dtTra.Value.ToString("MM/dd/yyyy");
            xoatrang();
            sql = "select mahd from hoadon where ngayban between '" + dtngaynhan + "' and '" + dtngaytra + "'";
            dab = new SqlDataAdapter(sql, conn);
            dtb = new DataTable();
            dab.Fill(dtb);
            cbbmahd.DataSource = dtb;
            if (cbbmahd.Items.Count == 0)
            {
                cbbmahd.Text = "";
                khoamo(false);
            }
            else khoamo(true);
        }

        private void cmdKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdTK_Click(object sender, EventArgs e)
        {
            txtTongALL.Text = "0";
            lswHD.Items.Clear();
            mahd = cbbmahd.SelectedValue.ToString();
            ShowThucDon();
        }

        DataGridViewCellMouseEventArgs vt;

        private void cbbdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            mahd = cbbmahd.SelectedValue.ToString();
            laynguonhd();
        }

        public frmDoanhThu()
        {
            InitializeComponent();
        }
        public void laynguonhd()
        {
            if (mahd == "")
                sql = "select mahd,maban,ngayban from hoadon";
            else sql = "select mahd,maban,ngayban from hoadon where mahd = N'" + mahd + "'";
            dadg = new SqlDataAdapter(sql, conn);
            dtdg = new DataTable();
            dadg.Fill(dtdg);
            dgDT.DataSource = dtdg;
        }
        public void laynguonmahd()
        {
            sql = "select mahd from hoadon";
            dab = new SqlDataAdapter(sql, conn);
            dtb = new DataTable();
            dab.Fill(dtb);
            cbbmahd.DataSource = dtb;
            cbbmahd.DisplayMember = "mahd";
            cbbmahd.ValueMember = "mahd";
        }
        public void ShowThucDon()
        {
            sql = "select * from chitiethd where mahd = N'" + mahd + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dt = Ketnoi.getdata(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[1].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                item.SubItems.Add(subitem);
                item.SubItems.Add(dr[2].ToString());
                sql = "select gia from monan where mamonan='" + dr[1].ToString() + "'";
                DataTable dtg = Ketnoi.getdata(sql);
                if (dt.Rows.Count > 0)
                    item.SubItems.Add(dtg.Rows[0]["Gia"].ToString());
                double tt, sl, dg;
                sl = Convert.ToDouble(dr[2].ToString());
                dg = Convert.ToDouble(dtg.Rows[0]["Gia"].ToString());
                tt = sl * dg;
                item.SubItems.Add(tt.ToString());
                lswHD.Items.Add(item);
                }
            double TongTien = 0;
            for (int j = 0; j < lswHD.Items.Count; j++)
            {
                TongTien += double.Parse(lswHD.Items[j].SubItems[4].Text);
            }
            txtTongTien.Text = TongTien.ToString();
            lswHD.View = View.Details;
            lswHD.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lswHD.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            khoamo(false);
            mahd = "";
            laynguonhd();
            laynguonmahd();
        }
    }
}
