using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FormThongKe : Form
    {
        private Form currentFormChild;
        public FormThongKe()
        {
            InitializeComponent();
        }
        private void openchildForm(Form child)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel1.Controls.Add(child);
            panel1.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            openchildForm(new FormThongKeSV());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildForm(new FormThongKeSV());
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            openchildForm(new FormThongKeHD());
        }

        private void btnPG_Click(object sender, EventArgs e)
        {
            openchildForm(new FormThongKePhong());
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            openchildForm(new FormThongKeNo());
        }
    }
}
