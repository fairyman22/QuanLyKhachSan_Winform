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

namespace QuanLyKhachSan
{
    public partial class FormDoiMK : Form
    {
        private String taikhoan;
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public void setTaiKhoan(String taikhoantmp)
        {
            this.taikhoan = taikhoantmp;
        }
        public FormDoiMK()
        {
            InitializeComponent();
            

        }
        public String getMatKhau()
        {
            
            
            String mktmp = "";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = " SELECT pass FROM TaiKhoan WHERE taiKhoan=@tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tk", taikhoan);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                mktmp = rdr.GetString(0);
                rdr.Close();

            }
            return mktmp;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            String mtkhaucu=getMatKhau();
            String mkCu = textMKcu.Text.Trim();
            String mkMoi = textMKmoi.Text.Trim();
            String mkMoi2 = textMKmoi2.Text.Trim();

            if ( mtkhaucu.Equals(mkCu)) {
                if (mkMoi.Equals(mkMoi2))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("DoiMK", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add("@taiKhoan", SqlDbType.NVarChar, 50).Value = taikhoan;
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 50).Value = mkMoi;
                    
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    MessageBox.Show("DOi mat khau thanh cong!");
                    

                }
                else
                {
                    MessageBox.Show("Bạn nhập lại mật khẩu không chính xác!");
                }
            
            }
            else
            {
                MessageBox.Show("Nhập sai mật khẩu hiện tại!");
            }
            
            

        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
