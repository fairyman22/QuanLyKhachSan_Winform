using Microsoft.Office.Interop.Excel;
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
    public partial class ThemHopDong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public ThemHopDong()
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
            String sql = "SELECT *\r\nFROM SinhVien\r\nWHERE maSV NOT IN (SELECT maSinhVien FROM HopDong)\r\n   OR (maSV IN (SELECT maSinhVien FROM HopDong WHERE ketThuc < GETDATE()));\r\n";
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
            String sql = "Select * From Giuong Where maPhong='"+mp+"'"+"and trangThai='Still'";
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
        private int checkMSV(String msv)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("CheckTrungMSV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add("@maSV", SqlDbType.NVarChar, 50).Value = msv;
            cmd.Parameters.Add(param).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            int kq = (int)param.Value;
            return kq;

        }
        private int checMHD(String mhd)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("CheckTrungMaHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = mhd;
            cmd.Parameters.Add(param).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            int kq = (int)param.Value;
            return kq;
        }
        private void ThemSV()
        {
          
            String msv = textMSV.Text.Trim();
            String tenSv = textHoTen.Text.Trim();
            int namsinh = int.Parse(textNamSinh.Text.Trim());
            String que = textQueQuan.Text.Trim();
            String gt = textGioiTinh.Text.Trim();
            int sdt = int.Parse(textSDT.Text.Trim());
            int cccd = int.Parse(textBoxCCCD.Text.Trim());
            String mp = comboBoxMaPhong.SelectedValue.ToString();


            if (checkMSV(msv) == 1)
            {
                MessageBox.Show("Ma phong da ton tai");
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ThemSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.NVarChar, 50).Value = mp;
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value = tenSv;
                cmd.Parameters.Add("@namsinh", SqlDbType.Int).Value = namsinh;
                cmd.Parameters.Add("@queQuan", SqlDbType.NVarChar, 50).Value = que;
                cmd.Parameters.Add("@sdt", SqlDbType.Int).Value = sdt;
                cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar, 50).Value = gt;
                cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp ;
                cmd.Parameters.Add("@cccd", SqlDbType.Int).Value = cccd;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Thêm SV Thành công!");
            }
        }
        private void checkTTP(string mp)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "UPDATE Phong SET trangThai = 'Full' WHERE maPhong = '" + mp + "'and sothanhVien=8";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void tangSTV(string mp)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "UPDATE Phong SET sothanhVien = sothanhVien + 1 WHERE maPhong = '"+mp+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            checkTTP(mp);
        }
        private void updateSV(string msv,string mp)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //B3: Tạo đối tượng cmd để thực hiện sửa
            String p_sql = "Update SinhVien set hoTen = N'"+ mp + "' where  maSV ='" + msv + "'";

            SqlCommand cmd = new SqlCommand(p_sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            String mhd = textBoxIDHD.Text;
            String masv = textMSV.Text.Trim();
            DateTime bd = dateTimePickerBD.Value;
            DateTime kt = dateTimePickerKT.Value;
            String tt = textBoxTrangThai.Text.Trim();
            String mt = textBoxGhiChu.Text.Trim();
            String mp = comboBoxMaPhong.SelectedValue.ToString();
            String mg = comboBoxmaGiuong.SelectedValue.ToString();
            int gia = int.Parse(textGia.Text.ToString());

            if (checMHD(mhd) == 1)
            {
                MessageBox.Show("Ma hop dong da ton tai");
            }
            else
            {
 
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ThemHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = mhd;
                cmd.Parameters.Add("@maSV", SqlDbType.NVarChar, 50).Value = masv;
                cmd.Parameters.Add("@batDau", SqlDbType.Date).Value = bd;
                cmd.Parameters.Add("@ketThuc", SqlDbType.Date).Value = kt;
                cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = tt;
                cmd.Parameters.Add("@mieuTa", SqlDbType.NVarChar, 50).Value = mt;
                cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
                cmd.Parameters.Add("@maGiuong", SqlDbType.NVarChar, 50).Value = mg;
                cmd.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                //tangSTV(mp);
                MessageBox.Show("Thêm Hop Dong Thành công!");
            }



        }

        private void ThemHopDong_Load(object sender, EventArgs e)
        {
            load_cbLoaiPhong();
            load_cbSV();
        }

        private void btnMG_Click(object sender, EventArgs e)
        {
            String mp = comboBoxMaPhong.SelectedValue.ToString();
            load_cbGiuong(mp);
        }

        private void comboBoxMaPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            String mp = comboBoxMaPhong.SelectedValue.ToString();
            load_cbGiuong(mp);
        }

        private void comboboxSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String masv = comboboxSV.SelectedValue.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = " SELECT * FROM SinhVien Where maSV='"+masv+"'";
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
                    textBoxCCCD.Text = rd["cccd"].ToString();

                    rd.Close();

                }
            }


                
        }
    }
}
