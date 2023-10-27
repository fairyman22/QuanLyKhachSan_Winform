using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_excel = Microsoft.Office.Interop.Excel;

using xls = Microsoft.Office.Interop.Excel;

namespace QuanLyKhachSan
{
    public partial class FormThanhToan : Form
    {
        String filename;
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public FormThanhToan()
        {
            InitializeComponent();
        }
        private void load_Grv(String id)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select hd.*, sv.hoTen From HopDong hd INNER JOIN SinhVien sv ON hd.maSinhVien=sv.maSV where hd.id='" + id+"'";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewHD.DataSource = dt;
            dataGridViewHD.Refresh();

        }
        private void load_GrvBill()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From ThanhToan";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewBill.DataSource = dt;
            dataGridViewBill.Refresh();
        }
        private void load_cbHopDong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From HopDong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            

            comboBoxMaHD.DisplayMember = "id";
            comboBoxMaHD.ValueMember = "id";
            comboBoxMaHD.DataSource = dt;
        }
        private void load_cbBillDV(string mp)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From hoadon_dichvu where maPhong='"+mp+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();


            comboBoxIdBillDV.DisplayMember = "ngay";
            comboBoxIdBillDV.ValueMember = "id";
            comboBoxIdBillDV.DataSource = dt;
        }

        private void load_DV(String idBillDV)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From hoadon_dichvu Where id='"+idBillDV+"'";
            //elect dp.*, dv.tenDV, dv.giaDV From dichvu_phong dp INNER JOIN DichVu dv ON dp.maDV = dv.maDV Where dp.maPhong = '"+mp+"'
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            load_GrvBill();
            load_cbHopDong();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String id = comboBoxMaHD.SelectedValue.ToString();
            load_Grv(id);
            String mp = dataGridViewHD.Rows[0].Cells[6].Value.ToString();
            
            load_DV(mp);
            float tien = 0;
            tien = tien + float.Parse(dataGridViewHD.Rows[0].Cells[8].Value.ToString());
            
            MessageBox.Show(dataGridView2.Rows[0].Cells[3].Value.ToString());
           

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                
                DataGridViewCell cell = row.Cells[3];

                if (cell.Value != null && !row.IsNewRow)
                {
                    // Lấy giá trị của ô dữ liệu
                    string cellValue = cell.Value.ToString();
                    tien = tien + float.Parse(cellValue);

                    // Sử dụng giá trị của ô dữ liệu
                    Console.WriteLine(cellValue);
                }
            }

            textTien.Text=tien.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String id = comboBoxMaHD.SelectedValue.ToString() ;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From ThanhToan Where idHopDongChiTiet='"+id+"'";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewBill.DataSource = dt;
            dataGridViewBill.Refresh();
        }
        public int checktrungBill(String id)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("ChecktrungBill", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add(param).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            int kq = (int)param.Value;
            return kq;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String id  = textID.Text.Trim();
            String idhd = comboBoxMaHD.SelectedValue.ToString();
            string idBillDV = comboBoxIdBillDV.SelectedValue.ToString();
            float tien = float.Parse(textTien.Text.Trim());
            DateTime ngay = dateTimePickerNgayThu.Value;
            String trangthai;
            if (checkBox1.Checked)
            {
                trangthai = "Thu du";
            }
            else
            {
                trangthai = "No";
            }
            String ghichu = textGhiChu.Text.Trim();
            
            if (checktrungBill(id) == 1)
            {
                MessageBox.Show("Ma bill da ton tai");
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ThemBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
                cmd.Parameters.Add("@idHopDongChiTiet", SqlDbType.NVarChar, 50).Value = idhd;
                cmd.Parameters.Add("@idBillDV", SqlDbType.Int).Value = idBillDV;
                cmd.Parameters.Add("@tien", SqlDbType.Float).Value = tien;
                cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                cmd.Parameters.Add("@mieuTa", SqlDbType.NVarChar, 50).Value = ghichu;
                cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = trangthai;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Thêm hoa don Thành công!");
                load_GrvBill();
                
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String id = textID.Text.Trim();
            String idhd = comboBoxMaHD.SelectedValue.ToString();
            string idBillDV = comboBoxIdBillDV.SelectedValue.ToString();
            float tien = float.Parse(textTien.Text.Trim());
            DateTime ngay = dateTimePickerNgayThu.Value;
            String trangthai;
            if (checkBox1.Checked)
            {
                trangthai = checkBox1.Text;
            }
            else
            {
                trangthai = "No";
            }
            String ghichu = textGhiChu.Text.Trim();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("UpdateBill", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add("@idHopDongChiTiet", SqlDbType.NVarChar, 50).Value = idhd;
            cmd.Parameters.Add("@idBillDV", SqlDbType.Int).Value = idBillDV;
            cmd.Parameters.Add("@tien", SqlDbType.Float).Value = tien;
            cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
            cmd.Parameters.Add("@mieuTa", SqlDbType.NVarChar, 50).Value = ghichu;
            cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = trangthai;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Sua hoa don Thành công!");
            load_GrvBill();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = textID.Text.Trim();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Deletebill", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Xoa hoa don Thành công!");
            load_GrvBill();
        }

       

        private void dataGridViewBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textID.Text = dataGridViewBill.Rows[i].Cells[0].Value.ToString();

            comboBoxMaHD.SelectedValue = dataGridViewBill.Rows[i].Cells[1].Value.ToString();
            comboBoxIdBillDV.SelectedValue = dataGridViewBill.Rows[i].Cells[2].Value.ToString();
            //dateTimePickerNgayThu.Text = Convert.ToDateTime(dataGridViewBill.Rows[i].Cells[3].ToString()).ToShortDateString();
            //textTien.Text = dataGridViewBill.Rows[i].Cells[4].Value.ToString();
            if (dataGridViewBill.Rows[i].Cells[5].Value.ToString().Equals("Thu du"))
            {
                checkBox1.Checked = true;
            }
            else { checkBox1.Checked = false; }
            textGhiChu.Text = dataGridViewBill.Rows[i].Cells[6].Value.ToString();
        }
        private void ThemBill(string id, string idhd, int thang, DateTime ngay , float tien, string ghichu, string trangthai)
        {
            if (checktrungBill(id) == 1)
            {
                MessageBox.Show("ID Bill da ton tai");
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("ThemBill", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add("@idHopDongChiTiet", SqlDbType.NVarChar, 50).Value = idhd;
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
            cmd.Parameters.Add("@tien", SqlDbType.Float).Value = tien;
            cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
            cmd.Parameters.Add("@mieuTa", SqlDbType.NVarChar, 50).Value = ghichu;
            cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = trangthai;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            
        }
        public void ReadExcel()
        {
            if (filename == null)
            {
                MessageBox.Show("Chưa chọn file");
            }
            else
            {
                xls.Application Excel = new xls.Application();// tạp một app làm việc mới
                // mở dữ liệu từ file
                Excel.Workbooks.Open(filename);
                //đọc dữ liệu từng sheet của excel
                foreach (xls.Worksheet wsheet in Excel.Worksheets)
                {
                    int i = 2;  //để đọc từng dòng của sheet bắt đầu từ dòng số 2
                    do
                    {
                        if (wsheet.Cells[i, 1].Value == null && wsheet.Cells[i, 2].Value == null && wsheet.Cells[i, 3].Value == null)
                        {
                            break;
                        }
                        else
                        {
                            //Đổ dòng dữ liệu vào DB
                            ThemBill(wsheet.Cells[i, 1].Value, wsheet.Cells[i, 2].Value, wsheet.Cells[i, 3].Value, wsheet.Cells[i, 4].Value, wsheet.Cells[i, 5].Value, wsheet.Cells[i, 6].Value, wsheet.Cells[i, 7].Value); i++;
                        }
                    }
                    while (true);
                }
            }

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "excel file |*.xls;*.xlsx";
            f.FilterIndex = 1; //trỏ vào vị trí đầu tiên của bộ lọc
            f.RestoreDirectory = true; // nhớ đường dẫn của lần truy cập trước
            f.Multiselect = false; //không cho phép chọn nhiều file 1 lúc
            if (f.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = f.FileName;
                filename = f.FileName;  //Biến filename khai báo biến toàn cục
                ReadExcel();

            }
        }
        public void ExportExcel(DataTable tb, string sheetname)
        {
            e_excel.Application oExcel = new e_excel.Application();
            e_excel.Workbooks oBooks;
            e_excel.Sheets oSheets;
            e_excel.Workbook oBook;
            e_excel.Worksheet oSheet;
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            e_excel.Range head = oSheet.get_Range("A1", "D1");
            head.MergeCells = true;
            head.Value2 = "Danh sách dịch vụ";
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "ID Bill";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "ID HĐ";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Thang";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngay";
            cl4.ColumnWidth = 20.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tien";
            cl5.ColumnWidth = 20.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Trang Thai";
            cl6.ColumnWidth = 20.0;
            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Ghi Chu";
            cl7.ColumnWidth = 20.0;
            e_excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            e_excel.Range range = oSheet.get_Range(c1, c2);
            range.Value2 = arr;
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
        }
        private void btnXuatEX_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From ThanhToan";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewBill.DataSource = dt;
            dataGridViewBill.Refresh();
            ExportExcel(dt, "Danh sách Bill"); 
        }

        private void comboBoxMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = comboBoxMaHD.SelectedValue.ToString();
            load_Grv(id);
            String mp = dataGridViewHD.Rows[0].Cells[6].Value.ToString();
            load_cbBillDV(mp);
            //float tien = 0;
            //tien = tien + float.Parse(dataGridViewHD.Rows[0].Cells[8].Value.ToString());




            //foreach (DataGridViewRow row in dataGridView2.Rows)
            //{

            //    DataGridViewCell cell = row.Cells[16];

            //    if (cell.Value != null && !row.IsNewRow)
            //    {
            //        // Lấy giá trị của ô dữ liệu
            //        string cellValue = cell.Value.ToString();
            //        tien = tien + float.Parse(cellValue);

            //        // Sử dụng giá trị của ô dữ liệu
            //        Console.WriteLine(cellValue);
            //    }
            //}

            //textTien.Text = tien.ToString();
        }

        private void comboBoxIdBillDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBoxIdBillDV.SelectedValue.ToString();
            load_DV(id);
            float tien = 0;
            tien = tien + float.Parse(dataGridViewHD.Rows[0].Cells[8].Value.ToString());




            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                DataGridViewCell cell = row.Cells[16];

                if (cell.Value != null && !row.IsNewRow)
                {
                    // Lấy giá trị của ô dữ liệu
                    string cellValue = cell.Value.ToString();
                    tien = tien + float.Parse(cellValue);

                    // Sử dụng giá trị của ô dữ liệu
                    Console.WriteLine(cellValue);
                }
            }

            textTien.Text = tien.ToString();
        }
    }
}
