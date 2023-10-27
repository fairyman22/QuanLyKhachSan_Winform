namespace Final
{
    partial class FormChitiet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMaPhong = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsodienmoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsodiencu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsonuocmoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsonuoccu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxMaPhong);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // comboBoxMaPhong
            // 
            this.comboBoxMaPhong.FormattingEnabled = true;
            this.comboBoxMaPhong.Location = new System.Drawing.Point(166, 27);
            this.comboBoxMaPhong.Name = "comboBoxMaPhong";
            this.comboBoxMaPhong.Size = new System.Drawing.Size(93, 28);
            this.comboBoxMaPhong.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(166, 123);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(82, 27);
            this.txtID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsodienmoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtsodiencu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(478, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điện (kWh)";
            // 
            // txtsodienmoi
            // 
            this.txtsodienmoi.Location = new System.Drawing.Point(166, 102);
            this.txtsodienmoi.Name = "txtsodienmoi";
            this.txtsodienmoi.Size = new System.Drawing.Size(82, 27);
            this.txtsodienmoi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện mới";
            // 
            // txtsodiencu
            // 
            this.txtsodiencu.Location = new System.Drawing.Point(166, 36);
            this.txtsodiencu.Name = "txtsodiencu";
            this.txtsodiencu.Size = new System.Drawing.Size(82, 27);
            this.txtsodiencu.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số điện cũ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtsonuocmoi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtsonuoccu);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(844, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 175);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nước (m³)";
            // 
            // txtsonuocmoi
            // 
            this.txtsonuocmoi.Location = new System.Drawing.Point(166, 102);
            this.txtsonuocmoi.Name = "txtsonuocmoi";
            this.txtsonuocmoi.Size = new System.Drawing.Size(82, 27);
            this.txtsonuocmoi.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số nước mới";
            // 
            // txtsonuoccu
            // 
            this.txtsonuoccu.Location = new System.Drawing.Point(166, 36);
            this.txtsonuoccu.Name = "txtsonuoccu";
            this.txtsonuoccu.Size = new System.Drawing.Size(82, 27);
            this.txtsonuoccu.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số nưỡc cũ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 80);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tiền Wifi: 400000/tháng \r\nTiền vệ sinh: 200000/tháng\r\nĐơn giá điện: 3500/kWh\r\nĐơn" +
    " giá nước: 15000/m³";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(844, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 153);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông báo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maPhong,
            this.ngay,
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 160);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Mã Phòng ";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cập nhật dữ liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Trở lại ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(510, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Tìm theo mã phòng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(674, 316);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(90, 35);
            this.txttimkiem.TabIndex = 9;
            // 
            // FormChitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 667);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormChitiet";
            this.Text = "FormChitiet";
            this.Load += new System.EventHandler(this.FormChitiet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsodienmoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsodiencu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtsonuocmoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsonuoccu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.ComboBox comboBoxMaPhong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
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
    }
}