namespace QuanLyKhachSan
{
    partial class FormThongKe
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnPG = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnHD);
            this.panelMenu.Controls.Add(this.btnPG);
            this.panelMenu.Controls.Add(this.btnNo);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Location = new System.Drawing.Point(0, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1170, 39);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHD
            // 
            this.btnHD.Location = new System.Drawing.Point(212, 11);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(179, 30);
            this.btnHD.TabIndex = 3;
            this.btnHD.Text = "Thống kê hợp đồng";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnPG
            // 
            this.btnPG.Location = new System.Drawing.Point(397, 11);
            this.btnPG.Name = "btnPG";
            this.btnPG.Size = new System.Drawing.Size(179, 30);
            this.btnPG.TabIndex = 2;
            this.btnPG.Text = "Thống kê phòng & giường";
            this.btnPG.UseVisualStyleBackColor = true;
            this.btnPG.Click += new System.EventHandler(this.btnPG_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(582, 11);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(179, 30);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Thống kê nợ";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thống kê sinh viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 637);
            this.panel1.TabIndex = 1;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnPG;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}