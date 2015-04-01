namespace StatAnalisys
{
    partial class CClouds
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCloudsZDCVert = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCloudsZDCHor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCloudsZUCVert = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCloudsZUCHor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZDCVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZDCHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZUCVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZUCHor)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCloudsZDCVert
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCloudsZDCVert.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCloudsZDCVert.Legends.Add(legend1);
            this.chartCloudsZDCVert.Location = new System.Drawing.Point(12, 41);
            this.chartCloudsZDCVert.Name = "chartCloudsZDCVert";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 2;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Clouds";
            series1.YValuesPerPoint = 2;
            this.chartCloudsZDCVert.Series.Add(series1);
            this.chartCloudsZDCVert.Size = new System.Drawing.Size(529, 252);
            this.chartCloudsZDCVert.TabIndex = 1;
            this.chartCloudsZDCVert.Text = "Clouds (vertical assymerty) for down-zero-crossing waves";
            // 
            // chartCloudsZDCHor
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCloudsZDCHor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCloudsZDCHor.Legends.Add(legend2);
            this.chartCloudsZDCHor.Location = new System.Drawing.Point(12, 332);
            this.chartCloudsZDCHor.Name = "chartCloudsZDCHor";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerSize = 2;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Clouds";
            series2.YValuesPerPoint = 2;
            this.chartCloudsZDCHor.Series.Add(series2);
            this.chartCloudsZDCHor.Size = new System.Drawing.Size(529, 255);
            this.chartCloudsZDCHor.TabIndex = 2;
            this.chartCloudsZDCHor.Text = "Clouds (horisontal assymerty) for down-zero-crossing waves";
            // 
            // chartCloudsZUCVert
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCloudsZUCVert.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCloudsZUCVert.Legends.Add(legend3);
            this.chartCloudsZUCVert.Location = new System.Drawing.Point(572, 41);
            this.chartCloudsZUCVert.Name = "chartCloudsZUCVert";
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Red;
            series3.MarkerSize = 2;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Clouds";
            series3.YValuesPerPoint = 2;
            this.chartCloudsZUCVert.Series.Add(series3);
            this.chartCloudsZUCVert.Size = new System.Drawing.Size(529, 252);
            this.chartCloudsZUCVert.TabIndex = 3;
            this.chartCloudsZUCVert.Text = "Clouds (vertical assymerty) for up-zero-crossing waves";
            // 
            // chartCloudsZUCHor
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCloudsZUCHor.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCloudsZUCHor.Legends.Add(legend4);
            this.chartCloudsZUCHor.Location = new System.Drawing.Point(572, 332);
            this.chartCloudsZUCHor.Name = "chartCloudsZUCHor";
            series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerSize = 2;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Clouds";
            series4.YValuesPerPoint = 2;
            this.chartCloudsZUCHor.Series.Add(series4);
            this.chartCloudsZUCHor.Size = new System.Drawing.Size(529, 255);
            this.chartCloudsZUCHor.TabIndex = 4;
            this.chartCloudsZUCHor.Text = "Clouds (horisontal assymerty) for up-zero-crossing waves";
            // 
            // CClouds
            // 
            this.ClientSize = new System.Drawing.Size(1096, 599);
            this.Controls.Add(this.chartCloudsZUCHor);
            this.Controls.Add(this.chartCloudsZUCVert);
            this.Controls.Add(this.chartCloudsZDCHor);
            this.Controls.Add(this.chartCloudsZDCVert);
            this.Name = "CClouds";
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZDCVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZDCHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZUCVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZUCHor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCloudsZDCVert;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCloudsZDCHor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCloudsZUCVert;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCloudsZUCHor;

    }
}