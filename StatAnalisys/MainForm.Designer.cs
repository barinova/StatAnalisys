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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.toolTipSelectFile = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
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
            this.chartZommedWave = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelIntervalsPeriod = new System.Windows.Forms.Label();
            this.chartWavesPeriods = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxLoadFile = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonViewRogueWaves = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.panelGraphic = new System.Windows.Forms.Panel();
            this.buttonClouds = new System.Windows.Forms.Button();
            this.ProbabilitiesDiagram = new System.Windows.Forms.Button();
            this.buttonHeightsDiagram = new System.Windows.Forms.Button();
            this.labelGraphic = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNumWaves = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonNumWave = new System.Windows.Forms.Button();
            this.textBoxNumWave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chartGeneralGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXLSFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZommedWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWavesPeriods)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelGraphic.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralGraphic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // toolTipSelectFile
            // 
            this.toolTipSelectFile.ToolTipTitle = "Click to load for opening list of loaded files and select file ";
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
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.chartZommedWave);
            this.panel4.Location = new System.Drawing.Point(849, 432);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 210);
            this.panel4.TabIndex = 7;
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.panel2.Location = new System.Drawing.Point(241, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 118);
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
            this.textBoxT.Location = new System.Drawing.Point(33, 93);
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
            this.textBoxAmplitudeMinus.Location = new System.Drawing.Point(33, 56);
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
            this.textBoxAmplitudePlus.Location = new System.Drawing.Point(33, 34);
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
            // chartZommedWave
            // 
            this.chartZommedWave.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartAreaSelectedWave";
            this.chartZommedWave.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartZommedWave.Legends.Add(legend1);
            this.chartZommedWave.Location = new System.Drawing.Point(12, 23);
            this.chartZommedWave.Name = "chartZommedWave";
            series1.ChartArea = "ChartAreaSelectedWave";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Current selected wave";
            series2.ChartArea = "ChartAreaSelectedWave";
            series2.Legend = "Legend1";
            series2.Name = "Amplitudes";
            series3.ChartArea = "ChartAreaSelectedWave";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Legend = "Legend1";
            series3.Name = "T";
            series4.ChartArea = "ChartAreaSelectedWave";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series4.Legend = "Legend1";
            series4.Name = "H";
            this.chartZommedWave.Series.Add(series1);
            this.chartZommedWave.Series.Add(series2);
            this.chartZommedWave.Series.Add(series3);
            this.chartZommedWave.Series.Add(series4);
            this.chartZommedWave.Size = new System.Drawing.Size(390, 182);
            this.chartZommedWave.TabIndex = 3;
            this.chartZommedWave.Text = "Chart Zommed Wave";
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
            // chartWavesPeriods
            // 
            this.chartWavesPeriods.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chartWavesPeriods.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWavesPeriods.Legends.Add(legend2);
            this.chartWavesPeriods.Location = new System.Drawing.Point(12, 398);
            this.chartWavesPeriods.Name = "chartWavesPeriods";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series5.Legend = "Legend1";
            series5.Name = "T";
            this.chartWavesPeriods.Series.Add(series5);
            this.chartWavesPeriods.Size = new System.Drawing.Size(821, 230);
            this.chartWavesPeriods.TabIndex = 5;
            this.chartWavesPeriods.Text = "Chart Periods";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panelGraphic);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1060, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 399);
            this.panel1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxLoadFile);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.buttonLoadFile);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(5, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(191, 55);
            this.panel7.TabIndex = 19;
            // 
            // textBoxLoadFile
            // 
            this.textBoxLoadFile.AutoSize = true;
            this.textBoxLoadFile.Location = new System.Drawing.Point(15, 16);
            this.textBoxLoadFile.Name = "textBoxLoadFile";
            this.textBoxLoadFile.Size = new System.Drawing.Size(94, 13);
            this.textBoxLoadFile.TabIndex = 20;
            this.textBoxLoadFile.Text = "                             ";
            this.textBoxLoadFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 19;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(15, 32);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(62, 20);
            this.buttonLoadFile.TabIndex = 18;
            this.buttonLoadFile.Text = "Load";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Select file name";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.buttonCalculate);
            this.panel5.Location = new System.Drawing.Point(5, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 94);
            this.panel5.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Actions";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonViewRogueWaves);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(6, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 44);
            this.panel6.TabIndex = 7;
            // 
            // buttonViewRogueWaves
            // 
            this.buttonViewRogueWaves.Location = new System.Drawing.Point(20, 16);
            this.buttonViewRogueWaves.Name = "buttonViewRogueWaves";
            this.buttonViewRogueWaves.Size = new System.Drawing.Size(75, 23);
            this.buttonViewRogueWaves.TabIndex = 2;
            this.buttonViewRogueWaves.Text = "View";
            this.buttonViewRogueWaves.UseVisualStyleBackColor = true;
            this.buttonViewRogueWaves.Click += new System.EventHandler(this.buttonViewRougeWaves_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Click to view found rouge waves";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(6, 14);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(112, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Render heights";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // panelGraphic
            // 
            this.panelGraphic.Controls.Add(this.buttonClouds);
            this.panelGraphic.Controls.Add(this.ProbabilitiesDiagram);
            this.panelGraphic.Controls.Add(this.buttonHeightsDiagram);
            this.panelGraphic.Controls.Add(this.labelGraphic);
            this.panelGraphic.Location = new System.Drawing.Point(3, 189);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(193, 105);
            this.panelGraphic.TabIndex = 2;
            // 
            // buttonClouds
            // 
            this.buttonClouds.Location = new System.Drawing.Point(12, 80);
            this.buttonClouds.Name = "buttonClouds";
            this.buttonClouds.Size = new System.Drawing.Size(129, 23);
            this.buttonClouds.TabIndex = 9;
            this.buttonClouds.Text = "Clouds";
            this.buttonClouds.UseVisualStyleBackColor = true;
            this.buttonClouds.Click += new System.EventHandler(this.buttonClouds_Click);
            // 
            // ProbabilitiesDiagram
            // 
            this.ProbabilitiesDiagram.Location = new System.Drawing.Point(12, 45);
            this.ProbabilitiesDiagram.Name = "ProbabilitiesDiagram";
            this.ProbabilitiesDiagram.Size = new System.Drawing.Size(129, 29);
            this.ProbabilitiesDiagram.TabIndex = 8;
            this.ProbabilitiesDiagram.Text = "Probabilities Diagram";
            this.ProbabilitiesDiagram.UseVisualStyleBackColor = true;
            this.ProbabilitiesDiagram.Click += new System.EventHandler(this.ProbabilitiesDiagram_Click);
            // 
            // buttonHeightsDiagram
            // 
            this.buttonHeightsDiagram.Location = new System.Drawing.Point(12, 16);
            this.buttonHeightsDiagram.Name = "buttonHeightsDiagram";
            this.buttonHeightsDiagram.Size = new System.Drawing.Size(129, 23);
            this.buttonHeightsDiagram.TabIndex = 7;
            this.buttonHeightsDiagram.Text = "Heights Diagram";
            this.buttonHeightsDiagram.UseVisualStyleBackColor = true;
            this.buttonHeightsDiagram.Click += new System.EventHandler(this.buttonHeightsDiagram_Click);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.labelNumWaves);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.buttonNumWave);
            this.panel3.Controls.Add(this.textBoxNumWave);
            this.panel3.Location = new System.Drawing.Point(3, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 91);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelNumWaves
            // 
            this.labelNumWaves.AutoSize = true;
            this.labelNumWaves.Location = new System.Drawing.Point(20, 21);
            this.labelNumWaves.Name = "labelNumWaves";
            this.labelNumWaves.Size = new System.Drawing.Size(0, 13);
            this.labelNumWaves.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // buttonNumWave
            // 
            this.buttonNumWave.Location = new System.Drawing.Point(15, 63);
            this.buttonNumWave.Name = "buttonNumWave";
            this.buttonNumWave.Size = new System.Drawing.Size(62, 21);
            this.buttonNumWave.TabIndex = 18;
            this.buttonNumWave.Text = "Open";
            this.buttonNumWave.UseVisualStyleBackColor = true;
            this.buttonNumWave.Click += new System.EventHandler(this.buttonNumWave_Click);
            // 
            // textBoxNumWave
            // 
            this.textBoxNumWave.Location = new System.Drawing.Point(12, 37);
            this.textBoxNumWave.Name = "textBoxNumWave";
            this.textBoxNumWave.Size = new System.Drawing.Size(75, 20);
            this.textBoxNumWave.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter number of wave";
            // 
            // chartGeneralGraphic
            // 
            this.chartGeneralGraphic.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.AxisX.LabelStyle.Format = "0.000";
            chartArea3.AxisX.Title = "t";
            chartArea3.AxisY.LabelStyle.Format = "0.000";
            chartArea3.AxisY.Maximum = 5D;
            chartArea3.AxisY.Minimum = -5D;
            chartArea3.AxisY.Title = "h";
            chartArea3.CursorY.Interval = 0.5D;
            chartArea3.Name = "ChartArea1";
            this.chartGeneralGraphic.ChartAreas.Add(chartArea3);
            this.chartGeneralGraphic.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.Name = "Legend1";
            this.chartGeneralGraphic.Legends.Add(legend3);
            this.chartGeneralGraphic.Location = new System.Drawing.Point(15, 27);
            this.chartGeneralGraphic.Name = "chartGeneralGraphic";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Wave";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Troughs & Ridges";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Hightlighted Wave";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Orange;
            series9.Legend = "Legend1";
            series9.Name = "Rogue Waves";
            series9.YValuesPerPoint = 2;
            this.chartGeneralGraphic.Series.Add(series6);
            this.chartGeneralGraphic.Series.Add(series7);
            this.chartGeneralGraphic.Series.Add(series8);
            this.chartGeneralGraphic.Series.Add(series9);
            this.chartGeneralGraphic.Size = new System.Drawing.Size(1039, 379);
            this.chartGeneralGraphic.TabIndex = 1;
            this.chartGeneralGraphic.Text = "Chart Wave";
            this.chartGeneralGraphic.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.chartGeneralGraphic_SelectionRangeChanged);
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
            this.saveImagesToolStripMenuItem,
            this.saveXLSFileToolStripMenuItem,
            this.clearAllToolStripMenuItem});
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
            // saveXLSFileToolStripMenuItem
            // 
            this.saveXLSFileToolStripMenuItem.Name = "saveXLSFileToolStripMenuItem";
            this.saveXLSFileToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveXLSFileToolStripMenuItem.Text = "Save XLS file";
            this.saveXLSFileToolStripMenuItem.Click += new System.EventHandler(this.saveXLSFileToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZommedWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWavesPeriods)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelGraphic.ResumeLayout(false);
            this.panelGraphic.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralGraphic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonViewRogueWaves;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonHeightsDiagram;
        private System.Windows.Forms.Button ProbabilitiesDiagram;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonNumWave;
        private System.Windows.Forms.TextBox textBoxNumWave;
        private System.Windows.Forms.Label labelNumWaves;
        private System.Windows.Forms.Button buttonClouds;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label textBoxLoadFile;
        private System.Windows.Forms.ToolTip toolTipSelectFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem saveXLSFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    }
}

