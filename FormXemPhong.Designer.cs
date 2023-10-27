namespace QuanLyKhachSan
{
    partial class FormXemPhong
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
            this.dataGridViewSVien = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.labelSVTD = new System.Windows.Forms.Label();
            this.labelSVHT = new System.Windows.Forms.Label();
            this.labeltinhTrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSVien
            // 
            this.dataGridViewSVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.hoTen,
            this.namSinh,
            this.queQuan,
            this.sdt,
            this.gioiTinh,
            this.maPhong,
            this.cccd});
            this.dataGridViewSVien.Location = new System.Drawing.Point(0, 220);
            this.dataGridViewSVien.Name = "dataGridViewSVien";
            this.dataGridViewSVien.RowHeadersWidth = 51;
            this.dataGridViewSVien.RowTemplate.Height = 24;
            this.dataGridViewSVien.Size = new System.Drawing.Size(1098, 346);
            this.dataGridViewSVien.TabIndex = 0;
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.HeaderText = "Mã SV";
            this.maSV.MinimumWidth = 6;
            this.maSV.Name = "maSV";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ Tên";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
            // 
            // namSinh
            // 
            this.namSinh.DataPropertyName = "namSinh";
            this.namSinh.HeaderText = "Năm Sinh";
            this.namSinh.MinimumWidth = 6;
            this.namSinh.Name = "namSinh";
            // 
            // queQuan
            // 
            this.queQuan.DataPropertyName = "queQuan";
            this.queQuan.HeaderText = "Quê Quán";
            this.queQuan.MinimumWidth = 6;
            this.queQuan.Name = "queQuan";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SDT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Mã Phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            // 
            // cccd
            // 
            this.cccd.DataPropertyName = "cccd";
            this.cccd.HeaderText = "CCCD";
            this.cccd.MinimumWidth = 6;
            this.cccd.Name = "cccd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tình trạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Lượng Sinh Viên Hiện Tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng Sinh Viện Tối Đa";
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhong.Location = new System.Drawing.Point(533, 9);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(98, 32);
            this.labelTenPhong.TabIndex = 24;
            this.labelTenPhong.Text = "label3";
            // 
            // labelSVTD
            // 
            this.labelSVTD.AutoSize = true;
            this.labelSVTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSVTD.Location = new System.Drawing.Point(326, 143);
            this.labelSVTD.Name = "labelSVTD";
            this.labelSVTD.Size = new System.Drawing.Size(134, 20);
            this.labelSVTD.TabIndex = 27;
            this.labelSVTD.Text = "Số nước sử dụng";
            // 
            // labelSVHT
            // 
            this.labelSVHT.AutoSize = true;
            this.labelSVHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSVHT.Location = new System.Drawing.Point(326, 105);
            this.labelSVHT.Name = "labelSVHT";
            this.labelSVHT.Size = new System.Drawing.Size(134, 20);
            this.labelSVHT.TabIndex = 26;
            this.labelSVHT.Text = "Số điện sử dụng:";
            // 
            // labeltinhTrang
            // 
            this.labeltinhTrang.AutoSize = true;
            this.labeltinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltinhTrang.Location = new System.Drawing.Point(326, 67);
            this.labeltinhTrang.Name = "labeltinhTrang";
            this.labeltinhTrang.Size = new System.Drawing.Size(89, 20);
            this.labeltinhTrang.TabIndex = 25;
            this.labeltinhTrang.Text = "Tình trạng:";
            // 
            // FormXemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 596);
            this.Controls.Add(this.labelSVTD);
            this.Controls.Add(this.labelSVHT);
            this.Controls.Add(this.labeltinhTrang);
            this.Controls.Add(this.labelTenPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSVien);
            this.Name = "FormXemPhong";
            this.Text = "FormXemPhong";
            this.Load += new System.EventHandler(this.FormXemPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.Label labelSVTD;
        private System.Windows.Forms.Label labelSVHT;
        private System.Windows.Forms.Label labeltinhTrang;
    }
}