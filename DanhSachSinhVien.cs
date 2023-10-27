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
    public partial class DanhSach_SinhVien : Form
    {
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


        public DanhSach_SinhVien()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private void Load_grvSinhvien()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            String sql = "Select SinhVien.* from SinhVien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grvSinhvien.DataSource = tb;
            grvSinhvien.Refresh();
        }

        private void DanhSach_SinhVien_Load(object sender, EventArgs e)
        {
            Load_grvSinhvien();
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string maSV = txtNhap.Text.Trim();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string p_sql = "Delete from SinhVien where maSV ='" + maSV + "'";
            SqlCommand cmd = new SqlCommand(p_sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa thành công");
            Load_grvSinhvien();


        }




        private void button1_Click(object sender, EventArgs e)
        {

            string maSV = txtNhap.Text.Trim();
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SinhVien_find", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maSV", SqlDbType.NVarChar, 50).Value = maSV;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            grvSinhvien.DataSource = tb;
            grvSinhvien.Refresh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            SuaSinhVien sua = new SuaSinhVien(msv,lh, ht, ns, qq, so, sex, mp, cc,nganh,nh);
            sua.Show();
            grvSinhvien.Refresh();
            
        }

            private void grvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                int i = e.RowIndex;
                msv = grvSinhvien.Rows[i].Cells[0].Value.ToString();
                lh = grvSinhvien.Rows[i].Cells[1].Value.ToString();
                ht = grvSinhvien.Rows[i].Cells[2].Value.ToString();
                ns = int.Parse(grvSinhvien.Rows[i].Cells[3].Value.ToString());
                qq = grvSinhvien.Rows[i].Cells[4].Value.ToString();
                so = int.Parse(grvSinhvien.Rows[i].Cells[5].Value.ToString());
                sex = grvSinhvien.Rows[i].Cells[6].Value.ToString();
                mp = grvSinhvien.Rows[i].Cells[7].Value.ToString();
                cc = int.Parse(grvSinhvien.Rows[i].Cells[8].Value.ToString());
                nganh = grvSinhvien.Rows[i].Cells[9].Value.ToString();
                nh = int.Parse(grvSinhvien.Rows[i].Cells[10].Value.ToString());
            txtNhap.Text = grvSinhvien.Rows[i].Cells[0].Value.ToString();

            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemSinhVien add = new ThemSinhVien();
            add.Show();
            grvSinhvien.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_grvSinhvien();
        }
    }
    }

