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
namespace Final
{
    public partial class FormChitiet : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=FAIRYMAN\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");

        public FormChitiet()
        {
            InitializeComponent();
        }
        private void load_cbLoaiPhong()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "Select * From Phong ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);

            con.Close();
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);

            comboBoxMaPhong.DisplayMember = "tenPhong";
            comboBoxMaPhong.ValueMember = "maPhong";
            comboBoxMaPhong.DataSource = dt;
        }
        private void load_grid()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * From hoadon_dichvu ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
             ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void FormChitiet_Load(object sender, EventArgs e)
        {
            load_grid();
            load_cbLoaiPhong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * From hoadon_dichvu ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string p_maphong = comboBoxMaPhong.SelectedValue.ToString();
            DateTime p_ngay = dateTimePicker1.Value;
            string p_id = txtID.Text.Trim();
            int p_sodiencu = int.Parse(txtsodiencu.Text.Trim());
            int p_sodienmoi = int.Parse(txtsodienmoi.Text.Trim());
            if (p_sodiencu > p_sodienmoi)
            {
                MessageBox.Show("Nhap lai so dien");
            }
            int p_sodienphatsinh = p_sodienmoi - p_sodiencu;
            int p_sonuoccu = int.Parse(txtsonuoccu.Text.Trim());
            int p_sonuocmoi = int.Parse(txtsonuocmoi.Text.Trim());
            int p_sonuocphatsinh = p_sonuocmoi - p_sonuoccu;
            float p_dongiadien = 3500;
            float p_dongianuoc = 15000;
            float p_tiendien = (float)(p_sodienphatsinh * p_dongiadien);
            float p_tiennuoc = (float)(p_sonuocphatsinh * p_dongianuoc);
            float p_tienwifi = 400000;
            float p_tienvesinh = 500000;
            float p_tienphong = (float)(p_tiendien + p_tiennuoc + p_tienvesinh + p_tienwifi);
            float p_tiennguoi = (float)(p_tienphong / 8);
            SqlCommand cmd = new SqlCommand("tinhtien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = p_maphong;
            cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = p_ngay;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = p_id;
            cmd.Parameters.Add("@sodiencu", SqlDbType.Int).Value = p_sodiencu;
            cmd.Parameters.Add("@sodienmoi", SqlDbType.Int).Value = p_sodienmoi;
            cmd.Parameters.Add("@sodienphatsinh", SqlDbType.Int).Value = p_sodienphatsinh;
            cmd.Parameters.Add("@sonuoccu", SqlDbType.Int).Value = p_sonuoccu;
            cmd.Parameters.Add("@sonuocmoi", SqlDbType.Int).Value = p_sonuocmoi;
            cmd.Parameters.Add("@sonuocphatsinh", SqlDbType.Int).Value = p_sonuocphatsinh;
            cmd.Parameters.Add("@dongiadien", SqlDbType.Float).Value = p_dongiadien;
            cmd.Parameters.Add("@dongianuoc", SqlDbType.Float).Value = p_dongianuoc;
            cmd.Parameters.Add("@tiendien", SqlDbType.Float).Value = p_tiendien;
            cmd.Parameters.Add("@tiennuoc", SqlDbType.Float).Value = p_tiennuoc;
            cmd.Parameters.Add("@tienwifi", SqlDbType.Float).Value = p_tienwifi;
            cmd.Parameters.Add("@tienvesinh", SqlDbType.Float).Value = p_tienvesinh;
            cmd.Parameters.Add("@tienphong", SqlDbType.Float).Value = p_tienphong;
            cmd.Parameters.Add("@tiennguoi", SqlDbType.Float).Value = p_tiennguoi;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            load_grid();
            MessageBox.Show("Hệ thống đã cập nhật");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            int p_maphong = int.Parse(txttimkiem.Text.Trim());
            SqlCommand cmd = new SqlCommand("timmaphong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maPhong", SqlDbType.Int).Value = p_maphong;
            cmd.ExecuteNonQuery();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable ad = new DataTable();
            dt.Fill(ad);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = ad;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBoxMaPhong.SelectedValue = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //dateTimePicker1.Value = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtID.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtsodiencu.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtsodienmoi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtsonuoccu.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtsonuocmoi.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
