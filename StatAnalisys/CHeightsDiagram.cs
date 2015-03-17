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
        public CHeightsDiagram()
        {
            InitializeComponent();

            chartZDCHeights.Series[0]["PixelPointWidth"] = "1";
            chartZUCHeights.Series[0]["PixelPointWidth"] = "1";
            chartZDCHeights.Series[0].Color = Color.Red;
            chartZUCHeights.Series[0].Color = Color.Red;
            chartZDCHeights.Series[1].Color = Color.Orange;
            chartZUCHeights.Series[1].Color = Color.Orange; 
            chartZDCHeights.Series[2].Color = Color.Lime;
            chartZUCHeights.Series[2].Color = Color.Lime;
            chartZDCHeights.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chartZUCHeights.ChartAreas[0].AxisX.ScrollBar.Enabled = true; 
            chartZDCHeights.Series[0].Font = new Font("Arial", 7);
            chartZUCHeights.Series[0].Font = new Font("Arial", 7);
        }

        private void highlightRougeWave(Chart chart, int x, double y)
        {
            chart.Series[0].Points[x].Color = Color.DarkViolet;
        }

        public void renderHeights(double listHeightsZDCThird, double listHeightsZDCSign, double listHeightsZUCThird,
            double listHeightsZUCSign, List<double> listHeihtsZDC, List<double> listHeihtsZUC)
        {
            int indX;
            double HHSingnZDC = 2*listHeightsZDCSign;
            double HHSingnZUC = 2*listHeightsZUCSign;

            foreach (var h in listHeihtsZDC)
            {
                indX = chartZDCHeights.Series[0].Points.AddY(h);
                chartZDCHeights.Series[0].Points[indX].Label = Math.Round(h, 3).ToString();

                if (h > HHSingnZDC)
                {
                    highlightRougeWave(chartZDCHeights, indX, h);
                }
            }

            foreach (var h in listHeihtsZUC)
            {
                indX = chartZUCHeights.Series[0].Points.AddY(h);
                chartZUCHeights.Series[0].Points[indX].Label = Math.Round(h, 3).ToString(); 

                if (h > HHSingnZUC)
                {
                    highlightRougeWave(chartZUCHeights, indX, h);
                }
            }

            drawStripLine(chartZDCHeights, listHeightsZDCSign, Color.Orange);
            drawStripLine(chartZDCHeights, listHeightsZDCThird, Color.Lime);
            drawStripLine(chartZDCHeights, 2*listHeightsZDCSign, Color.Aqua);
            drawStripLine(chartZUCHeights, listHeightsZUCSign, Color.Orange);
            drawStripLine(chartZUCHeights, listHeightsZUCThird, Color.Lime);
            drawStripLine(chartZUCHeights, 2 * listHeightsZUCSign, Color.Aqua);

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

            /*
            TextAnnotation text = new TextAnnotation();
            text.X = 130;
            text.Y = 1;
            text.Text = str; 
            text.AnchorDataPoint = chart.Series[0].Points[3];
            chart.Annotations.Add(text);*/
        }

        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage(new Chart[] { chartZUCHeights, chartZDCHeights});
        }
    }
}
