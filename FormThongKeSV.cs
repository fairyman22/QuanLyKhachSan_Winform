using System;
using System.Collections;
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
    public partial class FormThongKeSV : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public FormThongKeSV()
        {
            InitializeComponent();
        }
        private void load_chartGT()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = " SELECT gioiTinh, COUNT(*) AS Count\r\nFROM SinhVien\r\nGROUP BY gioiTinh";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                int column2Value = Convert.ToInt32(reader[1]);
                

                // Đổ dữ liệu vào Series của Chart
                chartGT.Series["Số sinh viên"].Points.AddXY(column1Value, column2Value);

            }

            reader.Close();
        }
        private void load_chartQT()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = " SELECT queQuan, COUNT(*) AS Count\r\nFROM SinhVien\r\nGROUP BY queQuan";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                int column2Value = Convert.ToInt32(reader[1]);
                

                // Đổ dữ liệu vào Series của Chart
                chartQT.Series["Số sinh viên"].Points.AddXY(column1Value, column2Value);

            }

            reader.Close();
        }
        private void load_chartNH()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = "SELECT nganhHoc, COUNT(*) AS soLuongSinhVien\r\nFROM SinhVien\r\nGROUP BY nganhHoc;";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                int column2Value = Convert.ToInt32(reader[1]);


                // Đổ dữ liệu vào Series của Chart
                chartNH.Series["Số sinh viên"].Points.AddXY(column1Value, column2Value);

            }

            reader.Close();
        }
        private void load_chartNamH()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = "SELECT namHoc, COUNT(*) AS soLuongSinhVien\r\nFROM SinhVien\r\nGROUP BY namHoc;";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                int column2Value = Convert.ToInt32(reader[1]);


                // Đổ dữ liệu vào Series của Chart
                chartNamH.Series["Số sinh viên"].Points.AddXY(column1Value, column2Value);

            }

            reader.Close();
        }
        
        private void FormThongKeSV_Load(object sender, EventArgs e)
        {
            load_chartGT();
            load_chartQT();
            load_chartNH();
            load_chartNamH();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
