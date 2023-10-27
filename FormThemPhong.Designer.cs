namespace QuanLyKhachSan
{
    partial class FormThemPhong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaPhong = new System.Windows.Forms.TextBox();
            this.textTenPhong = new System.Windows.Forms.TextBox();
            this.textSoSvHT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.textBoxSoTVTD = new System.Windows.Forms.TextBox();
            this.comboTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số SV Tối Đa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số SV";
            // 
            // textMaPhong
            // 
            this.textMaPhong.Location = new System.Drawing.Point(367, 48);
            this.textMaPhong.Name = "textMaPhong";
            this.textMaPhong.Size = new System.Drawing.Size(145, 22);
            this.textMaPhong.TabIndex = 5;
            // 
            // textTenPhong
            // 
            this.textTenPhong.Location = new System.Drawing.Point(367, 173);
            this.textTenPhong.Name = "textTenPhong";
            this.textTenPhong.Size = new System.Drawing.Size(146, 22);
            this.textTenPhong.TabIndex = 7;
            // 
            // textSoSvHT
            // 
            this.textSoSvHT.Location = new System.Drawing.Point(367, 240);
            this.textSoSvHT.Name = "textSoSvHT";
            this.textSoSvHT.Size = new System.Drawing.Size(146, 22);
            this.textSoSvHT.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(377, 357);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textBoxSoTVTD
            // 
            this.textBoxSoTVTD.Location = new System.Drawing.Point(367, 294);
            this.textBoxSoTVTD.Name = "textBoxSoTVTD";
            this.textBoxSoTVTD.Size = new System.Drawing.Size(146, 22);
            this.textBoxSoTVTD.TabIndex = 11;
            // 
            // comboTrangThai
            // 
            this.comboTrangThai.FormattingEnabled = true;
            this.comboTrangThai.Items.AddRange(new object[] {
            "Still",
            "Full"});
            this.comboTrangThai.Location = new System.Drawing.Point(367, 105);
            this.comboTrangThai.Name = "comboTrangThai";
            this.comboTrangThai.Size = new System.Drawing.Size(146, 24);
            this.comboTrangThai.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Trạng Thái";
            // 
            // FormThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.comboTrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSoTVTD);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textSoSvHT);
            this.Controls.Add(this.textTenPhong);
            this.Controls.Add(this.textMaPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemPhong";
            this.Text = "FormThemPhong";
            this.Load += new System.EventHandler(this.FormThemPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaPhong;
        private System.Windows.Forms.TextBox textTenPhong;
        private System.Windows.Forms.TextBox textSoSvHT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textBoxSoTVTD;
        private System.Windows.Forms.ComboBox comboTrangThai;
        private System.Windows.Forms.Label label5;
    }
}