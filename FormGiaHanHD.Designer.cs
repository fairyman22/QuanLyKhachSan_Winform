namespace QuanLyKhachSan
{
    partial class FormGiaHanHD
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
            this.labeID = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMP = new System.Windows.Forms.Label();
            this.labeMG = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.labelTT = new System.Windows.Forms.Label();
            this.labelGC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Trangh Thái";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeID
            // 
            this.labeID.AutoSize = true;
            this.labeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeID.Location = new System.Drawing.Point(393, 31);
            this.labeID.Name = "labeID";
            this.labeID.Size = new System.Drawing.Size(31, 20);
            this.labeID.TabIndex = 73;
            this.labeID.Text = "ID:";
            this.labeID.Click += new System.EventHandler(this.labeID_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(335, 303);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 72;
            this.btnLuu.Text = "Gia hạn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 68;
            this.label13.Text = "Mã Phòng";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 67;
            this.label12.Text = "Ma Giuong";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "Giá";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dateTimePickerKT
            // 
            this.dateTimePickerKT.Location = new System.Drawing.Point(533, 177);
            this.dateTimePickerKT.Name = "dateTimePickerKT";
            this.dateTimePickerKT.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerKT.TabIndex = 63;
            this.dateTimePickerKT.ValueChanged += new System.EventHandler(this.dateTimePickerKT_ValueChanged);
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Location = new System.Drawing.Point(533, 92);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBD.TabIndex = 62;
            this.dateTimePickerBD.ValueChanged += new System.EventHandler(this.dateTimePickerBD_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 61;
            this.label14.Text = "Ghi chú";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ngày BĐ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Ngày KT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Location = new System.Drawing.Point(166, 95);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(57, 16);
            this.labelMP.TabIndex = 75;
            this.labelMP.Text = "labelMP";
            this.labelMP.Click += new System.EventHandler(this.labelMP_Click);
            // 
            // labeMG
            // 
            this.labeMG.AutoSize = true;
            this.labeMG.Location = new System.Drawing.Point(166, 140);
            this.labeMG.Name = "labeMG";
            this.labeMG.Size = new System.Drawing.Size(44, 16);
            this.labeMG.TabIndex = 76;
            this.labeMG.Text = "label3";
            this.labeMG.Click += new System.EventHandler(this.labeMG_Click);
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Location = new System.Drawing.Point(166, 225);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(44, 16);
            this.labelGia.TabIndex = 77;
            this.labelGia.Text = "label7";
            this.labelGia.Click += new System.EventHandler(this.labelGia_Click);
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.Location = new System.Drawing.Point(166, 183);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(37, 16);
            this.labelTT.TabIndex = 78;
            this.labelTT.Text = "label";
            this.labelTT.Click += new System.EventHandler(this.labelTT_Click);
            // 
            // labelGC
            // 
            this.labelGC.AutoSize = true;
            this.labelGC.Location = new System.Drawing.Point(166, 269);
            this.labelGC.Name = "labelGC";
            this.labelGC.Size = new System.Drawing.Size(44, 16);
            this.labelGC.TabIndex = 79;
            this.labelGC.Text = "label9";
            this.labelGC.Click += new System.EventHandler(this.labelGC_Click);
            // 
            // FormGiaHanHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 375);
            this.Controls.Add(this.labelGC);
            this.Controls.Add(this.labelTT);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labeMG);
            this.Controls.Add(this.labelMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeID);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerKT);
            this.Controls.Add(this.dateTimePickerBD);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FormGiaHanHD";
            this.Text = "FormGiaHanHD";
            this.Load += new System.EventHandler(this.FormGiaHanHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeID;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerKT;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.Label labeMG;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.Label labelGC;
    }
}