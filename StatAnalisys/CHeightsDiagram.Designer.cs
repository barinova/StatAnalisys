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
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartZDCHeights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartZUCHeights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZUCHeights = new System.Windows.Forms.Panel();
            this.ZDCHeights = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartZDCHeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUCHeights)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.ZUCHeights.SuspendLayout();
            this.ZDCHeights.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartZDCHeights
            // 
            chartArea1.AxisX.LabelStyle.Format = "0.000";
            chartArea1.AxisY.LabelStyle.Format = "0.000";
            chartArea1.AxisY.Title = "H";
            chartArea1.Name = "ChartArea1";
            this.chartZDCHeights.ChartAreas.Add(chartArea1);
            legendItem1.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legend1.CustomItems.Add(legendItem1);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chartZDCHeights.Legends.Add(legend1);
            this.chartZDCHeights.Location = new System.Drawing.Point(12, 3);
            this.chartZDCHeights.Name = "chartZDCHeights";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Heights";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Significiant height";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Height one third";
            this.chartZDCHeights.Series.Add(series1);
            this.chartZDCHeights.Series.Add(series2);
            this.chartZDCHeights.Series.Add(series3);
            this.chartZDCHeights.Size = new System.Drawing.Size(1223, 349);
            this.chartZDCHeights.TabIndex = 0;
            this.chartZDCHeights.Text = "chartHeightsZDC";
            // 
            // chartZUCHeights
            // 
            chartArea2.AxisX.LabelStyle.Format = "0.000";
            chartArea2.AxisY.LabelStyle.Format = "0.000";
            chartArea2.AxisY.Title = "H";
            chartArea2.Name = "ChartArea1";
            this.chartZUCHeights.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartZUCHeights.Legends.Add(legend2);
            this.chartZUCHeights.Location = new System.Drawing.Point(12, 16);
            this.chartZUCHeights.Name = "chartZUCHeights";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Heights";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Signigiciant height";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Height one third";
            this.chartZUCHeights.Series.Add(series4);
            this.chartZUCHeights.Series.Add(series5);
            this.chartZUCHeights.Series.Add(series6);
            this.chartZUCHeights.Size = new System.Drawing.Size(1226, 339);
            this.chartZUCHeights.TabIndex = 1;
            this.chartZUCHeights.Text = "hartZUCHeights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "-down-zero-crossing Heights";
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
            // ZUCHeights
            // 
            this.ZUCHeights.Controls.Add(this.label1);
            this.ZUCHeights.Controls.Add(this.chartZDCHeights);
            this.ZUCHeights.Location = new System.Drawing.Point(15, 28);
            this.ZUCHeights.Name = "ZUCHeights";
            this.ZUCHeights.Size = new System.Drawing.Size(1249, 355);
            this.ZUCHeights.TabIndex = 7;
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
            // CHeightsDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 743);
            this.Controls.Add(this.ZDCHeights);
            this.Controls.Add(this.ZUCHeights);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "CHeightsDiagram";
            this.Text = "CSingleWaveDatas";
            ((System.ComponentModel.ISupportInitialize)(this.chartZDCHeights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUCHeights)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ZUCHeights.ResumeLayout(false);
            this.ZUCHeights.PerformLayout();
            this.ZDCHeights.ResumeLayout(false);
            this.ZDCHeights.PerformLayout();
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