namespace Quanly_Sinhvien
{
    partial class DanhSach_SinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.grvSinhvien = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganhHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo mã sinh viên:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Snow;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(379, 79);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(91, 27);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.BackColor = System.Drawing.Color.Snow;
            this.txtNhap.Location = new System.Drawing.Point(64, 79);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(270, 25);
            this.txtNhap.TabIndex = 3;
            // 
            // grvSinhvien
            // 
            this.grvSinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grvSinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvSinhvien.BackgroundColor = System.Drawing.Color.Snow;
            this.grvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.lop,
            this.hoTen,
            this.namsinh,
            this.queQuan,
            this.sdt,
            this.gioiTinh,
            this.maPhong,
            this.cccd,
            this.nganhHoc,
            this.namHoc,
            this.ngay});
            this.grvSinhvien.Location = new System.Drawing.Point(52, 154);
            this.grvSinhvien.Name = "grvSinhvien";
            this.grvSinhvien.RowHeadersWidth = 40;
            this.grvSinhvien.RowTemplate.Height = 28;
            this.grvSinhvien.Size = new System.Drawing.Size(1115, 340);
            this.grvSinhvien.TabIndex = 4;
            this.grvSinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvSinhvien_CellClick);
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.FillWeight = 80F;
            this.maSV.HeaderText = "Mã sinh viên";
            this.maSV.MinimumWidth = 7;
            this.maSV.Name = "maSV";
            // 
            // lop
            // 
            this.lop.DataPropertyName = "lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 8;
            this.lop.Name = "lop";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.MinimumWidth = 8;
            this.hoTen.Name = "hoTen";
            // 
            // namsinh
            // 
            this.namsinh.DataPropertyName = "namsinh";
            this.namsinh.HeaderText = "Năm sinh ";
            this.namsinh.MinimumWidth = 8;
            this.namsinh.Name = "namsinh";
            // 
            // queQuan
            // 
            this.queQuan.DataPropertyName = "queQuan";
            this.queQuan.HeaderText = "Quê quán";
            this.queQuan.MinimumWidth = 8;
            this.queQuan.Name = "queQuan";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 8;
            this.gioiTinh.Name = "gioiTinh";
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Mã Phòng";
            this.maPhong.MinimumWidth = 8;
            this.maPhong.Name = "maPhong";
            // 
            // cccd
            // 
            this.cccd.DataPropertyName = "cccd";
            this.cccd.HeaderText = "CCCD";
            this.cccd.MinimumWidth = 8;
            this.cccd.Name = "cccd";
            // 
            // nganhHoc
            // 
            this.nganhHoc.DataPropertyName = "nganhHoc";
            this.nganhHoc.HeaderText = "Ngành học";
            this.nganhHoc.MinimumWidth = 8;
            this.nganhHoc.Name = "nganhHoc";
            // 
            // namHoc
            // 
            this.namHoc.DataPropertyName = "namHoc";
            this.namHoc.HeaderText = "Năm học";
            this.namHoc.MinimumWidth = 8;
            this.namHoc.Name = "namHoc";
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.MinimumWidth = 8;
            this.ngay.Name = "ngay";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(999, 79);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(58, 35);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(860, 79);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 35);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(722, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1112, 79);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 35);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DanhSach_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1504, 625);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grvSinhvien);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DanhSach_SinhVien";
            this.Text = "DanhSach_SinhVien";
            this.Load += new System.EventHandler(this.DanhSach_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.DataGridView grvSinhvien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganhHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
    }
}