namespace QuanLyKhachSan
{
    partial class FormThongKePhong
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTTPhong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGiuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTTPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGiuong)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTTPhong
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTTPhong.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTTPhong.Legends.Add(legend1);
            this.chartTTPhong.Location = new System.Drawing.Point(47, 39);
            this.chartTTPhong.Name = "chartTTPhong";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số Phong";
            this.chartTTPhong.Series.Add(series1);
            this.chartTTPhong.Size = new System.Drawing.Size(567, 257);
            this.chartTTPhong.TabIndex = 0;
            this.chartTTPhong.Text = "chartTTPhong";
            title1.Name = "Title1";
            title1.Text = "Biểu đồ thống kê trạng thái phòng";
            this.chartTTPhong.Titles.Add(title1);
            // 
            // chartGiuong
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGiuong.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGiuong.Legends.Add(legend2);
            this.chartGiuong.Location = new System.Drawing.Point(47, 331);
            this.chartGiuong.Name = "chartGiuong";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số giường";
            this.chartGiuong.Series.Add(series2);
            this.chartGiuong.Size = new System.Drawing.Size(567, 257);
            this.chartGiuong.TabIndex = 1;
            this.chartGiuong.Text = "chartPhong";
            title2.Name = "Title1";
            title2.Text = "Biểu đồ thống kê trạng thái giường";
            this.chartGiuong.Titles.Add(title2);
            // 
            // FormThongKePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 676);
            this.Controls.Add(this.chartGiuong);
            this.Controls.Add(this.chartTTPhong);
            this.Name = "FormThongKePhong";
            this.Text = "FormThongKePhong";
            this.Load += new System.EventHandler(this.FormThongKePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTTPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGiuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTTPhong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGiuong;
    }
}