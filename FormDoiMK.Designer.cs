namespace QuanLyKhachSan
{
    partial class FormDoiMK
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
            this.OK = new System.Windows.Forms.Button();
            this.textMKcu = new System.Windows.Forms.TextBox();
            this.textMKmoi = new System.Windows.Forms.TextBox();
            this.textMKmoi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(232, 273);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(79, 31);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // textMKcu
            // 
            this.textMKcu.Location = new System.Drawing.Point(232, 101);
            this.textMKcu.Name = "textMKcu";
            this.textMKcu.PasswordChar = '*';
            this.textMKcu.Size = new System.Drawing.Size(177, 22);
            this.textMKcu.TabIndex = 4;
            this.textMKcu.UseSystemPasswordChar = true;
            // 
            // textMKmoi
            // 
            this.textMKmoi.Location = new System.Drawing.Point(232, 146);
            this.textMKmoi.Name = "textMKmoi";
            this.textMKmoi.PasswordChar = '*';
            this.textMKmoi.Size = new System.Drawing.Size(177, 22);
            this.textMKmoi.TabIndex = 5;
            this.textMKmoi.UseSystemPasswordChar = true;
            // 
            // textMKmoi2
            // 
            this.textMKmoi2.Location = new System.Drawing.Point(232, 193);
            this.textMKmoi2.Name = "textMKmoi2";
            this.textMKmoi2.PasswordChar = '*';
            this.textMKmoi2.Size = new System.Drawing.Size(177, 22);
            this.textMKmoi2.TabIndex = 6;
            this.textMKmoi2.UseSystemPasswordChar = true;
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 376);
            this.Controls.Add(this.textMKmoi2);
            this.Controls.Add(this.textMKmoi);
            this.Controls.Add(this.textMKcu);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            this.Load += new System.EventHandler(this.FormDoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox textMKcu;
        private System.Windows.Forms.TextBox textMKmoi;
        private System.Windows.Forms.TextBox textMKmoi2;
    }
}