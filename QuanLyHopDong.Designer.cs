namespace QuanLyKhachSan
{
    partial class QuanLyHopDong
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
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mieuTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIDHopDong = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maSinhVien,
            this.batDau,
            this.ketThuc,
            this.trangThai,
            this.mieuTa,
            this.maPhong,
            this.maGiuong,
            this.gia});
            this.dataGridViewHD.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHD.Location = new System.Drawing.Point(38, 189);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.RowHeadersWidth = 51;
            this.dataGridViewHD.RowTemplate.Height = 24;
            this.dataGridViewHD.Size = new System.Drawing.Size(971, 352);
            this.dataGridViewHD.TabIndex = 0;
            this.dataGridViewHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellClick);
            this.dataGridViewHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // maSinhVien
            // 
            this.maSinhVien.DataPropertyName = "maSinhVien";
            this.maSinhVien.HeaderText = "MSV";
            this.maSinhVien.MinimumWidth = 6;
            this.maSinhVien.Name = "maSinhVien";
            // 
            // batDau
            // 
            this.batDau.DataPropertyName = "batDau";
            this.batDau.HeaderText = "Ngày Bắt Đầu";
            this.batDau.MinimumWidth = 6;
            this.batDau.Name = "batDau";
            // 
            // ketThuc
            // 
            this.ketThuc.DataPropertyName = "ketThuc";
            this.ketThuc.HeaderText = "Ngày Kết Thúc";
            this.ketThuc.MinimumWidth = 6;
            this.ketThuc.Name = "ketThuc";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            // 
            // mieuTa
            // 
            this.mieuTa.DataPropertyName = "mieuTa";
            this.mieuTa.HeaderText = "Chi Tiết";
            this.mieuTa.MinimumWidth = 6;
            this.mieuTa.Name = "mieuTa";
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Mã Phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            // 
            // maGiuong
            // 
            this.maGiuong.DataPropertyName = "maGiuong";
            this.maGiuong.HeaderText = "Mã Giường";
            this.maGiuong.MinimumWidth = 6;
            this.maGiuong.Name = "maGiuong";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản Lý Hợp Đồng";
            // 
            // textIDHopDong
            // 
            this.textIDHopDong.Location = new System.Drawing.Point(160, 81);
            this.textIDHopDong.Name = "textIDHopDong";
            this.textIDHopDong.Size = new System.Drawing.Size(100, 22);
            this.textIDHopDong.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(290, 80);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(694, 84);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(807, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(906, 84);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(290, 126);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(79, 28);
            this.btnOpenFile.TabIndex = 27;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(160, 132);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(121, 22);
            this.textPath.TabIndex = 26;
            this.textPath.TextChanged += new System.EventHandler(this.textPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Đường dẫn:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Gia hạn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 28);
            this.button2.TabIndex = 29;
            this.button2.Text = "Xuất Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRf
            // 
            this.btnRf.Location = new System.Drawing.Point(396, 163);
            this.btnRf.Name = "btnRf";
            this.btnRf.Size = new System.Drawing.Size(75, 23);
            this.btnRf.TabIndex = 30;
            this.btnRf.Text = "Refresh";
            this.btnRf.UseVisualStyleBackColor = true;
            this.btnRf.Click += new System.EventHandler(this.btnRf_Click);
            // 
            // QuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 553);
            this.Controls.Add(this.btnRf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.textIDHopDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHD);
            this.Name = "QuanLyHopDong";
            this.Text = "QuanLyHopDong";
            this.Load += new System.EventHandler(this.QuanLyHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIDHopDong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn batDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mieuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRf;
    }
}