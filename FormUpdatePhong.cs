using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QuanLyKhachSan
{
    public partial class FormUpdatePhong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private String mp;
        
        
        public void setMP(String mptmp)
        {
            this.mp = mptmp;
        }
        public FormUpdatePhong()
        {
            InitializeComponent();
        }
        //private void load_checkListDV()
        //{
        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        conn.Open();
        //    }
        //    string query = "SELECT * FROM DichVu";
        //    SqlCommand command = new SqlCommand(query, conn);
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        string item = reader["maDV"].ToString();
        //        checkedListBox1.Items.Add(item);
        //    }

        //}

        private void FormUpdatePhong_Load(object sender, EventArgs e)
        {
            labelTenPhong.Text = mp;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = " SELECT * FROM Phong Where maPhong='" +mp + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);


            using (SqlDataReader rd = cmd.ExecuteReader())
            {

                if (rd.Read())
                {
                    textPhong.Text = rd["tenPhong"].ToString();
                    comboTrangThai.SelectedText = rd["trangThai"].ToString();
                    textSlHT.Text = rd["sothanhVien"].ToString();
                    textSLTD.Text = rd["soLuongTD"].ToString();
                    
                    rd.Close();

                }
            }

            //load_cbLoaiPhong();
        }
        //private void load_cbLoaiPhong()
        //{
        //    if (conn.State==ConnectionState.Closed)
        //    {
        //        conn.Open();
        //    }
        //    String sql = "Select * From loaiPhong";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    adapter.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);

        //    conn.Close();
        //    DataRow dr = dt.NewRow();
        //    dt.Rows.InsertAt(dr,0);

        //    cbLoaiPhong.DisplayMember = "tenLoaiPhong";
        //    cbLoaiPhong.ValueMember = "maLoaiPhong";
        //    cbLoaiPhong.DataSource = dt;
        //}
        private void themDV(String mp, string mdv)
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
        private void xoaDV(String mp)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("DeleteDVP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int slht = int.Parse(textSlHT.Text.Trim());
            int sltd = int.Parse(textSLTD.Text.Trim());
            String trangThai = comboTrangThai.SelectedText.ToString();
            String tenphong = textPhong.Text.Trim();
            
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("UpdatePhong", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value=mp;
            cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = trangThai;
            cmd.Parameters.Add("@soThanhVien", SqlDbType.Int).Value = slht;
            cmd.Parameters.Add("@tenPhong", SqlDbType.NVarChar, 50).Value = tenphong;
            cmd.Parameters.Add("@soLuongTD", SqlDbType.Int).Value = sltd;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
            MessageBox.Show("Lưu thành công!");
            //xoaDV(mp);
            //foreach (String item in checkedListBox1.CheckedItems)
            //{

            //    themDV(mp, item);
            //}


        }
    }
}
