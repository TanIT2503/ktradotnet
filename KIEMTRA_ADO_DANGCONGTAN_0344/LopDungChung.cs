using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIEMTRA_ADO_DANGCONGTAN_0344
{
    class LopDungChung
    {
        String ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Tan\KIEMTRA_ADO_DANGCONGTAN_0344\KIEMTRA_ADO_DANGCONGTAN_0344\SANPHAM.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(ketnoi);
        }
        public void NonQuery(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int ketqua = cmd.ExecuteNonQuery();
            conn.Close();
            if (ketqua >= 1)
                MessageBox.Show("Thành công.");
            else
                MessageBox.Show("Thất bại.");
        }
        public object Scalar(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int ketQua = (int)cmd.ExecuteScalar();
            conn.Close();
            return ketQua;
        }

        public DataTable LoadGrid(string sql)
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable LoadCombo(string sql)
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
