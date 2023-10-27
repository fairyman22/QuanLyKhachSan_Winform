using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QuanLyKhachSan
{
    public partial class FormChuyenPhong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        string mp_cu="";
        string mg_cu="";
        string idhd = "";
        string msv;
        public FormChuyenPhong()
        {
            InitializeComponent();
        }
        private void load_cbSV()
        {
            DateTime now = DateTime.Now;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "SELECT *\r\nFROM SinhVien\r\nWHERE maSV IN (SELECT maSinhVien FROM HopDong)\r\n   AND (maSV IN (SELECT maSinhVien FROM HopDong WHERE ketThuc > GETDATE()));\r\n";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);

            conn.Close();
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);

            comboboxSV.DisplayMember = "hoTen";
            comboboxSV.ValueMember = "maSV";
            comboboxSV.DataSource = dt;
        }
        private void load_cbLoaiPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From Phong Where trangThai='Still'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);

            conn.Close();
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);

            comboBoxMaPhong.DisplayMember = "tenPhong";
            comboBoxMaPhong.ValueMember = "maPhong";
            comboBoxMaPhong.DataSource = dt;
        }
        private void load_cbGiuong(String mp)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From Giuong Where maPhong='" + mp + "'" + "and trangThai='Still'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);

            conn.Close();
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);

            comboBoxmaGiuong.DisplayMember = "id";
            comboBoxmaGiuong.ValueMember = "id";
            comboBoxmaGiuong.DataSource = dt;
        }
        private void updatePhong(String mptmp,string sytax)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "UPDATE Phong\r\nSET sothanhVien=sothanhVien "+sytax+" 1\r\nWHERE maPhong= '" + mptmp+ "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void updateGiuong(String mgtmp,String status)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "UPDATE Giuong\r\nSET trangThai='" + status + "'\r\nWHERE id='" + mgtmp + "';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mp_new = comboBoxMaPhong.SelectedValue.ToString();
            string mg_new = comboBoxmaGiuong.SelectedValue.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "ChuyenPhong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maSV", SqlDbType.NVarChar, 50).Value = msv;
            cmd.Parameters.Add("@maPhongCu", SqlDbType.NVarChar, 50).Value = mp_cu;
            cmd.Parameters.Add("@maPhongMoi", SqlDbType.Int).Value = mp_new;
            cmd.Parameters.Add("@maGiuongCu", SqlDbType.NVarChar, 50).Value = mg_cu;
            cmd.Parameters.Add("@maGiuongMoi", SqlDbType.NVarChar,50).Value = mg_new;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
            MessageBox.Show("Lưu thành công!");
           
            //updatePhong(mp, "-");
            //updatePhong(mp_new, "+");
            //updateGiuong(mg_new, "Full");
            //updateGiuong(mg, "Still");

        }

        private void FormChuyenPhong_Load(object sender, EventArgs e)
        {

            load_cbSV();
            load_cbLoaiPhong();
        }
        private void load_HD(string msv)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "SELECT *\r\nFROM HopDong\r\nWHERE maSinhVien='"+msv+"' and  ketThuc > GETDATE();";
            SqlCommand cmd = new SqlCommand(sql, conn);

            using (SqlDataReader rd = cmd.ExecuteReader())
            {

                if (rd.Read())
                {
                    labelID.Text = rd["id"].ToString();
                    this.idhd = rd["id"].ToString();
                    labelTT.Text = rd["trangthai"].ToString();
                    labelGia.Text = rd["gia"].ToString();
                    labelGC.Text = rd["mieuta"].ToString();
                    this.mp_cu = rd["maPhong"].ToString();
                    this.mg_cu = rd["maGiuong"].ToString();
    

                    rd.Close();

                }
            }
            conn.Close();
            comboBoxMaPhong.SelectedValue = mp_cu;
           
        }

        private void comboboxSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.msv = comboboxSV.SelectedValue.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = " SELECT * FROM SinhVien Where maSV='" + msv + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);


            using (SqlDataReader rd = cmd.ExecuteReader())
            {

                if (rd.Read())
                {
                    textMSV.Text = rd["maSV"].ToString();
                    textHoTen.Text = rd["hoTen"].ToString();
                    textNamSinh.Text = rd["namsinh"].ToString();
                    textQueQuan.Text = rd["queQuan"].ToString();
                    textGioiTinh.Text = rd["gioiTinh"].ToString();
                    textSDT.Text = rd["sdt"].ToString();
                    textCCCD.Text = rd["cccd"].ToString();


                    rd.Close();

                }
            }
            conn.Close();
            load_HD(msv);
        }

        private void comboBoxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            String mp = comboBoxMaPhong.SelectedValue.ToString();
            load_cbGiuong(mp);
        }
    }
}
