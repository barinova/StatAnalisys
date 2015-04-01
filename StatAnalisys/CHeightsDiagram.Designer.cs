namespace StatAnalisys
{
    partial class CHeightsDiagram
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.ZDCHeights = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chartZUCHeights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ZUCHeights = new System.Windows.Forms.Panel();
            this.chartZDCHeights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZDCHeights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUCHeights)).BeginInit();
            this.ZUCHeights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZDCHeights)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "-down-zero-crossing Heights";
            // 
            // ZDCHeights
            // 
            this.ZDCHeights.Controls.Add(this.label2);
            this.ZDCHeights.Controls.Add(this.chartZUCHeights);
            this.ZDCHeights.Location = new System.Drawing.Point(15, 389);
            this.ZDCHeights.Name = "ZDCHeights";
            this.ZDCHeights.Size = new System.Drawing.Size(1249, 376);
            this.ZDCHeights.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-down-zero-crossing Heights";
            // 
            // chartZUCHeights
            // 
            chartArea1.AxisX.LabelStyle.Format = "0.000";
            chartArea1.AxisY.LabelStyle.Format = "0.000";
            chartArea1.AxisY.Title = "H";
            chartArea1.Name = "ChartArea1";
            this.chartZUCHeights.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartZUCHeights.Legends.Add(legend1);
            this.chartZUCHeights.Location = new System.Drawing.Point(12, 16);
            this.chartZUCHeights.Name = "chartZUCHeights";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Heights";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Signigiciant height";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "Height one third";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Maroon;
            series4.Legend = "Legend1";
            series4.Name = "2 * Significiant height";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Navy;
            series5.Legend = "Legend1";
            series5.Name = "Rouge wave";
            this.chartZUCHeights.Series.Add(series1);
            this.chartZUCHeights.Series.Add(series2);
            this.chartZUCHeights.Series.Add(series3);
            this.chartZUCHeights.Series.Add(series4);
            this.chartZUCHeights.Series.Add(series5);
            this.chartZUCHeights.Size = new System.Drawing.Size(1226, 248);
            this.chartZUCHeights.TabIndex = 1;
            this.chartZUCHeights.Text = "hartZUCHeights";
            // 
            // ZUCHeights
            // 
            this.ZUCHeights.Controls.Add(this.chartZDCHeights);
            this.ZUCHeights.Location = new System.Drawing.Point(15, 28);
            this.ZUCHeights.Name = "ZUCHeights";
            this.ZUCHeights.Size = new System.Drawing.Size(1249, 355);
            this.ZUCHeights.TabIndex = 7;
            // 
            // chartZDCHeights
            // 
            chartArea2.AxisX.LabelStyle.Format = "0.000";
            chartArea2.AxisY.LabelStyle.Format = "0.000";
            chartArea2.AxisY.Title = "H";
            chartArea2.Name = "ChartArea1";
            this.chartZDCHeights.ChartAreas.Add(chartArea2);
            legendItem1.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legend2.CustomItems.Add(legendItem1);
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.chartZDCHeights.Legends.Add(legend2);
            this.chartZDCHeights.Location = new System.Drawing.Point(6, 13);
            this.chartZDCHeights.Name = "chartZDCHeights";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Red;
            series6.LabelBorderWidth = 2;
            series6.Legend = "Legend1";
            series6.Name = "Heights";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Green;
            series7.LabelBorderWidth = 2;
            series7.Legend = "Legend1";
            series7.Name = "Significiant height";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series8.LabelBorderWidth = 2;
            series8.Legend = "Legend1";
            series8.Name = "Height one third";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Maroon;
            series9.LabelBorderWidth = 2;
            series9.Legend = "Legend1";
            series9.Name = "2 * Significiant height";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Navy;
            series10.LabelBorderWidth = 2;
            series10.Legend = "Legend1";
            series10.MarkerBorderWidth = 2;
            series10.Name = "RougeWave";
            this.chartZDCHeights.Series.Add(series6);
            this.chartZDCHeights.Series.Add(series7);
            this.chartZDCHeights.Series.Add(series8);
            this.chartZDCHeights.Series.Add(series9);
            this.chartZDCHeights.Series.Add(series10);
            this.chartZDCHeights.Size = new System.Drawing.Size(1223, 252);
            this.chartZDCHeights.TabIndex = 0;
            this.chartZDCHeights.Text = "chartHeightsZDC";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1276, 25);
            this.toolStrip1.TabIndex = 6;
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
            this.saveImagesToolStripMenuItem.Click += new System.EventHandler(this.saveImagesToolStripMenuItem_Click);
            // 
            // CHeightsDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZDCHeights);
            this.Controls.Add(this.ZUCHeights);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "CHeightsDiagram";
            this.Text = "CSingleWaveDatas";
            this.ZDCHeights.ResumeLayout(false);
            this.ZDCHeights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUCHeights)).EndInit();
            this.ZUCHeights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartZDCHeights)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartZDCHeights;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZUCHeights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImagesToolStripMenuItem;
        private System.Windows.Forms.Panel ZUCHeights;
        private System.Windows.Forms.Panel ZDCHeights;
    }
}