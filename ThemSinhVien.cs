
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

namespace Quanly_Sinhvien
{
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string p_masv = txtMasv.Text.Trim();
            string p_lop = txtLop.Text.Trim();
            string p_hoten = txtHoten.Text.Trim();
            int p_namsinh = int.Parse(txtNamsinh.Text.Trim());
            string p_quequan = txtQuequan.Text.Trim();
            int p_sdt = int.Parse( txtSdt.Text.Trim());
            string p_gioitinh = txtSex.Text.Trim();
            string p_maphong = txtMaphong.Text.Trim();
            int p_CCCD = int.Parse(txtCCCD.Text.Trim());
            string p_nganhhoc = txtNganhhoc.Text.Trim();
            int p_namhoc = int.Parse(txtNamsinh.Text.Trim());
            DateTime p_ngay = DateTime.Parse(dtNgay.Text);
            if (con.State == ConnectionState.Closed)
                con.Open();
            String sql = "Insert into SinhVien Values('" + p_masv + "','"+p_lop+"',N'" + p_hoten + "','" + p_namsinh + "',N'" + p_quequan + "','" + p_sdt + "',N'" + p_gioitinh + "','" + p_maphong + "','" + p_CCCD + "',N'"+p_nganhhoc+"','"+p_namhoc+"'," + p_ngay + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm thành công");
        }

        
    }
}
