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
    public partial class frmTKMonAn : Form
    {
        SqlDataAdapter dab, da, dadg;
        DataTable dtb, dt, dtdg ;
        SqlConnection conn;
        string sql, mahd;
        DataGridViewCellMouseEventArgs vt;

        private void lsbsl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lsbsl_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void lsbsl_VisibleChanged(object sender, EventArgs e)
        {
            
        }
        private void khoamo(bool b)
        {
            cmdtk.Enabled = !b;
        }
        private void xoatrang()
        {
            txtMA.Text = "";
            txtTenMon.Text = "";
            txtSL.Text = "0";
            lswSL.Items.Clear();
        }
        
        private void cmdtk_Click(object sender, EventArgs e)
        {
            lswSL.Items.Clear();
            mahd = txtMA.Text;
            ShowThucDon();
        }
        public void ShowThucDon()
        {
            sql = "select * from chitiethd where mamonan = N'" + mahd + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dt = Ketnoi.getdata(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[0].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][2].ToString());
                item.SubItems.Add(subitem);
                lswSL.Items.Add(item);

            }
            double Tong = 0;
            for (int j = 0; j < lswSL.Items.Count; j++)
            {
                Tong += double.Parse(lswSL.Items[j].SubItems[1].Text);
            }
            txtSL.Text = Tong.ToString();
            lswSL.View = View.Details;
            lswSL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lswSL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void txtMA_TextChanged(object sender, EventArgs e)
        {
            if (txtMA.Text == "")
            {
                khoamo(true);
            } else khoamo(false);
        }

        private void dgMA_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgMA.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgMA.Rows[e.RowIndex];
                txtMA.Text = row.Cells[0].Value.ToString();
                txtTenMon.Text = row.Cells[1].Value.ToString();
            }
        }
        public frmTKMonAn()
        {
            InitializeComponent();
        }
        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            mahd = cbbLoai.SelectedValue.ToString();
            laynguonmonan();
            string s = "select * from loaimonan where maloai='" + cbbLoai.Text + "'";
            DataTable d = Ketnoi.getdata(s);
            foreach (DataRow hang in d.Rows)
                txtTen.Text = hang["tenloai"].ToString();
            string s2 = "select count(*) from monan" + "where maloai='" + cbbLoai.Text + "' group by maloai";
            txtTong.Text = (dgMA.Rows.Count).ToString();
            xoatrang();
        }
        public void laynguonloai()
        {
            sql = "select * from loaimonan";
            dab = new SqlDataAdapter(sql, conn);
            dtb = new DataTable();
            dab.Fill(dtb);
            cbbLoai.DataSource = dtb;
            cbbLoai.DisplayMember = "maloai";
            cbbLoai.ValueMember = "maloai";
        }
        public void laynguonmonan()
        {
            if (mahd == "")
                sql = "select mamonan,tenmonan,gia from monan";
            else sql = "select mamonan,tenmonan,gia from monan where maloai = N'" + mahd + "'";
            dadg = new SqlDataAdapter(sql, conn);
            dtdg = new DataTable();
            dadg.Fill(dtdg);
            dgMA.DataSource = dtdg;
        }
        private void frmTKMonAn_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            laynguonloai();
            khoamo(true);
        }

        private void cmdKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
