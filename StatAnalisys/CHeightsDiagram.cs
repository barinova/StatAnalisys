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
    public partial class CHeightsDiagram : BaseForm
    {
        public CHeightsDiagram(string indexWave)
        {
            InitializeComponent();

            labelNumWave.Text = "Wave № " + indexWave;
            chartZDCHeights.Series[0]["PixelPointWidth"] = "1";
            chartZUCHeights.Series[0]["PixelPointWidth"] = "1";
            chartZDCHeights.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chartZUCHeights.ChartAreas[0].AxisX.ScrollBar.Enabled = true; 
            chartZDCHeights.Series[0].Font = new Font("Arial", 7);
            chartZUCHeights.Series[0].Font = new Font("Arial", 7);
            chartZUCHeights.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartZUCHeights.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartZUCHeights.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartZDCHeights.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartZDCHeights.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartZDCHeights.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
        }

        private void highlightRougeWave(Chart chart, int x, double y)
        {
            chart.Series[4].Points.AddXY(x, y);
        }

        public void renderHeights(double listHeightsZDCThird, double listHeightsZDCSign, double listHeightsZUCThird,
            double listHeightsZUCSign, List<double> listHeihtsZDC, List<double> listHeihtsZUC)
        {
            int indX, x = 0;
            double HHSingnZDC = 2*listHeightsZDCSign;
            double HHSingnZUC = 2*listHeightsZUCSign;
            double maxHZUC = HHSingnZUC;
            double maxHZDC = HHSingnZDC;

            foreach (var h in listHeihtsZDC)
            {
                indX = chartZDCHeights.Series[0].Points.AddXY(x, h);
                chartZDCHeights.Series[0].Points[indX].Label = Math.Round(h, 3).ToString();
                x++;

                if (h > HHSingnZDC)
                {
                    if (h > maxHZDC) maxHZDC = h;
                    highlightRougeWave(chartZDCHeights, indX, h);
                }
            }

            x = 0;

            foreach (var h in listHeihtsZUC)
            {
                indX = chartZUCHeights.Series[0].Points.AddXY(x, h);
                chartZUCHeights.Series[0].Points[indX].Label = Math.Round(h, 3).ToString();
                x++;
                if (h > HHSingnZUC)
                {
                    if (h > maxHZUC) maxHZUC = h;
                    highlightRougeWave(chartZUCHeights, indX, h);
                }
            }

            drawStripLine(chartZDCHeights, listHeightsZDCSign, Color.Green, 0.1);
            drawStripLine(chartZDCHeights, listHeightsZDCThird, Color.FromArgb(255, 128, 0), 0.1);
            drawStripLine(chartZDCHeights, HHSingnZDC, Color.DodgerBlue, 0.1);
            drawStripLine(chartZUCHeights, listHeightsZUCSign, Color.Green, 0.1);
            drawStripLine(chartZUCHeights, listHeightsZUCThird, Color.FromArgb(255, 128, 0), 0.1);
            drawStripLine(chartZUCHeights, HHSingnZUC, Color.DodgerBlue, 0.1);

            chartZDCHeights.ChartAreas[0].AxisY.Maximum = Math.Floor(HHSingnZDC) + 2;
            chartZUCHeights.ChartAreas[0].AxisY.Maximum = Math.Floor(HHSingnZUC) + 2;

            setAnnotation(chartZUCHeights, "Height of one third = " + Math.Round(listHeightsZUCThird, 7).ToString()
                + "\nSignificiant height = " +  Math.Round(listHeightsZUCSign, 8).ToString()
                + "\n2 * Significiant height = " + Math.Round(2 * listHeightsZUCSign, 7).ToString());
            setAnnotation(chartZDCHeights, "Heights of one third = " +  Math.Round(listHeightsZDCThird, 7).ToString()
                + "\nSignificiant height = " + Math.Round(listHeightsZDCSign, 8).ToString()
                + "\n2 * Significiant height = " + Math.Round(2 * listHeightsZDCSign, 7).ToString());
        }


        private void setAnnotation(Chart chart, string str)
        {
            Series s = new Series();
            s.Name = str;
            s.ChartType = SeriesChartType.Point;
            chart.Series.Add(s);
        }

        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage(new Chart[] { chartZUCHeights, chartZDCHeights});
        }
    }
}
