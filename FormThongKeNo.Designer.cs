namespace QuanLyKhachSan
{
    partial class FormThongKeNo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTongNo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNoThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxMaSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBillDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTongNo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTongNo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTongNo.Legends.Add(legend1);
            this.chartTongNo.Location = new System.Drawing.Point(2, 38);
            this.chartTongNo.Name = "chartTongNo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tiền";
            this.chartTongNo.Series.Add(series1);
            this.chartTongNo.Size = new System.Drawing.Size(552, 303);
            this.chartTongNo.TabIndex = 0;
            this.chartTongNo.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Biểu đồ thống kê tiền nợ và tổng tiền";
            this.chartTongNo.Titles.Add(title1);
            // 
            // chartNoThang
            // 
            this.chartNoThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartNoThang.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNoThang.Legends.Add(legend2);
            this.chartNoThang.Location = new System.Drawing.Point(2, 390);
            this.chartNoThang.Name = "chartNoThang";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tổng tiền";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Đã thu";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Nợ";
            this.chartNoThang.Series.Add(series2);
            this.chartNoThang.Series.Add(series3);
            this.chartNoThang.Series.Add(series4);
            this.chartNoThang.Size = new System.Drawing.Size(1172, 331);
            this.chartNoThang.TabIndex = 1;
            this.chartNoThang.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Biểu đồ thống kê theo từng tháng";
            this.chartNoThang.Titles.Add(title2);
            // 
            // comboBoxMaSV
            // 
            this.comboBoxMaSV.FormattingEnabled = true;
            this.comboBoxMaSV.Location = new System.Drawing.Point(670, 11);
            this.comboBoxMaSV.Name = "comboBoxMaSV";
            this.comboBoxMaSV.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaSV.TabIndex = 2;
            this.comboBoxMaSV.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaSV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã SV";
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBill,
            this.hoTen,
            this.maSV,
            this.idHD,
            this.idBillDV,
            this.ngay,
            this.tien,
            this.trangThaiBill,
            this.moTa});
            this.dataGridViewBill.Location = new System.Drawing.Point(560, 41);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowTemplate.Height = 24;
            this.dataGridViewBill.Size = new System.Drawing.Size(626, 300);
            this.dataGridViewBill.TabIndex = 4;
            // 
            // idBill
            // 
            this.idBill.DataPropertyName = "id";
            this.idBill.HeaderText = "ID";
            this.idBill.MinimumWidth = 6;
            this.idBill.Name = "idBill";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Tên SV";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.HeaderText = "Mã SV";
            this.maSV.MinimumWidth = 6;
            this.maSV.Name = "maSV";
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
            this.moTa.HeaderText = "Ghi Chu";
            this.moTa.MinimumWidth = 6;
            this.moTa.Name = "moTa";
            // 
            // btnTatCa
            // 
            this.btnTatCa.Location = new System.Drawing.Point(825, 11);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnTatCa.TabIndex = 5;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // FormThongKeNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 660);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaSV);
            this.Controls.Add(this.chartNoThang);
            this.Controls.Add(this.chartTongNo);
            this.Name = "FormThongKeNo";
            this.Text = "FormThongKeNo";
            this.Load += new System.EventHandler(this.FormThongKeNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTongNo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNoThang;
        private System.Windows.Forms.ComboBox comboBoxMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBillDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private System.Windows.Forms.Button btnTatCa;
    }
}