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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.chartGeneralGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelZoom = new System.Windows.Forms.Label();
            this.buttonZoomReset = new System.Windows.Forms.Button();
            this.panelGraphic = new System.Windows.Forms.Panel();
            this.labelGraphic = new System.Windows.Forms.Label();
            this.buttonOpenGraphic = new System.Windows.Forms.Button();
            this.comboBoxGraphic = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.comboBoxNumWave = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralGraphic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGraphic.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
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
            chartArea2.AxisX.LabelStyle.Format = "0.000";
            chartArea2.AxisX.Title = "t";
            chartArea2.AxisY.LabelStyle.Format = "0.000";
            chartArea2.AxisY.Maximum = 5D;
            chartArea2.AxisY.Minimum = -5D;
            chartArea2.AxisY.Title = "h";
            chartArea2.CursorY.Interval = 0.5D;
            chartArea2.Name = "ChartArea1";
            this.chartGeneralGraphic.ChartAreas.Add(chartArea2);
            this.chartGeneralGraphic.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.chartGeneralGraphic.Legends.Add(legend2);
            this.chartGeneralGraphic.Location = new System.Drawing.Point(12, 48);
            this.chartGeneralGraphic.Name = "chartGeneralGraphic";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Wave";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chartGeneralGraphic.Series.Add(series3);
            this.chartGeneralGraphic.Series.Add(series4);
            this.chartGeneralGraphic.Size = new System.Drawing.Size(1072, 590);
            this.chartGeneralGraphic.TabIndex = 1;
            this.chartGeneralGraphic.Text = "Wave";
            this.chartGeneralGraphic.MouseEnter += new System.EventHandler(this.chartGeneralGraphic_MouseEnter);
            this.chartGeneralGraphic.MouseLeave += new System.EventHandler(this.chartGeneralGraphic_MouseLeave);
            this.chartGeneralGraphic.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chartGeneralGraphic_MouseWheel);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelGraphic);
            this.panel1.Controls.Add(this.buttonCalculate);
            this.panel1.Controls.Add(this.comboBoxNumWave);
            this.panel1.Location = new System.Drawing.Point(1090, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 590);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelZoom);
            this.panel2.Controls.Add(this.buttonZoomReset);
            this.panel2.Location = new System.Drawing.Point(25, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 88);
            this.panel2.TabIndex = 4;
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(14, 0);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(34, 13);
            this.labelZoom.TabIndex = 5;
            this.labelZoom.Text = "Zoom";
            // 
            // buttonZoomReset
            // 
            this.buttonZoomReset.Location = new System.Drawing.Point(17, 25);
            this.buttonZoomReset.Name = "buttonZoomReset";
            this.buttonZoomReset.Size = new System.Drawing.Size(75, 23);
            this.buttonZoomReset.TabIndex = 3;
            this.buttonZoomReset.Text = "Reset";
            this.buttonZoomReset.UseVisualStyleBackColor = true;
            this.buttonZoomReset.Click += new System.EventHandler(this.buttonZoomReset_Click);
            // 
            // panelGraphic
            // 
            this.panelGraphic.Controls.Add(this.labelGraphic);
            this.panelGraphic.Controls.Add(this.buttonOpenGraphic);
            this.panelGraphic.Controls.Add(this.comboBoxGraphic);
            this.panelGraphic.Location = new System.Drawing.Point(25, 250);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(155, 88);
            this.panelGraphic.TabIndex = 2;
            // 
            // labelGraphic
            // 
            this.labelGraphic.AutoSize = true;
            this.labelGraphic.Location = new System.Drawing.Point(14, 0);
            this.labelGraphic.Name = "labelGraphic";
            this.labelGraphic.Size = new System.Drawing.Size(44, 13);
            this.labelGraphic.TabIndex = 4;
            this.labelGraphic.Text = "Graphic";
            // 
            // buttonOpenGraphic
            // 
            this.buttonOpenGraphic.Location = new System.Drawing.Point(17, 53);
            this.buttonOpenGraphic.Name = "buttonOpenGraphic";
            this.buttonOpenGraphic.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenGraphic.TabIndex = 3;
            this.buttonOpenGraphic.Text = "Open";
            this.buttonOpenGraphic.UseVisualStyleBackColor = true;
            this.buttonOpenGraphic.Click += new System.EventHandler(this.buttonOpenGraphic_Click);
            // 
            // comboBoxGraphic
            // 
            this.comboBoxGraphic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGraphic.FormattingEnabled = true;
            this.comboBoxGraphic.Items.AddRange(new object[] {
            "Heights\' Diagram",
            "Probabilities\' Diagram"});
            this.comboBoxGraphic.Location = new System.Drawing.Point(17, 25);
            this.comboBoxGraphic.Name = "comboBoxGraphic";
            this.comboBoxGraphic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxGraphic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGraphic.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(24, 46);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // comboBoxNumWave
            // 
            this.comboBoxNumWave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumWave.FormattingEnabled = true;
            this.comboBoxNumWave.Location = new System.Drawing.Point(24, 18);
            this.comboBoxNumWave.Name = "comboBoxNumWave";
            this.comboBoxNumWave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxNumWave.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumWave.TabIndex = 0;
            this.comboBoxNumWave.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumWave_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartGeneralGraphic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Waves";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralGraphic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelGraphic.ResumeLayout(false);
            this.panelGraphic.PerformLayout();
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
        private System.Windows.Forms.Button buttonOpenGraphic;
        private System.Windows.Forms.ComboBox comboBoxGraphic;
        private System.Windows.Forms.Button buttonZoomReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelZoom;
    }
}

