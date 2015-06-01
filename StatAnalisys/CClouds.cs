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
        public CClouds(string indexWave)
        {
            InitializeComponent();

            labelNumWave.Text = "Wave № " + indexWave;

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


        public void renderClouds(double[][] zdcVert, double[][] zucVert, double[][] zdcHor, double[][] zucHor)
        {
            int count = zdcVert.Count();

            for (int i = 0; i < count; i++)
            {
                chartCloudsZDCVert.Series[0].Points.AddXY(zdcVert[i][0], zdcVert[i][1]);
                chartCloudsZDCHor.Series[0].Points.AddXY(zdcHor[i][0], zdcHor[i][1]);
                chartCloudsZUCVert.Series[0].Points.AddXY(zucVert[i][0], zucVert[i][1]);
                chartCloudsZUCHor.Series[0].Points.AddXY(zucHor[i][0], zucHor[i][1]);
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
