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
using System.Data.SqlTypes;



namespace quanlynv
{
    public partial class Nhanvien : Form
    {
            SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public Nhanvien()
        {
            InitializeComponent();
        }
        public void load_grvNhanvien()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            String sql = "Select * From NhanVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();
            grvNhanvien.DataSource = tb;
            grvNhanvien.Refresh();
        }
        private bool Kiemtraso(String text)
        {
            int kq;
            return int.TryParse(text, out kq);
        }
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            load_grvNhanvien();
        }
       
            private void Form1_Load(object sender, EventArgs e)
        {
            load_grvNhanvien();
        }

        private void btn_Timkiem_Click_1(object sender, EventArgs e)
        {

            String p_manhanvien = txtManhanvien.Text.Trim();
            if (conn.State == ConnectionState.Closed)
                conn.Open();         
            String sql = "Select *from NhanVien Where maNV=@p_manhanvien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@p_manhanvien", p_manhanvien);           
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();
            grvNhanvien.DataSource = tb;
            if (p_manhanvien == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập mã nhân viên để tìm kiếm !");
                return;
            }            
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string p_manhanvien = txtManhanvien.Text.Trim();

            if (conn.State == ConnectionState.Closed)
                conn.Open(); String p_sql = "Delete From Nhanvien where maNV='" + p_manhanvien + "'";
            SqlCommand cmd = new SqlCommand(p_sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Xóa thành công !");
            load_grvNhanvien();
        }      
        private void grvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtManhanvien.Text = grvNhanvien.Rows[i].Cells["maNV"].Value.ToString();
            txtHoten.Text = grvNhanvien.Rows[i].Cells["hoTen"].Value.ToString();
            txtNamsinh.Text = grvNhanvien.Rows[i].Cells["namSinh"].Value.ToString();
            txtTuoi.Text = grvNhanvien.Rows[i].Cells["tuoi"].Value.ToString();
            txtGioitinh.Text = grvNhanvien.Rows[i].Cells["gioitinh"].Value.ToString();
            txtDienthoai.Text = grvNhanvien.Rows[i].Cells["sdt"].Value.ToString();
            txtQue.Text = grvNhanvien.Rows[i].Cells["queQuan"].Value.ToString();
            txtLuongcb.Text = grvNhanvien.Rows[i].Cells["luongCB"].Value.ToString();
            txtUsename.Text = grvNhanvien.Rows[i].Cells["usename"].Value.ToString();
            txtPassword.Text = grvNhanvien.Rows[i].Cells["password"].Value.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
             String p_manhanvien = txtManhanvien.Text.Trim();
            if (p_manhanvien == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập mã sinh viên!");
                return;
            }           
            String p_hoten = txtHoten.Text.Trim();
            if (p_hoten == "")
            {
                txtHoten.Focus();
                MessageBox.Show("Phải nhập họ tên!");
                return;
            }
            String p_namsinh = txtNamsinh.Text.Trim();
            if (p_namsinh == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập năm sinh!");
                return;
            }
            String p_tuoi = txtTuoi.Text.Trim();
            if (!Kiemtraso(txtTuoi.Text.Trim()))
            {
                txtTuoi.Focus();
                MessageBox.Show("Phải nhập số!");
                return;
            }
            String p_gioitinh = txtGioitinh.Text.Trim();
            if (p_gioitinh == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập giới tính!");
                return;
            }
            String p_sodienthoai = txtDienthoai.Text.Trim();
            if (!Kiemtraso(txtDienthoai.Text.Trim()))
            {
                txtDienthoai.Focus();
                MessageBox.Show("Phải nhập số!");
                return;
            }
            String p_quequan = txtQue.Text.Trim();
            if (p_quequan == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập quê quán !");
                return;
            }
            String p_luongcb=txtLuongcb.Text.Trim();
            if (p_luongcb == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập lương cơ bản !");
                return;
            }
            String p_usename = txtUsename.Text.Trim();
            if (p_usename == "")
            {
                txtUsename.Focus();
                MessageBox.Show("Phải nhập UseName!");
                return;
            }
            String p_password = txtPassword.Text.Trim();
            if (p_password == "")
            {
                txtPassword.Focus();
                MessageBox.Show("Phải nhập Password!");
                return;
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            String sql = "Insert into NhanVien Values('" + p_manhanvien + "',N'" + p_hoten + "','"+p_namsinh+"','" + p_tuoi + "',N'" + p_gioitinh + "','" + p_sodienthoai + "','"+p_quequan+"','"+p_luongcb+"','" + p_usename + "','" + p_password + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            load_grvNhanvien();
            MessageBox.Show("Thêm mới thành công!");
        }
       /* private void Checktrungmanhanvien(String p_manhanvien, ref int p_kq)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand("Checktrungmanhanvien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maNV", SqlDbType.NVarChar, 50).Value = p_manhanvien;
            SqlParameter kq = new SqlParameter("@kq", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            p_kq = (int)kq.Value;
            if (p_manhanvien == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Trùng mã nhân viên!");
                return;
            }
        }*/
        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You sure ?", "Notification", MessageBoxButtons.OKCancel)==DialogResult.OK)
                this.Close();
        }
        private void grvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtManhanvien.Text = grvNhanvien.Rows[i].Cells["maNV"].Value.ToString();
            txtHoten.Text = grvNhanvien.Rows[i].Cells["hoTen"].Value.ToString();
            txtNamsinh.Text = grvNhanvien.Rows[i].Cells["namSinh"].Value.ToString();
            txtTuoi.Text = grvNhanvien.Rows[i].Cells["tuoi"].Value.ToString();
            txtGioitinh.Text = grvNhanvien.Rows[i].Cells["gioitinh"].Value.ToString();
            txtDienthoai.Text = grvNhanvien.Rows[i].Cells["sdt"].Value.ToString();
            txtQue.Text = grvNhanvien.Rows[i].Cells["queQuan"].Value.ToString();
            txtLuongcb.Text = grvNhanvien.Rows[i].Cells["luongCB"].Value.ToString();
            txtUsename.Text = grvNhanvien.Rows[i].Cells["usename"].Value.ToString();
            txtPassword.Text = grvNhanvien.Rows[i].Cells["password"].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            String p_manhanvien = txtManhanvien.Text.Trim();
            if (p_manhanvien == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập mã sinh viên!");
                return;
            }
            String p_hoten = txtHoten.Text.Trim();
            if (p_hoten == "")
            {
                txtHoten.Focus();
                MessageBox.Show("Phải nhập họ tên!");
                return;
            }
            String p_namsinh = txtNamsinh.Text.Trim();
            if (p_namsinh == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập năm sinh!");
                return;
            }
            String p_tuoi = txtTuoi.Text.Trim();
            if (!Kiemtraso(txtTuoi.Text.Trim()))
            {
                txtTuoi.Focus();
                MessageBox.Show("Phải nhập số!");
                return;
            }
            String p_gioitinh = txtGioitinh.Text.Trim();
            if (p_gioitinh == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập giới tính!");
                return;
            }
            String p_sodienthoai = txtDienthoai.Text.Trim();
            if (!Kiemtraso(txtDienthoai.Text.Trim()))
            {
                txtDienthoai.Focus();
                MessageBox.Show("Phải nhập số!");
                return;
            }
            String p_quequan = txtQue.Text.Trim();
            if (p_quequan == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập quê quán !");
                return;
            }
            String p_luongcb = txtLuongcb.Text.Trim(); if (p_luongcb == "")
            {
                txtManhanvien.Focus();
                MessageBox.Show("Phải nhập lương cơ bản !");
                return;
            }
            String p_usename = txtUsename.Text.Trim();
            if (p_usename == "")
            {
                txtUsename.Focus();
                MessageBox.Show("Phải nhập UseName!");
                return;
            }
            String p_password = txtPassword.Text.Trim();
            if (p_password == "")
            {
                txtPassword.Focus();
                MessageBox.Show("Phải nhập Password!");
                return;
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            String sql = "Update Nhanvien set hoTen=N'" + p_hoten + "',namSinh='" + p_namsinh + "',tuoi='" + p_tuoi + "',gioitinh=N'" + p_gioitinh + "',sdt='" + p_sodienthoai + "',queQuan='" + p_quequan + "',luongCB='" + p_luongcb + "',usename=N'" + p_usename + "',password=N'" + p_password + "'where maNV='" + p_manhanvien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            load_grvNhanvien();
            MessageBox.Show("Sửa thành công!");
        }
        int i;
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            load_grvNhanvien();
        }
    }
}
