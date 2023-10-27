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
using System.Windows.Forms;
using xls = Microsoft.Office.Interop.Excel;
using e_excel = Microsoft.Office.Interop.Excel;




namespace QuanLyKhachSan
{
    public partial class QuanLyHopDong : Form
    {
        String idhd;
        String filename;
        string msv;
        string mp_cu;
        string mg_cu;
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public QuanLyHopDong()
        {
            InitializeComponent();
        }
        private void load_Grv()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From HopDong";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewHD.DataSource = dt;
            dataGridViewHD.Refresh();
        }

        private void QuanLyHopDong_Load(object sender, EventArgs e)
        {
            load_Grv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHopDong form= new ThemHopDong();
            form.ShowDialog();
        }

        private void dataGridViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String id = dataGridViewHD.SelectedCells[0].Value.ToString();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("DeleteHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            load_Grv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String id = textIDHopDong.Text.Trim();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From HopDong Where id='"+id+"'";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewHD.DataSource = dt;
            dataGridViewHD.Refresh();
        }
        private int checMHD(String mhd)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("CheckTrungMaHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = mhd;
            cmd.Parameters.Add(param).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            int kq = (int)param.Value;
            return kq;
        }
        private void ThemHopDong(string mhd, string msv,DateTime bd, DateTime kt, string tt, string mt, string mp, string mg)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("ThemHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = mhd;
            cmd.Parameters.Add("@maSV", SqlDbType.NVarChar, 50).Value = msv;
            cmd.Parameters.Add("@batDau", SqlDbType.Date).Value = bd;
            cmd.Parameters.Add("@ketThuc", SqlDbType.Date).Value = kt;
            cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = tt;
            cmd.Parameters.Add("@mieuTa", SqlDbType.NVarChar, 50).Value = mt;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
            cmd.Parameters.Add("@maGiuong", SqlDbType.NVarChar, 50).Value = mg;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Thêm Hop Dong Thành công!");
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
                            ThemHopDong(wsheet.Cells[i, 1].Value, wsheet.Cells[i, 2].Value, wsheet.Cells[i, 3].Value, wsheet.Cells[i, 4].Value, wsheet.Cells[i, 5].Value, wsheet.Cells[i, 6].Value, wsheet.Cells[i, 7].Value, wsheet.Cells[i, 8].Value); i++;
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

        private void textPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaHD formSuaHD = new FormSuaHD();
            formSuaHD.setValues(idhd,msv,mp_cu,mg_cu);
            formSuaHD.ShowDialog();
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            this.idhd = dataGridViewHD.Rows[i].Cells[0].Value.ToString();
            this.msv = dataGridViewHD.Rows[i].Cells[1].Value.ToString();
            this.mp_cu = dataGridViewHD.Rows[i].Cells[6].Value.ToString();
            this.mg_cu = dataGridViewHD.Rows[i].Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGiaHanHD form = new FormGiaHanHD();
            form.setID(idhd);
            form.ShowDialog();
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
            head.Value2 = "Danh sách hợp đồng";
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "ID";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "MSV";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày bắt đầu";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày kết thúc";
            cl4.ColumnWidth = 20.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Trạng thái";
            cl5.ColumnWidth = 20.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Chi tiết";
            cl6.ColumnWidth = 20.0;
            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Mã phòng";
            cl7.ColumnWidth = 20.0;
            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Mã giường";
            cl8.ColumnWidth = 20.0;
            e_excel.Range cl9 = oSheet.get_Range("J3", "J3");
            cl9.Value2 = "Giá thuê";
            cl9.ColumnWidth = 20.0;
            e_excel.Range rowHead = oSheet.get_Range("A3", "J3");
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From HopDong";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewHD.DataSource = dt;
            dataGridViewHD.Refresh();
            ExportExcel(dt, "Danh sách Hợp Đồng");
        }

        private void btnRf_Click(object sender, EventArgs e)
        {
            load_Grv();
        }
    }
}
