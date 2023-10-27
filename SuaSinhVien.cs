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

namespace Quanly_Sinhvien
{
    public partial class SuaSinhVien : Form
    {
        private string maSV ;
        private string lop;
        private string hoTen ;
        private int namsinh;
        private string queQuan ;
        private int sdt;
        private string gioiTinh;
        private string maPhong;
        private int cccd;
        private string nganhHoc;
        private int namHoc;
        
        public void setTT(String maSv, String lop, String hoTen, int namsinh, String queQuan, int sdt, String gioiTinh, String maPhong,int cccd, String nganhHoc,int namHoc)
        {
            this.maSV = maSv;
            this.lop = lop;
            this.hoTen = hoTen;
            this.namsinh = namsinh;
            this.queQuan = queQuan;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
            this.maPhong = maPhong;
            this.cccd = cccd;
            this.nganhHoc = nganhHoc;
            this.namHoc = namHoc;
           

        }
        public SuaSinhVien()
        {
            InitializeComponent();
        }

        public SuaSinhVien(string msv, string lh, string ht, int ns, string qq, int so, string sex, string mp, int cc, string nganh, int nh):this()
        {
            this.msv = msv;
            this.lh = lh;
            this.ht = ht;
            this.ns = ns;
            this.qq = qq;
            this.so = so;
            this.sex = sex;
            this.mp = mp;
            this.cc = cc;
            this.nganh = nganh;
            this.nh = nh;
        }

        SqlConnection con = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private string msv;
        private string lh;
        private string ht;
        private int ns;
        private string qq;
        private int so;
        private string sex;
        private string mp;
        private int cc;
        private string nganh;
        private int nh;
        private void Checktrungmasv(String maSV, ref int p_kq)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("Checktrungmasv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maSV", SqlDbType.NVarChar, 50).Value = maSV;
            SqlParameter kq = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            p_kq = (int)kq.Value;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            string maSV = txtMasv.Text;
            string lop = txtLop.Text.Trim();
            string hoTen = txtHoten.Text.Trim();
            int namsinh  = int.Parse(txtNamsinh.Text.Trim());
            string queQuan = txtQuequan.Text.Trim();
            int sdt = int.Parse(txtSdt.Text.Trim());
            string gioiTinh = txtSex.Text.Trim();
            string maPhong = txtMaphong.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            string nganhHoc = txtNganhhoc.Text.Trim();
            int namHoc = int.Parse(txtNamhoc.Text.Trim());
            DateTime ngay = dtNgay.Value;
            if (con.State == ConnectionState.Closed)
                con.Open();
            //B3: Tạo đối tượng cmd để thực hiện sửa
            String p_sql = "Update SinhVien set lop ='"+lop+"', hoTen = N'" + hoTen + "',namsinh = '" + namsinh + "', queQuan =N'" + queQuan + "',sdt ='" + sdt + "', gioiTinh ='"+gioiTinh+"', maPhong ='"+maPhong+"',cccd ='"+cccd+"',nganhHoc ='"+nganhHoc+"',namHoc ='"+namHoc+"',ngay ='"+ngay+"' where maSV ='"+maSV+"'";
            SqlCommand cmd = new SqlCommand(p_sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
                   
            
            
        }

        private void SuaSinhVien_Load(object sender, EventArgs e)
        { 
            txtMasv.Text = msv.ToString();
            txtLop.Text = lh.ToString();
            txtHoten.Text = ht.ToString();
            txtNamsinh.Text= ns.ToString();
            txtQuequan.Text = qq.ToString();
            txtSdt.Text = so.ToString();
            txtSex.Text = sex.ToString();
            txtMaphong.Text = mp.ToString();
            txtCCCD.Text = cc.ToString();
            txtNganhhoc.Text = nganh.ToString();
            txtNamhoc.Text = nh.ToString();

        }
    }
}
