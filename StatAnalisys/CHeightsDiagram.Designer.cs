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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartZDCHeights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartZUCHeights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHeightsThirdZDC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHeightsSighZDC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxHeightsThirdZUC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHeightsSighZUC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartZDCHeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUCHeights)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartZDCHeights
            // 
            chartArea1.Name = "ChartArea1";
            this.chartZDCHeights.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartZDCHeights.Legends.Add(legend1);
            this.chartZDCHeights.Location = new System.Drawing.Point(12, 44);
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
            this.chartZDCHeights.Size = new System.Drawing.Size(700, 200);
            this.chartZDCHeights.TabIndex = 0;
            this.chartZDCHeights.Text = "chartHeightsZDC";
            // 
            // chartZUCHeights
            // 
            chartArea2.Name = "ChartArea1";
            this.chartZUCHeights.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartZUCHeights.Legends.Add(legend2);
            this.chartZUCHeights.Location = new System.Drawing.Point(12, 298);
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
            this.chartZUCHeights.Size = new System.Drawing.Size(700, 200);
            this.chartZUCHeights.TabIndex = 1;
            this.chartZUCHeights.Text = "hartZUCHeights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "-down-zero-crossing Heights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-down-zero-crossing Heights";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxHeightsThirdZDC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxHeightsSighZDC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(720, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 110);
            this.panel1.TabIndex = 4;
            // 
            // textBoxHeightsThirdZDC
            // 
            this.textBoxHeightsThirdZDC.Location = new System.Drawing.Point(13, 76);
            this.textBoxHeightsThirdZDC.Name = "textBoxHeightsThirdZDC";
            this.textBoxHeightsThirdZDC.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightsThirdZDC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "height one third";
            // 
            // textBoxHeightsSighZDC
            // 
            this.textBoxHeightsSighZDC.Location = new System.Drawing.Point(13, 28);
            this.textBoxHeightsSighZDC.Name = "textBoxHeightsSighZDC";
            this.textBoxHeightsSighZDC.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightsSighZDC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "significant height";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxHeightsThirdZUC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxHeightsSighZUC);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(720, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 110);
            this.panel2.TabIndex = 5;
            // 
            // textBoxHeightsThirdZUC
            // 
            this.textBoxHeightsThirdZUC.Location = new System.Drawing.Point(13, 76);
            this.textBoxHeightsThirdZUC.Name = "textBoxHeightsThirdZUC";
            this.textBoxHeightsThirdZUC.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightsThirdZUC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "height one third";
            // 
            // textBoxHeightsSighZUC
            // 
            this.textBoxHeightsSighZUC.Location = new System.Drawing.Point(13, 28);
            this.textBoxHeightsSighZUC.Name = "textBoxHeightsSighZUC";
            this.textBoxHeightsSighZUC.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightsSighZUC.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "significant height";
            // 
            // CHeightsDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartZUCHeights);
            this.Controls.Add(this.chartZDCHeights);
            this.Name = "CHeightsDiagram";
            this.Text = "CSingleWaveDatas";
            ((System.ComponentModel.ISupportInitialize)(this.chartZDCHeights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZUCHeights)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartZDCHeights;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZUCHeights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxHeightsThirdZDC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHeightsSighZDC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxHeightsThirdZUC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHeightsSighZUC;
        private System.Windows.Forms.Label label6;
    }
}