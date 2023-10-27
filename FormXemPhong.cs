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
    public partial class FormXemPhong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private String mp, sotv;
        private String sotvTD, trangthai;
        public void setMP(String mptmp)
        {
            this.mp = mptmp;
        }
      
        public void setTrangThai(String tt)
        {
            this.trangthai = tt;
        }
        public void setSoTVn(String sd)
        {
            this.sotv = sd;
        }
        public void setsoTD(String sn)
        {
            this.sotvTD = sn;
        }
        public FormXemPhong()
        {
            InitializeComponent();
        }
        private void load_grvSV()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From SinhVien Where maPhong='"+mp+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewSVien.DataSource = dt;
            dataGridViewSVien.Refresh();
        }
        //private void load_GrvPhong()
        //{
        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        conn.Open();
        //    }
        //    String sql = "Select * From LoaiPhong Where maLoaiPhong='" + loaiphong + "'";
        //    SqlCommand cmd = new SqlCommand(@sql, conn);
        //    SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
        //    adapter1.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adapter1.Fill(dt);
        //    conn.Close();
        //    dataGridViewLoaiPhong.DataSource = dt;
        //    dataGridViewLoaiPhong.Refresh();
        //}
        private void FormXemPhong_Load(object sender, EventArgs e)
        {
            labelSVHT.Text = this.sotv;
            labelSVTD.Text = this.sotvTD;
            labeltinhTrang.Text = this.trangthai;
            labelTenPhong.Text = this.mp;
            load_grvSV();
            //load_GrvPhong();
        }
    }
}
