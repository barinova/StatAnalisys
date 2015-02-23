namespace StatAnalisys
{
    partial class CProbabilitiesDiagram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlProb = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartZDCLog = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartZDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartZUCLog = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartZUC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlProb.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZDCLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZDC)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUCLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUC)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProb
            // 
            this.tabControlProb.Controls.Add(this.tabPage1);
            this.tabControlProb.Controls.Add(this.tabPage2);
            this.tabControlProb.Location = new System.Drawing.Point(12, 28);
            this.tabControlProb.Name = "tabControlProb";
            this.tabControlProb.SelectedIndex = 0;
            this.tabControlProb.Size = new System.Drawing.Size(1264, 550);
            this.tabControlProb.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartZDCLog);
            this.tabPage1.Controls.Add(this.chartZDC);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartZDCLog
            // 
            chartArea1.AxisX.LabelStyle.Format = "0.000";
            chartArea1.AxisX.Title = "Wave number";
            chartArea1.AxisY.LabelStyle.Format = "0.000";
            chartArea1.AxisY.Title = "P";
            chartArea1.Name = "ChartArea1";
            this.chartZDCLog.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartZDCLog.Legends.Add(legend1);
            this.chartZDCLog.Location = new System.Drawing.Point(6, 268);
            this.chartZDCLog.Name = "chartZDCLog";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Experemental Probabilities";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Teoretical Probabilities";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Through Probabilities";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Crest Probabilities";
            series4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chartZDCLog.Series.Add(series1);
            this.chartZDCLog.Series.Add(series2);
            this.chartZDCLog.Series.Add(series3);
            this.chartZDCLog.Series.Add(series4);
            this.chartZDCLog.Size = new System.Drawing.Size(1244, 240);
            this.chartZDCLog.TabIndex = 7;
            this.chartZDCLog.Text = "chartZDCLog";
            this.chartZDCLog.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            // 
            // chartZDC
            // 
            chartArea2.AxisX.LabelStyle.Format = "0.000";
            chartArea2.AxisX.Title = "Wave number";
            chartArea2.AxisY.LabelStyle.Format = "0.000";
            chartArea2.AxisY.Title = "P (Lg)";
            chartArea2.Name = "ChartArea1";
            this.chartZDC.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartZDC.Legends.Add(legend2);
            this.chartZDC.Location = new System.Drawing.Point(6, 33);
            this.chartZDC.Name = "chartZDC";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Experemental Probabilities";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Teoretical Probabilities";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Through Probabilities";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Crest Probabilities";
            series8.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chartZDC.Series.Add(series5);
            this.chartZDC.Series.Add(series6);
            this.chartZDC.Series.Add(series7);
            this.chartZDC.Series.Add(series8);
            this.chartZDC.Size = new System.Drawing.Size(1244, 240);
            this.chartZDC.TabIndex = 6;
            this.chartZDC.Text = "chartZDCLog";
            this.chartZDC.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            this.chartZDC.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            this.chartZDC.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chartZUC.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            this.chartZUC.MouseLeave += new System.EventHandler(this.chart_MouseLeave); 
            this.chartZDCLog.MouseLeave += new System.EventHandler(this.chart_MouseLeave); 
            this.chartZUCLog.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chartZDCLog.MouseEnter += new System.EventHandler(this.chart_MouseEnter); 
            this.chartZUCLog.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartZUCLog);
            this.tabPage2.Controls.Add(this.chartZUC);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartZUCLog
            // 
            chartArea3.AxisX.LabelStyle.Format = "0.000";
            chartArea3.AxisX.Title = "Wave number";
            chartArea3.AxisY.LabelStyle.Format = "0.000";
            chartArea3.AxisY.Title = "P";
            chartArea3.Name = "ChartArea1";
            this.chartZUCLog.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartZUCLog.Legends.Add(legend3);
            this.chartZUCLog.Location = new System.Drawing.Point(0, 268);
            this.chartZUCLog.Name = "chartZUCLog";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Experemental Probabilities";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Teoretical Probabilities";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Through Probabilities";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Crest Probabilities";
            series12.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chartZUCLog.Series.Add(series9);
            this.chartZUCLog.Series.Add(series10);
            this.chartZUCLog.Series.Add(series11);
            this.chartZUCLog.Series.Add(series12);
            this.chartZUCLog.Size = new System.Drawing.Size(1244, 240);
            this.chartZUCLog.TabIndex = 9;
            this.chartZUCLog.Text = "chart1";
            this.chartZUCLog.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            // 
            // chartZUC
            // 
            chartArea4.AxisX.LabelStyle.Format = "0.000";
            chartArea4.AxisX.Title = "Wave number";
            chartArea4.AxisY.LabelStyle.Format = "0.000";
            chartArea4.AxisY.Title = "P (Lg)";
            chartArea4.Name = "ChartArea1";
            this.chartZUC.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartZUC.Legends.Add(legend4);
            this.chartZUC.Location = new System.Drawing.Point(0, 32);
            this.chartZUC.Name = "chartZUC";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Experemental Probabilities";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Teoretical Probabilities";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Through Probabilities";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Crest Probabilities";
            series16.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chartZUC.Series.Add(series13);
            this.chartZUC.Series.Add(series14);
            this.chartZUC.Series.Add(series15);
            this.chartZUC.Series.Add(series16);
            this.chartZUC.Size = new System.Drawing.Size(1244, 240);
            this.chartZUC.TabIndex = 8;
            this.chartZUC.Text = "chartZUC";
            this.chartZUC.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1276, 25);
            this.toolStrip1.TabIndex = 2;
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
            // CProbabilitiesDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1276, 590);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControlProb);
            this.Name = "CProbabilitiesDiagram";
            this.Text = "HeightsProbabilities";
            this.tabControlProb.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartZDCLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZDC)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartZUCLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUC)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZDCLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZDC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZUCLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZUC;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImagesToolStripMenuItem;
    }
}