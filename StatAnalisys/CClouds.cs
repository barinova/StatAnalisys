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
    public partial class CClouds : BaseForm
    {
        public CClouds()
        {
            InitializeComponent();

            setZoomable(chartCloudsZDCHor);
            setZoomable(chartCloudsZDCVert);
            setZoomable(chartCloudsZUCHor);
            setZoomable(chartCloudsZUCVert);
        }

        private void setZoomable(Chart chart)
        {
            chart.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            chart.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            chart.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
        }


        public void renderClouds(double hThrZDC, double hThrZUC, List<waveData> waves)
        {
            double x, y;

            foreach (waveData wave in waves)
            { 
                switch (wave.type)
                {
                    case typeCrossing.ZDC:
                        x = wave.totalHeight / hThrZDC;
                        y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry));
                        chartCloudsZDCVert.Series[0].Points.AddXY(x, y);
                        y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry));
                        chartCloudsZDCHor.Series[0].Points.AddXY(x, y);
                        break;

                    case typeCrossing.ZUC:
                        x = wave.totalHeight / hThrZUC;
                        y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry));
                        chartCloudsZUCVert.Series[0].Points.AddXY(x, y);
                        y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry));
                        chartCloudsZUCHor.Series[0].Points.AddXY(x, y);
                        break;
                }
            }
        }

        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveImagesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveImage(new Chart[] { chartCloudsZDCVert, chartCloudsZDCHor, chartCloudsZUCVert, chartCloudsZUCHor});
        }
    }
}
