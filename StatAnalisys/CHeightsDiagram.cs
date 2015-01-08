using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            chartZDCHeights.Series[1].Color = Color.Pink;
            chartZUCHeights.Series[1].Color = Color.Pink;
            chartZDCHeights.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chartZUCHeights.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
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

            textBoxHeightsThirdZDC.Text = listHeightsZDCThird.ToString();
            textBoxHeightsSighZDC.Text = listHeightsZDCSign.ToString();

            textBoxHeightsThirdZUC.Text = listHeightsZUCThird.ToString();
            textBoxHeightsSighZUC.Text = listHeightsZUCSign.ToString();

            chartZDCHeights.Series[1].Points.Add(listHeightsZDCSign);
            chartZUCHeights.Series[1].Points.Add(listHeightsZUCSign);
        }
    }
}
