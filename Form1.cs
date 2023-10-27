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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tk = textTaiKhoan.Text.Trim();
            String mk = textMatKhau.Text.Trim();
            String mktmp="";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = " SELECT pass FROM TaiKhoan WHERE taiKhoan=@tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue( "@tk", tk );
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                mktmp = rdr.GetString(0);
                rdr.Close();

            }
            if(tk.Equals("")||mk.Equals(""))
            {
                MessageBox.Show("Ban chua nhap tai khoan hoac mat khau");
            }
            else if(mk.Equals(mktmp)) {
                conn.Close();
                rdr.Close ();
                Home home = new Home();
                home.setTaiKhoan(tk);
                home.Show();
                Hide();
               
                
                
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác!");
            }
            rdr.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
