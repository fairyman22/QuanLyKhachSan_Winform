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
    public partial class FormGiaHanHD : Form
    {
        private string id;
        SqlConnection conn = new SqlConnection("Data Source=FAIRYMAN\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        public void setID(string id)
        {
            this.id = id;
        }
        public FormGiaHanHD()
        {
            InitializeComponent();
        }

        private void FormGiaHanHD_Load(object sender, EventArgs e)
        {

            labeID.Text = id;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = " SELECT * FROM HopDong Where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            using (SqlDataReader rd = cmd.ExecuteReader())

            {

                if (rd.Read())
                {
                    dateTimePickerBD.Text = rd["batDau"].ToString();
                    dateTimePickerKT.Text = rd["ketThuc"].ToString();
                    labelMP.Text = rd["maPhong"].ToString();
                    labeMG.Text = rd["maGiuong"].ToString();
                    labelGia.Text = rd["gia"].ToString();
                    labelTT.Text = rd["trangThai"].ToString();
                    labelGC.Text = rd["mieuTa"].ToString();
                    rd.Close();

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime bd = dateTimePickerBD.Value;
            DateTime kt = dateTimePickerKT.Value;
            string mp = labelMP.Text;
            string mg = labeMG.Text;
            string tt = labelTT.Text;
            string ghichu = labelGC.Text;
            int gia = int.Parse(labelGia.Text);
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
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Gia hạn thành công!");
        }

        private void labelTT_Click(object sender, EventArgs e)
        {

        }

        private void labelGia_Click(object sender, EventArgs e)
        {

        }

        private void labeMG_Click(object sender, EventArgs e)
        {

        }

        private void labelMP_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labeID_Click(object sender, EventArgs e)
        {

        }

        private void labelGC_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerKT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
