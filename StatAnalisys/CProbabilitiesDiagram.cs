using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StatAnalisys
{
    public partial class CProbabilitiesDiagram : BaseForm
    {
        public CProbabilitiesDiagram(string indexWave)
        {
            InitializeComponent();

            labelIndexWave.Text = "Wave № " + indexWave;

            chartZUCLog.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chartZDCLog.ChartAreas[0].AxisX.ScrollBar.Enabled = true; 
            chartZUC.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chartZDC.ChartAreas[0].AxisX.ScrollBar.Enabled = true; 
            tabControlProb.TabPages[0].Text = "-down-zero-crossings";
            tabControlProb.TabPages[1].Text = "-up-zero-crossings";

            chartZDCLog.Series[0].BorderDashStyle = ChartDashStyle.Dash;
            chartZDC.Series[0].BorderDashStyle = ChartDashStyle.Dash;
            chartZDCLog.Series[1].BorderDashStyle = ChartDashStyle.DashDot;
            chartZDC.Series[1].BorderDashStyle = ChartDashStyle.DashDot;
            chartZDCLog.Series[2].BorderDashStyle = ChartDashStyle.DashDot;
            chartZDC.Series[2].BorderDashStyle = ChartDashStyle.DashDot;
            chartZDCLog.Series[3].BorderDashStyle = ChartDashStyle.DashDot;
            chartZDC.Series[3].BorderDashStyle = ChartDashStyle.DashDot;

            chartZUCLog.Series[0].BorderDashStyle = ChartDashStyle.Dash;
            chartZUC.Series[0].BorderDashStyle = ChartDashStyle.Dash;
            chartZUCLog.Series[1].BorderDashStyle = ChartDashStyle.DashDot;
            chartZUC.Series[1].BorderDashStyle = ChartDashStyle.DashDot;
            chartZUCLog.Series[2].BorderDashStyle = ChartDashStyle.DashDot;
            chartZUC.Series[2].BorderDashStyle = ChartDashStyle.DashDot;
            chartZUCLog.Series[3].BorderDashStyle = ChartDashStyle.DashDot;
            chartZUC.Series[3].BorderDashStyle = ChartDashStyle.DashDot;

            setupMarkStyle(chartZDCLog, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, 2, Color.Black);
            setupMarkStyle(chartZDC, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, 2, Color.Black);
            setupMarkStyle(chartZUCLog, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, 2, Color.Black);
            setupMarkStyle(chartZUC, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, 2, Color.Black);

            this.chartZDCLog.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            this.chartZDCLog.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chartZUCLog.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            this.chartZUCLog.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chartZDC.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chartZUC.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chartZDC.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            this.chartZUC.MouseEnter += new System.EventHandler(this.chart_MouseEnter); 
            this.chartZDCLog.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            this.chartZUCLog.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            this.chartZDC.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            this.chartZUC.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
        }

        void setupMarkStyle(Chart chart, MarkerStyle style, int size, Color color)
        {
            foreach (Series s in chart.Series)
            {
                s.MarkerStyle = style;
                s.MarkerSize = size;
                s.MarkerColor = color;
            }
        }

        public void renderProbabilities(typeCrossing type, List<probability> listProb, double signH)
        {
            Chart chart, chartLog;

            if (type == typeCrossing.ZDC)
            {
                chart = chartZDC;
                chartLog = chartZDCLog;
            }
            else
            {
                chart = chartZUC;
                chartLog = chartZUCLog;
            }

            drawPChart(listProb, chart, chartLog, signH);
        }

        void drawPChart(List<probability> listProb, Chart chart, Chart chartLog, double signH)
        {
            probability prob;

            for (int i = 0; i < listProb.Count(); i++)
            {
                prob = listProb[i];

                chart.Series[0].Points.AddXY(prob.H / signH, prob.experP);
                chart.Series[1].Points.AddXY(prob.H / signH, prob.teorP);
                chart.Series[2].Points.AddXY(prob.H / signH, prob.crestP);
                chart.Series[3].Points.AddXY(prob.H / signH, prob.troughP);

                chartLog.Series[0].Points.AddXY(prob.H / signH, Math.Log10(prob.experP));
                chartLog.Series[1].Points.AddXY(prob.H / signH, Math.Log10(prob.teorP));
                chartLog.Series[2].Points.AddXY(prob.H / signH, Math.Log10(prob.crestP));
                chartLog.Series[3].Points.AddXY(prob.H / signH, Math.Log10(prob.troughP));
            }
        }

        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage(new Chart[] { chartZDCLog, chartZDC, chartZUCLog, chartZUC });
        }


    }

}
