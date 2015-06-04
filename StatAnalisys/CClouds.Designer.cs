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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartCloudsZUCHor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCloudsZUCVert = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCloudsZDCHor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCloudsZDCVert = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNumWave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZUCHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZUCVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZDCHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZDCVert)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clouds (horizontal assymerty) for down-zero-crossing waves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clouds (horizontal assymerty) for up-zero-crossing waves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clouds (vertical assymerty) for up-zero-crossing waves";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clouds (vertical assymerty) for down-zero-crossing waves";
            // 
            // chartCloudsZUCHor
            // 
            chartArea1.AxisX.LabelStyle.Format = "0.00";
            chartArea1.AxisX.Title = "H / Hthird";
            chartArea1.AxisY.Title = "sign(Xcr/Xtr - 1) * Xcr/Xtr";
            chartArea1.Name = "ChartArea1";
            this.chartCloudsZUCHor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCloudsZUCHor.Legends.Add(legend1);
            this.chartCloudsZUCHor.Location = new System.Drawing.Point(572, 357);
            this.chartCloudsZUCHor.Name = "chartCloudsZUCHor";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 3;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Clouds";
            series1.YValuesPerPoint = 2;
            this.chartCloudsZUCHor.Series.Add(series1);
            this.chartCloudsZUCHor.Size = new System.Drawing.Size(529, 287);
            this.chartCloudsZUCHor.TabIndex = 4;
            this.chartCloudsZUCHor.Text = "Clouds (horisontal assymerty) for up-zero-crossing waves";
            // 
            // chartCloudsZUCVert
            // 
            chartArea2.AxisX.LabelStyle.Format = "0.00";
            chartArea2.AxisX.Title = "H / Hthird";
            chartArea2.AxisY.Title = "sign(Ycr/Ytr - 1)  * Ycr/Ytr";
            chartArea2.Name = "ChartArea1";
            this.chartCloudsZUCVert.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCloudsZUCVert.Legends.Add(legend2);
            this.chartCloudsZUCVert.Location = new System.Drawing.Point(572, 41);
            this.chartCloudsZUCVert.Name = "chartCloudsZUCVert";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerSize = 3;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Clouds";
            series2.YValuesPerPoint = 2;
            this.chartCloudsZUCVert.Series.Add(series2);
            this.chartCloudsZUCVert.Size = new System.Drawing.Size(529, 288);
            this.chartCloudsZUCVert.TabIndex = 3;
            this.chartCloudsZUCVert.Text = "Clouds (vertical assymerty) for up-zero-crossing waves";
            // 
            // chartCloudsZDCHor
            // 
            chartArea3.AxisX.LabelStyle.Format = "0.00";
            chartArea3.AxisX.Title = "H / Hthird";
            chartArea3.AxisY.Title = "sign(Xcr/Xtr - 1) * Xcr/Xtr";
            chartArea3.Name = "ChartArea1";
            this.chartCloudsZDCHor.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCloudsZDCHor.Legends.Add(legend3);
            this.chartCloudsZDCHor.Location = new System.Drawing.Point(12, 357);
            this.chartCloudsZDCHor.Name = "chartCloudsZDCHor";
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Red;
            series3.MarkerSize = 3;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Clouds";
            series3.YValuesPerPoint = 2;
            this.chartCloudsZDCHor.Series.Add(series3);
            this.chartCloudsZDCHor.Size = new System.Drawing.Size(529, 287);
            this.chartCloudsZDCHor.TabIndex = 2;
            this.chartCloudsZDCHor.Text = "Clouds (horisontal assymerty) for down-zero-crossing waves";
            // 
            // chartCloudsZDCVert
            // 
            chartArea4.AxisX.LabelStyle.Format = "0.00";
            chartArea4.AxisX.Title = "H / Hthird";
            chartArea4.AxisY.Title = "sign(Ycr/Ytr - 1)  * Ycr/Ytr";
            chartArea4.Name = "ChartArea1";
            this.chartCloudsZDCVert.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCloudsZDCVert.Legends.Add(legend4);
            this.chartCloudsZDCVert.Location = new System.Drawing.Point(12, 38);
            this.chartCloudsZDCVert.Name = "chartCloudsZDCVert";
            series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerSize = 3;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Clouds";
            series4.YValuesPerPoint = 2;
            this.chartCloudsZDCVert.Series.Add(series4);
            this.chartCloudsZDCVert.Size = new System.Drawing.Size(529, 293);
            this.chartCloudsZDCVert.TabIndex = 1;
            this.chartCloudsZDCVert.Text = "Clouds (vertical assymerty) for down-zero-crossing waves";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1096, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImagesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveImagesToolStripMenuItem
            // 
            this.saveImagesToolStripMenuItem.Name = "saveImagesToolStripMenuItem";
            this.saveImagesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveImagesToolStripMenuItem.Text = "Save Images";
            this.saveImagesToolStripMenuItem.Click += new System.EventHandler(this.saveImagesToolStripMenuItem_Click_1);
            // 
            // labelNumWave
            // 
            this.labelNumWave.AutoSize = true;
            this.labelNumWave.Location = new System.Drawing.Point(971, 12);
            this.labelNumWave.Name = "labelNumWave";
            this.labelNumWave.Size = new System.Drawing.Size(0, 13);
            this.labelNumWave.TabIndex = 10;
            // 
            // CClouds
            // 
            this.ClientSize = new System.Drawing.Size(1096, 656);
            this.Controls.Add(this.labelNumWave);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartCloudsZUCHor);
            this.Controls.Add(this.chartCloudsZUCVert);
            this.Controls.Add(this.chartCloudsZDCHor);
            this.Controls.Add(this.chartCloudsZDCVert);
            this.Name = "CClouds";
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZUCHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZUCVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZDCHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCloudsZDCVert)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCloudsZDCVert;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCloudsZDCHor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCloudsZUCVert;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCloudsZUCHor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImagesToolStripMenuItem;
        private System.Windows.Forms.Label labelNumWave;

    }
}