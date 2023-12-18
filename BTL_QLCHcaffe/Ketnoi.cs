using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLCHcaffe
{
    class Ketnoi
    {
        public static SqlConnection connectDB()
        {
            string connString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=CHCaffe;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public static DataTable getdata(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectDB());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectDB());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        public static bool kttrungma(string tenbang, string tentruong, bool ktthem, string manhap, string macu)
        {
            string sql = "";
            if (ktthem == true)
                sql = "Select " + tentruong + " From " + tenbang + " Where " + tentruong + " = N'" + manhap + "'";
            else
                sql = "Select " + tentruong + " From " + tenbang + " Where " + tentruong + " = N'" + manhap + "' And " + tentruong + " <>N'" + macu + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectDB());
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
