using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using e_excel = Microsoft.Office.Interop.Excel;
namespace Final
{
    public partial class FormDichVu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=FAIRYMAN\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public FormDichVu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void load_grid ()
        {
            if(con.State != ConnectionState.Open) 
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * From Dichvu",con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load_grid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox3.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String p_madichvu = textBox3.Text.Trim();
            int p_kq = 0;
            checktrung(p_madichvu, ref p_kq);
            if (p_kq == 1)
            {
                textBox3.Focus();
                MessageBox.Show("Dịch vụ này bị trùng mã !");
                return;
            }
            if(p_madichvu == "")
            {
                textBox3.Focus();
                MessageBox.Show("Hãy nhập mã dịch vụ");
                return;
            }    
            String p_tendichvu = textBox1.Text.Trim();
            if(p_tendichvu == "")
            {
                textBox1.Focus();
                MessageBox.Show("Hãy nhập tên dịch vụ");
                return;
            }
            float p_gia = float.Parse(textBox2.Text.Trim());
            if (!kiemtraso(textBox2.Text.Trim()))
            {
                textBox2.Focus();
                MessageBox.Show("Hãy nhập số !!!");
                return;
            } 
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            String sql ="Insert into DichVu Values('"+p_madichvu+"', N'"+p_tendichvu+"', '"+p_gia+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            load_grid();
            MessageBox.Show("Dịch vụ đã được thêm vào");
        }
        private bool kiemtraso(string text)
        {
            float kq;
            return float.TryParse(text, out kq);
        }
        public void checktrung (String p_madichvu, ref int p_ketqua)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Checktrungmadichvu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maDV", SqlDbType.NVarChar, 50).Value = p_madichvu;
            SqlParameter kq = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            p_ketqua = (int)kq.Value;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String p_madichvu = textBox3.Text.Trim();
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            String sql = ("Delete From Dichvu Where maDV = '"+p_madichvu+"'");
            SqlCommand cmd = new SqlCommand (sql, con);
            cmd.ExecuteNonQuery ();
            cmd.Dispose ();
            con.Close();
            load_grid();
            MessageBox.Show("Dịch vụ đã được xóa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String p_tendichvu = textBox1.Text.Trim();
            float p_gia = float.Parse(textBox2.Text.Trim());
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
                SqlCommand cmd = new SqlCommand("suadichvu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenDV", SqlDbType.NVarChar,50).Value = p_tendichvu;
                cmd.Parameters.Add("@giaDV", SqlDbType.Float).Value = p_gia;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                load_grid();
                MessageBox.Show("Không được sửa mã dịch vụ và tên dịch vụ");
                MessageBox.Show("Giá dịch vụ đã được sửa");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            String p_madichvu = textBox3.Text.Trim();
            String p_tendichvu = textBox1.Text.Trim();
            float p_gia;
            if(textBox2.Text.Trim() == "")
            {
                p_gia = 0;
            }
            else
            {
                p_gia = float.Parse(textBox2.Text.Trim());
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open() ;
            }
            SqlCommand cmd = new SqlCommand("timkiemdichvu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maDV", SqlDbType.NVarChar, 50).Value = p_madichvu;
            cmd.Parameters.Add("@tenDV", SqlDbType.NVarChar, 50).Value = p_tendichvu;
            cmd.Parameters.Add("@giaDV", SqlDbType.Float).Value = p_gia;
            cmd.ExecuteNonQuery();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable ad = new DataTable();
            dt.Fill(ad);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = ad;
            dataGridView1.Refresh();
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
            cl1.Value2 = "Mã dịch vụ";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên dịch vụ";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Giá dịch vụ";
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

        private void button6_Click(object sender, EventArgs e)
        {
            String p_madichvu = textBox3.Text.Trim();
            String p_tendichvu = textBox1.Text.Trim();
            float p_gia;
            if (textBox2.Text.Trim() == "")
            {
                p_gia = 0;
            }
            else
            {
                p_gia = float.Parse(textBox2.Text.Trim());
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("timkiemdichvu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maDV", SqlDbType.NVarChar, 50).Value = p_madichvu;
            cmd.Parameters.Add("@tenDV", SqlDbType.NVarChar, 50).Value = p_tendichvu;
            cmd.Parameters.Add("@giaDV", SqlDbType.Float).Value = p_gia;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable ad = new DataTable();
            dt.Fill(ad);
            cmd.Dispose();
            con.Close();
            ExportExcel(ad, "Danh sách dịch vụ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * From Dichvu", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormChitiet fm = new FormChitiet();
            fm.Show();
        }
    }
}
