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
    public partial class FormThongKePhong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private System.Windows.Forms.DataVisualization.Charting.Series series;
        public FormThongKePhong()
        {
            InitializeComponent();
        }
        private void load_ChartTTPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = "SELECT trangThai, COUNT(*) AS RoomCount \r\nFROM Phong\r\nGROUP BY trangThai";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                int column2Value = Convert.ToInt32(reader[1]);

                // Đổ dữ liệu vào Series của Chart
                chartTTPhong.Series["Số Phong"].Points.AddXY( column1Value, column2Value);

            }

            reader.Close();
        }
        private void load_ChartTTGiuong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = "SELECT trangThai, COUNT(*) AS RoomCount \r\nFROM Giuong\r\nGROUP BY trangThai";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                int column2Value = Convert.ToInt32(reader[1]);

                // Đổ dữ liệu vào Series của Chart
                chartGiuong.Series["Số giường"].Points.AddXY(column1Value, column2Value);

            }

            reader.Close();
        }
        private void FormThongKePhong_Load(object sender, EventArgs e)
        {
            load_ChartTTPhong();
            load_ChartTTGiuong();
        }
    }
}
