namespace QuanLyKhachSan
{
    partial class FormThongKeSV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartGT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartQT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNamH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNamH)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGT
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGT.Legends.Add(legend1);
            this.chartGT.Location = new System.Drawing.Point(44, 52);
            this.chartGT.Name = "chartGT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số sinh viên";
            this.chartGT.Series.Add(series1);
            this.chartGT.Size = new System.Drawing.Size(582, 316);
            this.chartGT.TabIndex = 0;
            this.chartGT.Text = "chart";
            title1.Name = "Title1";
            title1.Text = "Biểu đồ thống kê số lượng nam nữ";
            this.chartGT.Titles.Add(title1);
            // 
            // chartQT
            // 
            chartArea2.Name = "ChartArea1";
            this.chartQT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartQT.Legends.Add(legend2);
            this.chartQT.Location = new System.Drawing.Point(677, 47);
            this.chartQT.Name = "chartQT";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số sinh viên";
            this.chartQT.Series.Add(series2);
            this.chartQT.Size = new System.Drawing.Size(582, 321);
            this.chartQT.TabIndex = 1;
            this.chartQT.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Biểu đồ thống kê theo quê quán";
            this.chartQT.Titles.Add(title2);
            // 
            // chartNH
            // 
            chartArea3.Name = "ChartArea1";
            this.chartNH.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartNH.Legends.Add(legend3);
            this.chartNH.Location = new System.Drawing.Point(44, 399);
            this.chartNH.Name = "chartNH";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Số sinh viên";
            this.chartNH.Series.Add(series3);
            this.chartNH.Size = new System.Drawing.Size(582, 302);
            this.chartNH.TabIndex = 2;
            this.chartNH.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Biểu đò thống kê sinh viên KTX theo ngành học";
            this.chartNH.Titles.Add(title3);
            // 
            // chartNamH
            // 
            chartArea4.Name = "ChartArea1";
            this.chartNamH.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartNamH.Legends.Add(legend4);
            this.chartNamH.Location = new System.Drawing.Point(677, 399);
            this.chartNamH.Name = "chartNamH";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Số sinh viên";
            this.chartNamH.Series.Add(series4);
            this.chartNamH.Size = new System.Drawing.Size(582, 302);
            this.chartNamH.TabIndex = 3;
            this.chartNamH.Text = "chart4";
            title4.Name = "Title1";
            title4.Text = "Biểu đồ thống kê số lượng sinh viên theo năm đã học";
            this.chartNamH.Titles.Add(title4);
            // 
            // FormThongKeSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 746);
            this.Controls.Add(this.chartNamH);
            this.Controls.Add(this.chartNH);
            this.Controls.Add(this.chartQT);
            this.Controls.Add(this.chartGT);
            this.Name = "FormThongKeSV";
            this.Text = "FormThongKeSV";
            this.Load += new System.EventHandler(this.FormThongKeSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNamH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNamH;
    }
}