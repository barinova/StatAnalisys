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
    public partial class CClouds : BaseForm
    {
        public CClouds()
        {
            InitializeComponent();
        }

        public void renderClouds(double hSignZDC, double hSignZUC, List<waveData> waves)
        {
            double x, y;

            foreach (waveData wave in waves)
            { 
                switch (wave.type)
                {
                    case typeCrossing.ZDC:
                        x = wave.totalHeight/hSignZDC;
                        y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry));
                        chartCloudsZDCVert.Series[0].Points.AddXY(x, y);
                        y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry));
                        chartCloudsZDCHor.Series[0].Points.AddXY(x, y);
                        break;

                    case typeCrossing.ZUC:
                        x = wave.totalHeight / hSignZUC;
                        y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry));
                        chartCloudsZUCVert.Series[0].Points.AddXY(x, y);
                        y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry));
                        chartCloudsZUCHor.Series[0].Points.AddXY(x, y);
                        break;
                }

                ;
            }
        }
    }
}
