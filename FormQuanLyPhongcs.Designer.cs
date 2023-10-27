namespace QuanLyKhachSan
{
    partial class FormQuanLyPhongcs
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
            this.btnCapNhatPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textMaPhong = new System.Windows.Forms.TextBox();
            this.btnXemPhong = new System.Windows.Forms.Button();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhatPhong
            // 
            this.btnCapNhatPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhatPhong.Location = new System.Drawing.Point(805, 151);
            this.btnCapNhatPhong.Name = "btnCapNhatPhong";
            this.btnCapNhatPhong.Size = new System.Drawing.Size(85, 35);
            this.btnCapNhatPhong.TabIndex = 4;
            this.btnCapNhatPhong.Text = "Cập nhật";
            this.btnCapNhatPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatPhong.Click += new System.EventHandler(this.btnCapNhatPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaPhong.Location = new System.Drawing.Point(1160, 151);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(85, 35);
            this.btnXoaPhong.TabIndex = 5;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phòng:";
            // 
            // textMaPhong
            // 
            this.textMaPhong.Location = new System.Drawing.Point(97, 47);
            this.textMaPhong.Name = "textMaPhong";
            this.textMaPhong.Size = new System.Drawing.Size(113, 22);
            this.textMaPhong.TabIndex = 1;
            this.textMaPhong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnXemPhong
            // 
            this.btnXemPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXemPhong.Location = new System.Drawing.Point(1051, 151);
            this.btnXemPhong.Name = "btnXemPhong";
            this.btnXemPhong.Size = new System.Drawing.Size(85, 35);
            this.btnXemPhong.TabIndex = 8;
            this.btnXemPhong.Text = "xem";
            this.btnXemPhong.UseVisualStyleBackColor = true;
            this.btnXemPhong.Click += new System.EventHandler(this.btnXemPhong_Click);
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.tenPhong,
            this.trangThai,
            this.soThanhVien,
            this.soLuongTD});
            this.dataGridViewPhong.Location = new System.Drawing.Point(45, 192);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 51;
            this.dataGridViewPhong.RowTemplate.Height = 24;
            this.dataGridViewPhong.Size = new System.Drawing.Size(1200, 470);
            this.dataGridViewPhong.TabIndex = 0;
            this.dataGridViewPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhong_CellContentClick);
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            // 
            // tenPhong
            // 
            this.tenPhong.DataPropertyName = "tenPhong";
            this.tenPhong.HeaderText = "Tên";
            this.tenPhong.MinimumWidth = 6;
            this.tenPhong.Name = "tenPhong";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            // 
            // soThanhVien
            // 
            this.soThanhVien.DataPropertyName = "soThanhVien";
            this.soThanhVien.HeaderText = "Số SV";
            this.soThanhVien.MinimumWidth = 6;
            this.soThanhVien.Name = "soThanhVien";
            // 
            // soLuongTD
            // 
            this.soLuongTD.DataPropertyName = "soLuongTD";
            this.soLuongTD.HeaderText = "Số SV Tối Đa";
            this.soLuongTD.MinimumWidth = 6;
            this.soLuongTD.Name = "soLuongTD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Danh Sách Phòng";
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(930, 151);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(85, 35);
            this.btnThemPhong.TabIndex = 17;
            this.btnThemPhong.Text = "Thêm ";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.textPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnThemPhong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnXemPhong);
            this.panel1.Controls.Add(this.textMaPhong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnXoaPhong);
            this.panel1.Controls.Add(this.btnCapNhatPhong);
            this.panel1.Controls.Add(this.dataGridViewPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 592);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "Xuất Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(439, 97);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(98, 29);
            this.btnOpenFile.TabIndex = 21;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(123, 104);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(295, 22);
            this.textPath.TabIndex = 20;
            this.textPath.TextChanged += new System.EventHandler(this.textPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Đường dẫn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(688, 154);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 32);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormQuanLyPhongcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 592);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyPhongcs";
            this.Text = "FormQuanLyPhongcs";
            this.Load += new System.EventHandler(this.FormQuanLyPhongcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCapNhatPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMaPhong;
        private System.Windows.Forms.Button btnXemPhong;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTD;
        private System.Windows.Forms.Button button2;
    }
}