namespace QuanLyKhachSan
{
    partial class FormThongKeHD
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSHH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHDM)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTT
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTT.Legends.Add(legend1);
            this.chartTT.Location = new System.Drawing.Point(27, 12);
            this.chartTT.Name = "chartTT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số Lượng HD";
            this.chartTT.Series.Add(series1);
            this.chartTT.Size = new System.Drawing.Size(549, 572);
            this.chartTT.TabIndex = 0;
            this.chartTT.Text = "Biểu đồ thống kê tình trạng hợp đồng";
            title1.Name = "Title1";
            title1.Text = "Biểu đồ thống kê theo tình trạng hợp dồng";
            this.chartTT.Titles.Add(title1);
            // 
            // chartSHH
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSHH.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSHH.Legends.Add(legend2);
            this.chartSHH.Location = new System.Drawing.Point(667, 296);
            this.chartSHH.Name = "chartSHH";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số HD";
            this.chartSHH.Series.Add(series2);
            this.chartSHH.Size = new System.Drawing.Size(547, 288);
            this.chartSHH.TabIndex = 1;
            this.chartSHH.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Biểu đồ thống kê số lượng hợp đồng sắp hết hạn trong 4 tháng tiếp theo";
            this.chartSHH.Titles.Add(title2);
            // 
            // chartHDM
            // 
            chartArea3.Name = "ChartArea1";
            this.chartHDM.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartHDM.Legends.Add(legend3);
            this.chartHDM.Location = new System.Drawing.Point(667, 12);
            this.chartHDM.Name = "chartHDM";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Số HD";
            this.chartHDM.Series.Add(series3);
            this.chartHDM.Size = new System.Drawing.Size(547, 250);
            this.chartHDM.TabIndex = 2;
            this.chartHDM.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Biểu đồ số lượng hợp đồng mới trong 4 tháng trở lại đây";
            this.chartHDM.Titles.Add(title3);
            // 
            // FormThongKeHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 875);
            this.Controls.Add(this.chartHDM);
            this.Controls.Add(this.chartSHH);
            this.Controls.Add(this.chartTT);
            this.Name = "FormThongKeHD";
            this.Text = "FormThongKeHD";
            this.Load += new System.EventHandler(this.FormThongKeHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSHH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHDM;
    }
}