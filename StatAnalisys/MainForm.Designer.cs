using System.Windows.Forms.DataVisualization.Charting;
using System;

namespace StatAnalisys
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
         protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 
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
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.chartGeneralGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxNumWave = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.labelT = new System.Windows.Forms.Label();
            this.textBoxAmplitudeMinus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAmplitude = new System.Windows.Forms.Label();
            this.textBoxAmplitudePlus = new System.Windows.Forms.TextBox();
            this.labelCurrentWave = new System.Windows.Forms.Label();
            this.panelGraphic = new System.Windows.Forms.Panel();
            this.checkBoxProbabilitiesDiagram = new System.Windows.Forms.CheckBox();
            this.checkBoxHeightsDiagram = new System.Windows.Forms.CheckBox();
            this.labelGraphic = new System.Windows.Forms.Label();
            this.chartZommedWave = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.chartWavesPeriods = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelIntervalsPeriod = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralGraphic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZommedWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWavesPeriods)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveImagesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveImagesToolStripMenuItem
            // 
            this.saveImagesToolStripMenuItem.Name = "saveImagesToolStripMenuItem";
            this.saveImagesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveImagesToolStripMenuItem.Text = "Save Images";
            this.saveImagesToolStripMenuItem.Click += new System.EventHandler(this.saveImagesToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "MAT-files|*.mat|All files|*.*";
            this.openFileDialog.Title = "Select a MAT-file";
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.Location = new System.Drawing.Point(12, 176);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(451, 247);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // chartGeneralGraphic
            // 
            this.chartGeneralGraphic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.AxisX.LabelStyle.Format = "0.000";
            chartArea1.AxisX.Title = "t";
            chartArea1.AxisY.LabelStyle.Format = "0.000";
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = -5D;
            chartArea1.AxisY.Title = "h";
            chartArea1.CursorY.Interval = 0.5D;
            chartArea1.Name = "ChartArea1";
            this.chartGeneralGraphic.ChartAreas.Add(chartArea1);
            this.chartGeneralGraphic.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartGeneralGraphic.Legends.Add(legend1);
            this.chartGeneralGraphic.Location = new System.Drawing.Point(12, 48);
            this.chartGeneralGraphic.Name = "chartGeneralGraphic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Wave";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Troughs & Ridges";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Hightlighted Wave";
            this.chartGeneralGraphic.Series.Add(series1);
            this.chartGeneralGraphic.Series.Add(series2);
            this.chartGeneralGraphic.Series.Add(series3);
            this.chartGeneralGraphic.Size = new System.Drawing.Size(1039, 318);
            this.chartGeneralGraphic.TabIndex = 1;
            this.chartGeneralGraphic.Text = "Chart Wave";
            this.chartGeneralGraphic.MouseEnter += new System.EventHandler(chart_MouseEnter);
            this.chartGeneralGraphic.MouseLeave += new System.EventHandler(chart_MouseLeave);
            this.chartGeneralGraphic.MouseWheel += new System.Windows.Forms.MouseEventHandler(chart_MouseWheel); 
            this.chartGeneralGraphic.AxisViewChanging += new System.EventHandler<ViewEventArgs>(this.chartGeneralGraphic_AxisViewChanging);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelGraphic);
            this.panel1.Location = new System.Drawing.Point(1057, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 383);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCalculate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBoxNumWave);
            this.panel3.Location = new System.Drawing.Point(3, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 76);
            this.panel3.TabIndex = 17;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(17, 44);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select wave";
            // 
            // comboBoxNumWave
            // 
            this.comboBoxNumWave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumWave.FormattingEnabled = true;
            this.comboBoxNumWave.Location = new System.Drawing.Point(17, 16);
            this.comboBoxNumWave.Name = "comboBoxNumWave";
            this.comboBoxNumWave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxNumWave.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumWave.TabIndex = 0;
            this.comboBoxNumWave.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumWave_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.textBoxType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxT);
            this.panel2.Controls.Add(this.labelT);
            this.panel2.Controls.Add(this.textBoxAmplitudeMinus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelAmplitude);
            this.panel2.Controls.Add(this.textBoxAmplitudePlus);
            this.panel2.Controls.Add(this.labelCurrentWave);
            this.panel2.Location = new System.Drawing.Point(3, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 208);
            this.panel2.TabIndex = 4;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(38, 168);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(38, 112);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 20);
            this.textBoxT.TabIndex = 13;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(14, 96);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(14, 13);
            this.labelT.TabIndex = 12;
            this.labelT.Text = "T";
            // 
            // textBoxAmplitudeMinus
            // 
            this.textBoxAmplitudeMinus.Location = new System.Drawing.Point(38, 63);
            this.textBoxAmplitudeMinus.Name = "textBoxAmplitudeMinus";
            this.textBoxAmplitudeMinus.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmplitudeMinus.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "+";
            // 
            // labelAmplitude
            // 
            this.labelAmplitude.AutoSize = true;
            this.labelAmplitude.Location = new System.Drawing.Point(14, 18);
            this.labelAmplitude.Name = "labelAmplitude";
            this.labelAmplitude.Size = new System.Drawing.Size(53, 13);
            this.labelAmplitude.TabIndex = 7;
            this.labelAmplitude.Text = "Amplitude";
            // 
            // textBoxAmplitudePlus
            // 
            this.textBoxAmplitudePlus.Location = new System.Drawing.Point(38, 34);
            this.textBoxAmplitudePlus.Name = "textBoxAmplitudePlus";
            this.textBoxAmplitudePlus.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmplitudePlus.TabIndex = 6;
            // 
            // labelCurrentWave
            // 
            this.labelCurrentWave.AutoSize = true;
            this.labelCurrentWave.Location = new System.Drawing.Point(14, 0);
            this.labelCurrentWave.Name = "labelCurrentWave";
            this.labelCurrentWave.Size = new System.Drawing.Size(70, 13);
            this.labelCurrentWave.TabIndex = 5;
            this.labelCurrentWave.Text = "Current wave";
            // 
            // panelGraphic
            // 
            this.panelGraphic.Controls.Add(this.checkBoxProbabilitiesDiagram);
            this.panelGraphic.Controls.Add(this.checkBoxHeightsDiagram);
            this.panelGraphic.Controls.Add(this.labelGraphic);
            this.panelGraphic.Location = new System.Drawing.Point(3, 96);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(193, 62);
            this.panelGraphic.TabIndex = 2;
            // 
            // checkBoxProbabilitiesDiagram
            // 
            this.checkBoxProbabilitiesDiagram.AutoSize = true;
            this.checkBoxProbabilitiesDiagram.Location = new System.Drawing.Point(17, 39);
            this.checkBoxProbabilitiesDiagram.Name = "checkBoxProbabilitiesDiagram";
            this.checkBoxProbabilitiesDiagram.Size = new System.Drawing.Size(124, 17);
            this.checkBoxProbabilitiesDiagram.TabIndex = 6;
            this.checkBoxProbabilitiesDiagram.Text = "Probabilities Diagram";
            this.checkBoxProbabilitiesDiagram.UseVisualStyleBackColor = true;
            this.checkBoxProbabilitiesDiagram.CheckedChanged += new System.EventHandler(this.checkBoxProbabilitiesDiagram_CheckedChanged);
            // 
            // checkBoxHeightsDiagram
            // 
            this.checkBoxHeightsDiagram.AutoSize = true;
            this.checkBoxHeightsDiagram.Location = new System.Drawing.Point(17, 16);
            this.checkBoxHeightsDiagram.Name = "checkBoxHeightsDiagram";
            this.checkBoxHeightsDiagram.Size = new System.Drawing.Size(104, 17);
            this.checkBoxHeightsDiagram.TabIndex = 5;
            this.checkBoxHeightsDiagram.Text = "Heights Diagram";
            this.checkBoxHeightsDiagram.UseVisualStyleBackColor = true;
            this.checkBoxHeightsDiagram.CheckedChanged += new System.EventHandler(this.checkBoxHeightsDiagram_CheckedChanged);
            // 
            // labelGraphic
            // 
            this.labelGraphic.AutoSize = true;
            this.labelGraphic.Location = new System.Drawing.Point(14, 0);
            this.labelGraphic.Name = "labelGraphic";
            this.labelGraphic.Size = new System.Drawing.Size(98, 13);
            this.labelGraphic.TabIndex = 4;
            this.labelGraphic.Text = "Additional Graphics";
            // 
            // chartZommedWave
            // 
            this.chartZommedWave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartAreaSelectedWave";
            this.chartZommedWave.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartZommedWave.Legends.Add(legend2);
            this.chartZommedWave.Location = new System.Drawing.Point(12, 33);
            this.chartZommedWave.Name = "chartZommedWave";
            series4.ChartArea = "ChartAreaSelectedWave";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Current selected wave";
            series5.ChartArea = "ChartAreaSelectedWave";
            series5.Legend = "Legend1";
            series5.Name = "Amplitudes";
            series6.ChartArea = "ChartAreaSelectedWave";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series6.Legend = "Legend1";
            series6.Name = "T";
            series7.ChartArea = "ChartAreaSelectedWave";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series7.Legend = "Legend1";
            series7.Name = "H";
            this.chartZommedWave.Series.Add(series4);
            this.chartZommedWave.Series.Add(series5);
            this.chartZommedWave.Series.Add(series6);
            this.chartZommedWave.Series.Add(series7);
            this.chartZommedWave.Size = new System.Drawing.Size(390, 182);
            this.chartZommedWave.TabIndex = 3;
            this.chartZommedWave.Text = "Chart Zommed Wave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selected wave";
            // 
            // chartWavesPeriods
            // 
            this.chartWavesPeriods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea3.Name = "ChartArea1";
            this.chartWavesPeriods.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartWavesPeriods.Legends.Add(legend3);
            this.chartWavesPeriods.Location = new System.Drawing.Point(12, 398);
            this.chartWavesPeriods.Name = "chartWavesPeriods";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series8.Legend = "Legend1";
            series8.Name = "T";
            this.chartWavesPeriods.Series.Add(series8);
            this.chartWavesPeriods.Size = new System.Drawing.Size(821, 230);
            this.chartWavesPeriods.TabIndex = 5;
            this.chartWavesPeriods.Text = "Chart Periods";
            // 
            // labelIntervalsPeriod
            // 
            this.labelIntervalsPeriod.AutoSize = true;
            this.labelIntervalsPeriod.Location = new System.Drawing.Point(12, 382);
            this.labelIntervalsPeriod.Name = "labelIntervalsPeriod";
            this.labelIntervalsPeriod.Size = new System.Drawing.Size(119, 13);
            this.labelIntervalsPeriod.TabIndex = 6;
            this.labelIntervalsPeriod.Text = "Chart of Waves Periods";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.chartZommedWave);
            this.panel4.Location = new System.Drawing.Point(855, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 230);
            this.panel4.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Wave";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 640);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelIntervalsPeriod);
            this.Controls.Add(this.chartWavesPeriods);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartGeneralGraphic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Waves";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralGraphic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelGraphic.ResumeLayout(false);
            this.panelGraphic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZommedWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWavesPeriods)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneralGraphic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxNumWave;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Panel panelGraphic;
        private System.Windows.Forms.Label labelGraphic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.TextBox textBoxAmplitudeMinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAmplitude;
        private System.Windows.Forms.TextBox textBoxAmplitudePlus;
        private System.Windows.Forms.Label labelCurrentWave;
        private System.Windows.Forms.ToolStripMenuItem saveImagesToolStripMenuItem;
        private Chart chartZommedWave;
        private System.Windows.Forms.Label label5;
        private Chart chartWavesPeriods;
        private System.Windows.Forms.Label labelIntervalsPeriod;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxProbabilitiesDiagram;
        private System.Windows.Forms.CheckBox checkBoxHeightsDiagram;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
    }
}

