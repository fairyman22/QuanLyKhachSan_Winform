namespace QuanLyKhachSan
{
    partial class FormThanhToan
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
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textGhiChu = new System.Windows.Forms.TextBox();
            this.textTien = new System.Windows.Forms.TextBox();
            this.comboBoxMaHD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayThu = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mieuTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXuatEX = new System.Windows.Forms.Button();
            this.comboBoxIdBillDV = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodiencu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienmoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienphatsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonuoccu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonuocmoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonuocphatsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiadien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongianuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiendien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiennuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienwifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienvesinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiennguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBillDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBill,
            this.idHD,
            this.idBillDV,
            this.ngay,
            this.tien,
            this.trangThaiBill,
            this.moTa});
            this.dataGridViewBill.Location = new System.Drawing.Point(2, 384);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowTemplate.Height = 24;
            this.dataGridViewBill.Size = new System.Drawing.Size(1327, 241);
            this.dataGridViewBill.TabIndex = 0;
            this.dataGridViewBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã HD";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(131, 18);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(121, 22);
            this.textID.TabIndex = 6;
            // 
            // textGhiChu
            // 
            this.textGhiChu.Location = new System.Drawing.Point(131, 182);
            this.textGhiChu.Multiline = true;
            this.textGhiChu.Name = "textGhiChu";
            this.textGhiChu.Size = new System.Drawing.Size(240, 102);
            this.textGhiChu.TabIndex = 7;
            // 
            // textTien
            // 
            this.textTien.Location = new System.Drawing.Point(131, 143);
            this.textTien.Name = "textTien";
            this.textTien.Size = new System.Drawing.Size(121, 22);
            this.textTien.TabIndex = 8;
            // 
            // comboBoxMaHD
            // 
            this.comboBoxMaHD.FormattingEnabled = true;
            this.comboBoxMaHD.Location = new System.Drawing.Point(131, 58);
            this.comboBoxMaHD.Name = "comboBoxMaHD";
            this.comboBoxMaHD.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaHD.TabIndex = 10;
            this.comboBoxMaHD.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaHD_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày Thu";
            // 
            // dateTimePickerNgayThu
            // 
            this.dateTimePickerNgayThu.Location = new System.Drawing.Point(354, 103);
            this.dateTimePickerNgayThu.Name = "dateTimePickerNgayThu";
            this.dateTimePickerNgayThu.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNgayThu.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(601, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chi tiết hợp đồng";
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maSinhVien,
            this.hoTen,
            this.batDau,
            this.ketThuc,
            this.trangThai,
            this.mieuTa,
            this.maPhong,
            this.maGiuong,
            this.gia});
            this.dataGridViewHD.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHD.Location = new System.Drawing.Point(604, 46);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.RowHeadersWidth = 51;
            this.dataGridViewHD.RowTemplate.Height = 24;
            this.dataGridViewHD.Size = new System.Drawing.Size(726, 110);
            this.dataGridViewHD.TabIndex = 14;
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
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Tên";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
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
            this.gia.HeaderText = "Giá Phòng";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dịch Vụ Phòng";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(301, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 20);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Thu đủ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(278, 61);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 23);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(210, 324);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(79, 28);
            this.btnOpenFile.TabIndex = 30;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(83, 327);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(121, 22);
            this.textPath.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Đường dẫn:";
            // 
            // btnXuatEX
            // 
            this.btnXuatEX.Location = new System.Drawing.Point(206, 358);
            this.btnXuatEX.Name = "btnXuatEX";
            this.btnXuatEX.Size = new System.Drawing.Size(83, 23);
            this.btnXuatEX.TabIndex = 31;
            this.btnXuatEX.Text = "Xuất Excel";
            this.btnXuatEX.UseVisualStyleBackColor = true;
            this.btnXuatEX.Click += new System.EventHandler(this.btnXuatEX_Click);
            // 
            // comboBoxIdBillDV
            // 
            this.comboBoxIdBillDV.FormattingEnabled = true;
            this.comboBoxIdBillDV.Location = new System.Drawing.Point(131, 102);
            this.comboBoxIdBillDV.Name = "comboBoxIdBillDV";
            this.comboBoxIdBillDV.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdBillDV.TabIndex = 32;
            this.comboBoxIdBillDV.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdBillDV_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.sodiencu,
            this.sodienmoi,
            this.sodienphatsinh,
            this.sonuoccu,
            this.sonuocmoi,
            this.sonuocphatsinh,
            this.dongiadien,
            this.dongianuoc,
            this.tiendien,
            this.tiennuoc,
            this.tienwifi,
            this.tienvesinh,
            this.tienphong,
            this.tiennguoi});
            this.dataGridView2.Location = new System.Drawing.Point(604, 182);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(725, 160);
            this.dataGridView2.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maPhong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Phòng ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ngay";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // sodiencu
            // 
            this.sodiencu.DataPropertyName = "sodiencu";
            this.sodiencu.HeaderText = "Số điện cũ ";
            this.sodiencu.MinimumWidth = 6;
            this.sodiencu.Name = "sodiencu";
            // 
            // sodienmoi
            // 
            this.sodienmoi.DataPropertyName = "sodienmoi";
            this.sodienmoi.HeaderText = "Số điện mới";
            this.sodienmoi.MinimumWidth = 6;
            this.sodienmoi.Name = "sodienmoi";
            // 
            // sodienphatsinh
            // 
            this.sodienphatsinh.DataPropertyName = "sodienphatsinh";
            this.sodienphatsinh.HeaderText = "Số điện phát sinh";
            this.sodienphatsinh.MinimumWidth = 6;
            this.sodienphatsinh.Name = "sodienphatsinh";
            // 
            // sonuoccu
            // 
            this.sonuoccu.DataPropertyName = "sonuoccu";
            this.sonuoccu.HeaderText = "Số nước cũ ";
            this.sonuoccu.MinimumWidth = 6;
            this.sonuoccu.Name = "sonuoccu";
            // 
            // sonuocmoi
            // 
            this.sonuocmoi.DataPropertyName = "sonuocmoi";
            this.sonuocmoi.HeaderText = "Số nước mới";
            this.sonuocmoi.MinimumWidth = 6;
            this.sonuocmoi.Name = "sonuocmoi";
            // 
            // sonuocphatsinh
            // 
            this.sonuocphatsinh.DataPropertyName = "sonuocphatsinh";
            this.sonuocphatsinh.HeaderText = "Số nước phát sinh";
            this.sonuocphatsinh.MinimumWidth = 6;
            this.sonuocphatsinh.Name = "sonuocphatsinh";
            // 
            // dongiadien
            // 
            this.dongiadien.DataPropertyName = "dongiadien";
            this.dongiadien.HeaderText = "Đơn giá điện ";
            this.dongiadien.MinimumWidth = 6;
            this.dongiadien.Name = "dongiadien";
            // 
            // dongianuoc
            // 
            this.dongianuoc.DataPropertyName = "dongianuoc";
            this.dongianuoc.HeaderText = "Đơn giá nước ";
            this.dongianuoc.MinimumWidth = 6;
            this.dongianuoc.Name = "dongianuoc";
            // 
            // tiendien
            // 
            this.tiendien.DataPropertyName = "tiendien";
            this.tiendien.HeaderText = "Tiền điện";
            this.tiendien.MinimumWidth = 6;
            this.tiendien.Name = "tiendien";
            // 
            // tiennuoc
            // 
            this.tiennuoc.DataPropertyName = "tiennuoc";
            this.tiennuoc.HeaderText = "Tiền nước";
            this.tiennuoc.MinimumWidth = 6;
            this.tiennuoc.Name = "tiennuoc";
            // 
            // tienwifi
            // 
            this.tienwifi.DataPropertyName = "tienwifi";
            this.tienwifi.HeaderText = "Tiền Wifi";
            this.tienwifi.MinimumWidth = 6;
            this.tienwifi.Name = "tienwifi";
            // 
            // tienvesinh
            // 
            this.tienvesinh.DataPropertyName = "tienvesinh";
            this.tienvesinh.HeaderText = "Tiền vệ sinh";
            this.tienvesinh.MinimumWidth = 6;
            this.tienvesinh.Name = "tienvesinh";
            // 
            // tienphong
            // 
            this.tienphong.DataPropertyName = "tienphong";
            this.tienphong.HeaderText = "Giá/Phòng";
            this.tienphong.MinimumWidth = 6;
            this.tienphong.Name = "tienphong";
            // 
            // tiennguoi
            // 
            this.tiennguoi.DataPropertyName = "tiennguoi";
            this.tiennguoi.HeaderText = "Giá/Người";
            this.tiennguoi.MinimumWidth = 6;
            this.tiennguoi.Name = "tiennguoi";
            // 
            // idBill
            // 
            this.idBill.DataPropertyName = "id";
            this.idBill.HeaderText = "ID";
            this.idBill.MinimumWidth = 6;
            this.idBill.Name = "idBill";
            // 
            // idHD
            // 
            this.idHD.DataPropertyName = "idHopDongChiTiet";
            this.idHD.HeaderText = "ID Hợp Đồng";
            this.idHD.MinimumWidth = 6;
            this.idHD.Name = "idHD";
            // 
            // idBillDV
            // 
            this.idBillDV.DataPropertyName = "idBillDV";
            this.idBillDV.HeaderText = "Bill DV";
            this.idBillDV.MinimumWidth = 6;
            this.idBillDV.Name = "idBillDV";
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            // 
            // tien
            // 
            this.tien.DataPropertyName = "tien";
            this.tien.HeaderText = "Tiền";
            this.tien.MinimumWidth = 6;
            this.tien.Name = "tien";
            // 
            // trangThaiBill
            // 
            this.trangThaiBill.DataPropertyName = "trangThai";
            this.trangThaiBill.HeaderText = "Trạng Thái";
            this.trangThaiBill.MinimumWidth = 6;
            this.trangThaiBill.Name = "trangThaiBill";
            // 
            // moTa
            // 
            this.moTa.DataPropertyName = "mieuTa";
            this.moTa.HeaderText = "Ghi chu";
            this.moTa.MinimumWidth = 6;
            this.moTa.Name = "moTa";
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 627);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBoxIdBillDV);
            this.Controls.Add(this.btnXuatEX);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerNgayThu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMaHD);
            this.Controls.Add(this.textTien);
            this.Controls.Add(this.textGhiChu);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBill);
            this.Name = "FormThanhToan";
            this.Text = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textGhiChu;
        private System.Windows.Forms.TextBox textTien;
        private System.Windows.Forms.ComboBox comboBoxMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn batDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mieuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.Button btnXuatEX;
        private System.Windows.Forms.ComboBox comboBoxIdBillDV;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodiencu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienphatsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonuoccu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonuocmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonuocphatsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiadien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongianuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiendien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiennuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienwifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienvesinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiennguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBillDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
    }
}