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
    public partial class login : Form
    {
        //SqlConnection conn;
        DataTable dt;
        bool ktThem;
        string sql, macu;
        DataGridViewCellMouseEventArgs vt;
        public login()
        {
            InitializeComponent();
        }
        

        private void cmdDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CHCaffe;Integrated Security=True");
            c.Open();

                string TK = txtTK.Text;
                string MK = txtMK.Text;
                sql = "select * from TaiKhoan where TenTK = N'" + TK + "' and MatKhau = N'" + MK + "' ";
               
                SqlCommand cmd = new SqlCommand(sql, c);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    QLCHcaffe f = new QLCHcaffe();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, thử lại", "Thông báo");
                    txtTK.Focus();
                }
                  




        }
       

        private void cmdthoai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoái chương trình ?","thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
