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
    public partial class LoaiPhong : Form
    {
        String filename;
        private String maLPCu;
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public LoaiPhong()
        {
            InitializeComponent();
        }
        private void load_cbLoaiPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From Phong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);

            comboBoxPhong.DisplayMember = "tenPhong";
            comboBoxPhong.ValueMember = "maPhong";
            comboBoxPhong.DataSource = dt;
        }
        private void load_GrvGiuong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From Giuong";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewLoaiPhong.DataSource = dt;
            dataGridViewLoaiPhong.Refresh();
        }

        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            load_GrvGiuong();
            load_cbLoaiPhong();
        }
        private int checkTrungmaG(String id)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("CheckTrungMaGiuong ", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add("id", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add(param).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            int kq = (int)param.Value;
            return kq;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String id = textID.Text.Trim();
            String mp = comboBoxPhong.SelectedValue.ToString();

            String tt = textTT.Text.Trim();
            if (checkTrungmaG(id) == 1)
            {
                MessageBox.Show("Ma giuong da ton tai");
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ThemGiuong", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;

                cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar).Value = mp;
                cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = tt;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Thêm Thành công!");
                load_GrvGiuong();
            }



        }


        private void dataGridViewLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            maLPCu = dataGridViewLoaiPhong.Rows[i].Cells[0].Value.ToString();
            textID.Text = dataGridViewLoaiPhong.Rows[i].Cells[0].Value.ToString();
            comboBoxPhong.SelectedValue = dataGridViewLoaiPhong.Rows[i].Cells[1].Value.ToString();
            textTT.Text = dataGridViewLoaiPhong.Rows[i].Cells[2].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String id = textID.Text.Trim();
            String mp = comboBoxPhong.SelectedValue.ToString();

            String tt = textTT.Text.Trim();


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("UpdateGiuong", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
            cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar,50).Value = tt;


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Sửa Thành công!");
            load_GrvGiuong();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ThemG(string id, string mp, string tt)
        {

            if (checkTrungmaG(mp) == 1)
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

                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
                cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
                cmd.Parameters.Add("@trangThai", SqlDbType.Float).Value = tt;

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
                            ThemG(wsheet.Cells[i, 1].Value, wsheet.Cells[i, 2].Value, wsheet.Cells[i, 3].Value); i++;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_GrvGiuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = textID.Text.Trim();
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("DeleteGiuong", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Xóa Thành công!");
            load_GrvGiuong();
        }

        private void dataGridViewLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textID.Text = dataGridViewLoaiPhong.Rows[i].Cells[0].Value.ToString();
            comboBoxPhong.SelectedValue = dataGridViewLoaiPhong.Rows[i].Cells[1].Value.ToString();
            textTT.Text = dataGridViewLoaiPhong.Rows[i].Cells[2].Value.ToString();
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
            e_excel.Range head = oSheet.get_Range("A1", "C1");
            head.MergeCells = true;
            head.Value2 = "Danh sách Giuong";
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "ID";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã Phòng";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Trạng Thái";
            cl3.ColumnWidth = 20.0;
            
            e_excel.Range rowHead = oSheet.get_Range("A3", "C3");
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
            String sql = "Select * From Giuong";
            SqlCommand cmd = new SqlCommand(@sql, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            conn.Close();
            dataGridViewLoaiPhong.DataSource = dt;
            dataGridViewLoaiPhong.Refresh();
            ExportExcel(dt, "Danh sách Giuong");
        }
    }
}
