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
    public partial class CProbabilitiesDiagram : Form
    {
        public CProbabilitiesDiagram()
        {
            InitializeComponent();
            tabControlProb.TabPages[0].Text = "-down-zero-crossings";
            tabControlProb.TabPages[1].Text = "-up-zero-crossings";
        }
        public void renderProbabilities(typeCrossing type, List<probability> listProb)
        {
            Chart chart, chartLog;
            probability prob;
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

            for (int i = 0; i < listProb.Count(); i++ )
            {
                prob = listProb[i];

                chart.Series[0].Points.AddXY(prob.H, prob.experP);
                chart.Series[1].Points.AddXY(prob.H, prob.teorP);
                chart.Series[2].Points.AddXY(prob.H, prob.troughP);
                chart.Series[3].Points.AddXY(prob.H, prob.crestP);

                chartLog.Series[0].Points.AddXY(prob.H, Math.Log10(prob.experP));
                chartLog.Series[1].Points.AddXY(prob.H, Math.Log10(prob.teorP));
                chartLog.Series[2].Points.AddXY(prob.H, Math.Log10(prob.troughP));
                chartLog.Series[3].Points.AddXY(prob.H, Math.Log10(prob.crestP));
            }
        }

        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Images.saveImage(new Chart[] { chartZDC, chartZDCLog, chartZUC, chartZUCLog });
        }
    }

}
