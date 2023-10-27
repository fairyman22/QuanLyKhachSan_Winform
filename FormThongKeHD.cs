using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhachSan
{
    public partial class FormThongKeHD : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private System.Windows.Forms.DataVisualization.Charting.Series series;

        public FormThongKeHD()
        {
            InitializeComponent();
        }
        private  void load_ChartTT()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = " SELECT trangThai, COUNT(*) AS Count FROM HopDong GROUP BY trangThai";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                int column2Value = Convert.ToInt32(reader[1]);

                // Đổ dữ liệu vào Series của Chart
                chartTT.Series["Số Lượng HD"].Points.AddXY(column1Value, column2Value);

            }

            reader.Close();
        }
        private void load_ChartHDM()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = " SELECT YEAR(batDau) AS ContractYear, MONTH(batDau) AS ContractMonth, COUNT(*) AS ContractCount \r\nFROM HopDong \r\nWHERE batDau >= DATEADD(MONTH, -4, GETDATE()) \r\nGROUP BY YEAR(batDau), MONTH(batDau) \r\nORDER BY YEAR(batDau), MONTH(batDau)";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                string colum2value = reader[1].ToString();
                int column3Value = Convert.ToInt32(reader[2]);

                // Đổ dữ liệu vào Series của Chart
                chartHDM.Series["Số HD"].Points.AddXY(colum2value+"/"+column1Value, column3Value);

            }

            reader.Close();
        }
        private void load_ChartSHH()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = "SELECT YEAR(ketThuc) AS ExpirationYear, MONTH(ketThuc) AS ExpirationMonth, COUNT(*) AS ContractCount \r\n FROM HopDong\r\n WHERE ketThuc >= GETDATE() AND ketThuc <= DATEADD(MONTH, 4, GETDATE()) \r\n GROUP BY YEAR(ketThuc), MONTH(ketThuc) \r\n ORDER BY YEAR(ketThuc), MONTH(ketThuc)";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                string colum2value = reader[1].ToString();
                int column3Value = Convert.ToInt32(reader[2]);

                // Đổ dữ liệu vào Series của Chart
                chartSHH.Series["Số HD"].Points.AddXY(colum2value + "/" + column1Value, column3Value);

            }

            reader.Close();
        }
        private void FormThongKeHD_Load(object sender, EventArgs e)
        {
            load_ChartTT();
            load_ChartHDM();
            load_ChartSHH();
        }
    }
}
