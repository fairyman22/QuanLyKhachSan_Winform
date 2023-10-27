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
    public partial class FormThongKeNo : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public FormThongKeNo()
        {
            InitializeComponent();
        }
        private void load_ChartTongNo()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = "SELECT SUM(tien) AS Tong_Tien,\r\nSUM(CASE WHEN trangThai = 'No' THEN tien ELSE 0 END) AS Tong_No\r\nFROM ThanhToan;";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                int column1Value = Convert.ToInt32(reader[0]);
                int column2Value = Convert.ToInt32(reader[1]);

                // Đổ dữ liệu vào Series của Chart
                chartTongNo.Series["Tiền"].Points.AddXY("Tổng tiền", column1Value);
                chartTongNo.Series["Tiền"].Points.AddXY("Nợ", column2Value);

            }

            reader.Close();
        }
        private void load_ChartNo()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            String sql = "SELECT FORMAT(ngay, 'yyyy-MM') AS thang,\r\nSUM(tien) AS TongTien,\r\nSUM(CASE WHEN trangThai = 'No' THEN tien ELSE 0 END) AS TongNo,\r\n\t   SUM(CASE WHEN trangThai = 'Thu du' THEN tien ELSE 0 END) AS DaThu\r\nFROM ThanhToan\r\nGROUP BY FORMAT(ngay, 'yyyy-MM');";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và đổ vào Chart
            while (reader.Read())
            {
                string column1Value = reader[0].ToString();
                int column2Value = Convert.ToInt32(reader[1]);
                int column3Value = Convert.ToInt32(reader[2]);
                int column4Value = Convert.ToInt32(reader[3]);

                // Đổ dữ liệu vào Series của Chart
                chartNoThang.Series["Tổng tiền"].Points.AddXY("", column2Value);
                chartNoThang.Series["Đã thu"].Points.AddXY(column1Value, column4Value);
                chartNoThang.Series["Nợ"].Points.AddXY("", column3Value);

            }

            reader.Close();
        }
        private void load_Grv()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "SELECT tt.*, sv.hoTen, sv.maSV\r\nFROM ThanhToan tt\r\nJOIN HopDong hd ON hd.id = tt.idHopDongChiTiet\r\nJOIN SinhVien sv ON sv.maSV = hd.maSinhVien\r\nWhere tt.trangThai='No';";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewBill.DataSource = dt;
            dataGridViewBill.Refresh();
        }
        private void load_GrvTK(string msv)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "SELECT tt.*, sv.hoTen, sv.maSV\r\nFROM ThanhToan tt\r\nJOIN HopDong hd ON hd.id = tt.idHopDongChiTiet\r\nJOIN SinhVien sv ON sv.maSV = hd.maSinhVien\r\nWhere tt.trangThai='No'and sv.maSV='"+msv+"';";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewBill.DataSource = dt;
            dataGridViewBill.Refresh();
        }
        private void load_cbSV()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "SELECT sv.*\r\nFROM SinhVien sv\r\nJOIN HopDong hd ON sv.maSV = hd.maSinhVien\r\nJOIN ThanhToan tt ON hd.id = tt.idHopDongChiTiet\r\nWHERE tt.trangThai = 'No';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
           

            comboBoxMaSV.DisplayMember = "maSV";
            comboBoxMaSV.ValueMember = "maSV";
            comboBoxMaSV.DataSource = dt;
            
        }

        private void FormThongKeNo_Load(object sender, EventArgs e)
        {
            load_ChartTongNo();
            load_ChartNo();
            load_Grv();
            load_cbSV();
        }

        private void comboBoxMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
                string msv = comboBoxMaSV.SelectedValue.ToString();
                load_GrvTK(msv);
            
            
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            load_Grv();
        }
    }
}
