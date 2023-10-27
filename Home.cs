using Quanly_Sinhvien;
using quanlynv;
using Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Home : Form
    {
        private String taikhoan;
        public void setTaiKhoan(String taikhoantmp)
        {
            this.taikhoan = taikhoantmp;
        }
        private Form currentFormChild;
        public Home()
        {
            InitializeComponent();
        }
        private void openchildForm(Form child)
        {
            if (currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelBody.Controls.Add(child);
            panelBody.Tag = child;
            child.BringToFront();
            child.Show();
        }
       

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildForm(new FormQuanLyPhongcs());
            labelTitle.Text = btnQLPHong.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildForm(new Nhanvien());
            labelTitle.Text = btnQLNhanVien.Text;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FormDoiMK formDoiMK = new FormDoiMK();
            formDoiMK.setTaiKhoan(taikhoan);
            formDoiMK.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openchildForm(new LoaiPhong());
            labelTitle.Text = button1.Text;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openchildForm(new QuanLyHopDong());
            labelTitle.Text = button2.Text;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            openchildForm(new FormThanhToan());
            labelTitle.Text = btnThanhToan.Text;
        }

        private void btnQLDichVu_Click(object sender, EventArgs e)
        {
            openchildForm(new FormDichVu());
            labelTitle.Text = btnQLDichVu.Text;
        }

        private void btnQLSInhVien_Click(object sender, EventArgs e)
        {
            openchildForm(new DanhSach_SinhVien());
            labelTitle.Text = btnQLSInhVien.Text;
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            openchildForm(new FormChuyenPhong());
            labelTitle.Text = btnChuyenPhong.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildForm(new FormThongKe());
            labelTitle.Text = button3.Text;
        }
    }
}
