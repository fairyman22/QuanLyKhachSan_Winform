namespace QuanLyKhachSan
{
    partial class FormUpdatePhong
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.textPhong = new System.Windows.Forms.TextBox();
            this.textSlHT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.textSLTD = new System.Windows.Forms.TextBox();
            this.comboTrangThai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng Thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng SV Hiện Tại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Lượng Tối Đa";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(340, 282);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // textPhong
            // 
            this.textPhong.Location = new System.Drawing.Point(373, 60);
            this.textPhong.Name = "textPhong";
            this.textPhong.Size = new System.Drawing.Size(114, 22);
            this.textPhong.TabIndex = 7;
            // 
            // textSlHT
            // 
            this.textSlHT.Location = new System.Drawing.Point(373, 170);
            this.textSlHT.Name = "textSlHT";
            this.textSlHT.Size = new System.Drawing.Size(114, 22);
            this.textSlHT.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 22;
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhong.Location = new System.Drawing.Point(334, 9);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(98, 32);
            this.labelTenPhong.TabIndex = 23;
            this.labelTenPhong.Text = "label3";
            // 
            // textSLTD
            // 
            this.textSLTD.Location = new System.Drawing.Point(373, 234);
            this.textSLTD.Name = "textSLTD";
            this.textSLTD.Size = new System.Drawing.Size(114, 22);
            this.textSLTD.TabIndex = 24;
            // 
            // comboTrangThai
            // 
            this.comboTrangThai.FormattingEnabled = true;
            this.comboTrangThai.Items.AddRange(new object[] {
            "Still",
            "Full"});
            this.comboTrangThai.Location = new System.Drawing.Point(373, 118);
            this.comboTrangThai.Name = "comboTrangThai";
            this.comboTrangThai.Size = new System.Drawing.Size(121, 24);
            this.comboTrangThai.TabIndex = 25;
            // 
            // FormUpdatePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 385);
            this.Controls.Add(this.comboTrangThai);
            this.Controls.Add(this.textSLTD);
            this.Controls.Add(this.labelTenPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSlHT);
            this.Controls.Add(this.textPhong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePhong";
            this.Text = "FormUpdatePhong";
            this.Load += new System.EventHandler(this.FormUpdatePhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox textPhong;
        private System.Windows.Forms.TextBox textSlHT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.TextBox textSLTD;
        private System.Windows.Forms.ComboBox comboTrangThai;
    }
}