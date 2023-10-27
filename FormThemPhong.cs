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
    public partial class FormThemPhong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public FormThemPhong()
        {
            InitializeComponent();
        }
        private void load_checkListDV()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT * FROM DichVu";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string item = reader["maDV"].ToString();
            }

        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            load_checkListDV();

        }
        private void themDV(String mp,string mdv)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("ThemDVP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maDV", SqlDbType.NVarChar, 50).Value = mdv;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            
        }
        

        
        private int checkTrungmaPhong(String mp)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("CheckTrungMaPhong", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
            cmd.Parameters.Add(param).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            int kq = (int)param.Value;
            return kq;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            String mp = textMaPhong.Text.Trim();
            String ten = textTenPhong.Text.Trim();
            String tt = comboTrangThai.SelectedText.Trim();
            float stv = float.Parse(textSoSvHT.Text.Trim());
            float td = float.Parse((textBoxSoTVTD.Text.Trim()));
            
            if (checkTrungmaPhong(mp) == 1)
            {
                MessageBox.Show("Ma phong da ton tai");
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ThemPhong", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
                cmd.Parameters.Add("@tenPhong", SqlDbType.NVarChar, 50).Value = ten;
                cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = tt;
                cmd.Parameters.Add("@sothanhVien", SqlDbType.Float).Value = stv;
                cmd.Parameters.Add("@soLuongTD", SqlDbType.Float).Value = td;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Thêm Thành công!");
            }
            
        }
    }
}
