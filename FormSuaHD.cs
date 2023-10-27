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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan
{
    public partial class FormSuaHD : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        private string id;
        private string msv;
        private string mp_cu;
        private string mg_cu;
        public void setValues(string id, string msv, string mp_cu, string mg_cu)
        {
            this.id = id;
            this.msv = msv;
            this.mp_cu = mp_cu;
            this.mg_cu = mg_cu;
        }
        
        public FormSuaHD()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime bd = dateTimePickerBD.Value;
            DateTime kt = dateTimePickerKT.Value;
            string mp = comboBoxMaPhong.SelectedValue.ToString();
            string mg = comboBoxmaGiuong.SelectedValue.ToString();
            string tt = comboBoxTrangThai.SelectedItem.ToString();
            string ghichu = textBoxGhiChu.Text.Trim();
            int gia = int.Parse(textGia.Text.Trim());
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("UpdateHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add("@batDau", SqlDbType.Date).Value = bd;
            cmd.Parameters.Add("@ketThuc", SqlDbType.Date).Value = kt;
            cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 50).Value = tt;
            cmd.Parameters.Add("@mieuTa", SqlDbType.NVarChar, 50).Value = ghichu;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = mp;
            cmd.Parameters.Add("@maGiuong", SqlDbType.NVarChar, 50).Value = mg;
            cmd.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            cmd.Parameters.Add("@mgCu", SqlDbType.NVarChar, 50).Value = mg_cu;
            cmd.Parameters.Add("@mpCu", SqlDbType.NVarChar, 50).Value = mp_cu;
            cmd.Parameters.Add("@msv", SqlDbType.NVarChar, 50).Value = msv;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Sửa Hop Dong Thành công!");
        }
        private void load_cbLoaiPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From Phong Where trangThai='Still'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();

            comboBoxMaPhong.DisplayMember = "tenPhong";
            comboBoxMaPhong.ValueMember = "maPhong";
            comboBoxMaPhong.DataSource = dt;
        }
        private void load_cbGiuong(String mp)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * From Giuong Where maPhong='" + mp + "'" + "and trangThai='Still'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);

            comboBoxmaGiuong.DisplayMember = "id";
            comboBoxmaGiuong.ValueMember = "id";
            comboBoxmaGiuong.DataSource = dt;

        }
        private void comboBoxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            String mp = comboBoxMaPhong.SelectedValue.ToString();
            load_cbGiuong(mp);
        }
        private void FormSuaHD_Load(object sender, EventArgs e)
        {
            
            labeID.Text = id;
            //load_cbLoaiPhong();
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = " SELECT * FROM HopDong Where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            string mp="";
            string mg = "";
            using (SqlDataReader rd = cmd.ExecuteReader())
                
            {

                if (rd.Read())
                {
                    dateTimePickerBD.Text = rd["batDau"].ToString();
                    dateTimePickerKT.Text = rd["ketThuc"].ToString();
                    comboBoxMaPhong.SelectedValue = rd["maPhong"].ToString();
                    comboBoxmaGiuong.SelectedValue= rd["maGiuong"].ToString();
                    textGia.Text = rd["gia"].ToString();
                    comboBoxTrangThai.SelectedText = rd["trangThai"].ToString();
                    textBoxGhiChu.Text = rd["mieuTa"].ToString();
                    rd.Close();

                }
            }
            load_cbLoaiPhong();




        }

        
    }
}
