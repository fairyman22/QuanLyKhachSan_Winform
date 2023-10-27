namespace QuanLyKhachSan
{
    partial class FormSuaHD
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
            this.textGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.dateTimePickerKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMG = new System.Windows.Forms.Button();
            this.comboBoxmaGiuong = new System.Windows.Forms.ComboBox();
            this.comboBoxMaPhong = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.labeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textGia
            // 
            this.textGia.Location = new System.Drawing.Point(115, 267);
            this.textGia.Name = "textGia";
            this.textGia.Size = new System.Drawing.Size(121, 22);
            this.textGia.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Giá";
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Location = new System.Drawing.Point(538, 225);
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(121, 22);
            this.textBoxGhiChu.TabIndex = 44;
            // 
            // dateTimePickerKT
            // 
            this.dateTimePickerKT.Location = new System.Drawing.Point(116, 104);
            this.dateTimePickerKT.Name = "dateTimePickerKT";
            this.dateTimePickerKT.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerKT.TabIndex = 43;
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Location = new System.Drawing.Point(540, 107);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBD.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(457, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ngày BĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ngày KT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "ID:";
            // 
            // btnMG
            // 
            this.btnMG.Location = new System.Drawing.Point(662, 164);
            this.btnMG.Name = "btnMG";
            this.btnMG.Size = new System.Drawing.Size(22, 23);
            this.btnMG.TabIndex = 51;
            this.btnMG.Text = "button1";
            this.btnMG.UseVisualStyleBackColor = true;
            // 
            // comboBoxmaGiuong
            // 
            this.comboBoxmaGiuong.FormattingEnabled = true;
            this.comboBoxmaGiuong.Location = new System.Drawing.Point(535, 163);
            this.comboBoxmaGiuong.Name = "comboBoxmaGiuong";
            this.comboBoxmaGiuong.Size = new System.Drawing.Size(121, 24);
            this.comboBoxmaGiuong.TabIndex = 50;
            // 
            // comboBoxMaPhong
            // 
            this.comboBoxMaPhong.FormattingEnabled = true;
            this.comboBoxMaPhong.Location = new System.Drawing.Point(115, 166);
            this.comboBoxMaPhong.Name = "comboBoxMaPhong";
            this.comboBoxMaPhong.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaPhong.TabIndex = 49;
            this.comboBoxMaPhong.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaPhong_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "Mã Phòng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ma Giuong";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(558, 309);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 54;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labeID
            // 
            this.labeID.AutoSize = true;
            this.labeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeID.Location = new System.Drawing.Point(379, 49);
            this.labeID.Name = "labeID";
            this.labeID.Size = new System.Drawing.Size(31, 20);
            this.labeID.TabIndex = 55;
            this.labeID.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Trangh Thái";
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Items.AddRange(new object[] {
            "HD",
            "QH"});
            this.comboBoxTrangThai.Location = new System.Drawing.Point(115, 217);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTrangThai.TabIndex = 57;
            // 
            // FormSuaHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 360);
            this.Controls.Add(this.comboBoxTrangThai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeID);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMG);
            this.Controls.Add(this.comboBoxmaGiuong);
            this.Controls.Add(this.comboBoxMaPhong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textGia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxGhiChu);
            this.Controls.Add(this.dateTimePickerKT);
            this.Controls.Add(this.dateTimePickerBD);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FormSuaHD";
            this.Text = "FormSuaHD";
            this.Load += new System.EventHandler(this.FormSuaHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.DateTimePicker dateTimePickerKT;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMG;
        private System.Windows.Forms.ComboBox comboBoxmaGiuong;
        private System.Windows.Forms.ComboBox comboBoxMaPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label labeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
    }
}