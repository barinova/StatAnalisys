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
    public partial class CHeightsDiagram : Form
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

        public void renderHeights(double listHeightsZDCThird, double listHeightsZDCSign, double listHeightsZUCThird,
            double listHeightsZUCSign, List<double> listHeihtsZDC, List<double> listHeihtsZUC)
        {
            int indX;
            foreach (var h in listHeihtsZDC)
            {
                indX = chartZDCHeights.Series[0].Points.AddY(h);
                chartZDCHeights.Series[0].Points[indX].Label = Math.Round(h, 3).ToString();
            }

            foreach (var h in listHeihtsZUC)
            {
                indX = chartZUCHeights.Series[0].Points.AddY(h);
                chartZUCHeights.Series[0].Points[indX].Label = Math.Round(h, 3).ToString();
            }

           /* textBoxHeightsThirdZDC.Text = listHeightsZDCThird.ToString();
            textBoxHeightsSighZDC.Text = listHeightsZDCSign.ToString();

            textBoxHeightsThirdZUC.Text = listHeightsZUCThird.ToString();
            textBoxHeightsSighZUC.Text = listHeightsZUCSign.ToString();
            */


            drawStripLine(chartZDCHeights, listHeightsZDCSign, Color.Orange);
            drawStripLine(chartZDCHeights, listHeightsZDCThird, Color.Lime);
            drawStripLine(chartZUCHeights, listHeightsZUCSign, Color.Orange);
            drawStripLine(chartZUCHeights, listHeightsZUCThird, Color.Lime);
            //chartZUCHeights.Series[1].Points.Add(listHeightsZUCSign);

            setAnnotation(chartZUCHeights, "Height of one third = " + Math.Round(listHeightsZUCThird, 7).ToString()
                + "\nSignificiant height = " +  Math.Round(listHeightsZUCSign, 8).ToString());
            setAnnotation(chartZDCHeights, "Heights of one third = " +  Math.Round(listHeightsZDCThird, 7).ToString()
                + "\nSignificiant height = " +  Math.Round(listHeightsZDCSign, 8).ToString());
        }
        private void drawStripLine(Chart chart, double y, Color color)
        {
            StripLine stripLine = new StripLine();
            stripLine.IntervalOffset = y;
            stripLine.BackColor = color;
            stripLine.StripWidth = 0.01;
            chart.ChartAreas[0].AxisY.StripLines.Add(stripLine);
        }

        private void setAnnotation(Chart chart, string str)
        {
            TextAnnotation text = new TextAnnotation();
            text.X = 130;
            text.Y = 1;
            text.Text = str; 
            text.AnchorDataPoint = chart.Series[0].Points[3];
            chart.Annotations.Add(text);
        }
        private void chartGeneralGraphic_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                Chart chart = (Chart)sender;
                MainForm.zoom(e, chart.ChartAreas[0], 2);
            }
            catch { }

        }

        private void chartZDCHeights_MouseLeave(object sender, EventArgs e)
        {
            if (chartZDCHeights.Focused)
                chartZDCHeights.Parent.Focus();
        }

        private void chartZDCHeights_MouseEnter(object sender, EventArgs e)
        {
            if (!chartZDCHeights.Focused)
                chartZDCHeights.Focus();
        }

        void chartZUCHeights_MouseLeave(object sender, EventArgs e)
        {
            if (chartZUCHeights.Focused)
                chartZUCHeights.Parent.Focus();
        }

        private void chartZUCHeights_MouseEnter(object sender, EventArgs e)
        {
            if (!chartZUCHeights.Focused)
                chartZUCHeights.Focus();
        }

        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Images.saveImage(new Chart[] { chartZUCHeights, chartZDCHeights});
        }
    }
}
