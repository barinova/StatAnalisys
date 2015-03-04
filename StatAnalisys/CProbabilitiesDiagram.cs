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
        public CProbabilitiesDiagram()
        {
            InitializeComponent();

            chartZUC.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chartZDC.ChartAreas[0].AxisX.ScrollBar.Enabled = true; 
            chartZUCLog.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chartZDCLog.ChartAreas[0].AxisX.ScrollBar.Enabled = true; 
            tabControlProb.TabPages[0].Text = "-down-zero-crossings";
            tabControlProb.TabPages[1].Text = "-up-zero-crossings";

            chartZDC.Series[0].Color = Color.DarkOrange;
            chartZDCLog.Series[0].Color = Color.DarkOrange;
            chartZDC.Series[1].Color = Color.RoyalBlue;
            chartZDCLog.Series[1].Color = Color.RoyalBlue;
            chartZDC.Series[2].Color = Color.Green;
            chartZDCLog.Series[2].Color = Color.Green;
            chartZDC.Series[3].Color = Color.Violet;
            chartZDCLog.Series[3].Color = Color.Violet;
            
            chartZUC.Series[0].Color = Color.DarkOrange;
            chartZUCLog.Series[0].Color = Color.DarkOrange;
            chartZUC.Series[1].Color = Color.RoyalBlue;
            chartZUCLog.Series[1].Color = Color.RoyalBlue;
            chartZUC.Series[2].Color = Color.Green;
            chartZUCLog.Series[2].Color = Color.Green;
            chartZUC.Series[3].Color = Color.Violet;
            chartZUCLog.Series[3].Color = Color.Violet;

            setupMarkStyle(chartZDC, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, 2, Color.Black);
            setupMarkStyle(chartZDCLog, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, 2, Color.Black);
            setupMarkStyle(chartZUC, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, 2, Color.Black);
            setupMarkStyle(chartZUCLog, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, 2, Color.Black);
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

        public void renderProbabilities(typeCrossing type, List<probability> listProb)
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

            drawPChart(listProb, chart, chartLog);
        }

        void drawPChart(List<probability> listProb, Chart chart, Chart chartLog)
        {
            probability prob;

            for (int i = 0; i < listProb.Count(); i++)
            {
                prob = listProb[i];

                chart.Series[0].Points.AddXY(prob.H, prob.experP);
                chart.Series[1].Points.AddXY(prob.H, prob.teorP);
                chart.Series[2].Points.AddXY(prob.H, prob.crestP);
                chart.Series[3].Points.AddXY(prob.H, prob.troughP);

                chartLog.Series[0].Points.AddXY(prob.H, Math.Log10(prob.experP));
                chartLog.Series[1].Points.AddXY(prob.H, Math.Log10(prob.teorP));
                chartLog.Series[2].Points.AddXY(prob.H, Math.Log10(prob.crestP));
                chartLog.Series[3].Points.AddXY(prob.H, Math.Log10(prob.troughP));
            }
        }

        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage(new Chart[] { chartZDC, chartZDCLog, chartZUC, chartZUCLog });
        }

    }

}
