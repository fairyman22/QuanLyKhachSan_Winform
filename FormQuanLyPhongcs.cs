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
using xls = Microsoft.Office.Interop.Excel;
using e_excel = Microsoft.Office.Interop.Excel;
namespace QuanLyKhachSan
{
    public partial class FormQuanLyPhongcs : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        String filename;
        public FormQuanLyPhongcs()
        {
            InitializeComponent();
        }
        private void btnOpenChildForm_Click(object sender, EventArgs e)
        {
            FormUpdatePhong childForm = new FormUpdatePhong();
            childForm.Show();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String mp = textMaPhong.Text.Trim();
            String sql = "Select * from Phong Where maPhong=@mp";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("@mp", mp);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dataGridViewPhong.DataSource = dt;
            dataGridViewPhong.Refresh();


        }

        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            FormUpdatePhong childForm = new FormUpdatePhong();
            childForm.setMP(dataGridViewPhong.SelectedCells[0].Value.ToString());
            childForm.Show();
            
        }
        private void load_GrvPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From Phong";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);  
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewPhong.DataSource = dt;
            dataGridViewPhong.Refresh();
            

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormQuanLyPhongcs_Load(object sender, EventArgs e)
        {
            load_GrvPhong();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {

            String mp = dataGridViewPhong.SelectedCells[0].Value.ToString();
            MessageBox.Show(mp);
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("DeletePhong", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value=mp;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            load_GrvPhong();
           
        }

        private void btnXemPhong_Click(object sender, EventArgs e)
        {
            FormXemPhong formXemPhong = new FormXemPhong();
            formXemPhong.setMP(dataGridViewPhong.SelectedCells[0].Value.ToString());
            formXemPhong.setsoTD(dataGridViewPhong.SelectedCells[4].Value.ToString());
            formXemPhong.setSoTVn(dataGridViewPhong.SelectedCells[3].Value.ToString());
            formXemPhong.setTrangThai(dataGridViewPhong.SelectedCells[1].Value.ToString());
  
            formXemPhong.Show();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            FormThemPhong form= new FormThemPhong();
            form.Show();
        }

        private void dataGridViewPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_GrvPhong();
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
        private void ThemPhong(string mp, string ten, string tt, float stv,float td)
        {

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
                            ThemPhong(wsheet.Cells[i, 1].Value, wsheet.Cells[i, 2].Value, wsheet.Cells[i, 3].Value, wsheet.Cells[i, 4].Value,
                                wsheet.Cells[i, 5].Value); i++;
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

        private void label2_Click(object sender, EventArgs e)
        {

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
            head.Value2 = "Danh sách Phong";
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "ID";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Phòng";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Trạng Thái";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số SV Hiện Tại";
            cl4.ColumnWidth = 20.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số SV Tối Đa";
            cl5.ColumnWidth = 20.0;
            e_excel.Range rowHead = oSheet.get_Range("A3", "E3");
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
            String sql = "Select * From Phong";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewPhong.DataSource = dt;
            dataGridViewPhong.Refresh();
            ExportExcel(dt, "Danh sách Phòng");
        }
    }
}
