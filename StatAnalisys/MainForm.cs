using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csmatio.types;
using csmatio.io;

namespace StatAnalisys
{
    public partial class MainForm : Form
    {

        CCalculatedWaves arrayWaves;

        double[] arrayT;
        double[][] arrayS;
        public MainForm()
        {
            InitializeComponent();
            chartGeneralGraphic.Series[0]["PixelPointWidth"] = "1";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dRes = openFileDialog.ShowDialog();
            if (dRes == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                txtOutput.Text = txtOutput.Text + "Attempting to read the file '" + fileName + "'...";
                try
                {
                    MatFileReader mfr = new MatFileReader(fileName);
                    txtOutput.Text += "Done!\nMAT-file contains the following:\n";
                    txtOutput.Text += mfr.MatFileHeader.ToString() + "\n";
                    foreach (MLArray mla in mfr.Data)
                    {
                        if (String.Equals(mla.Name, "t"))
                        {
                            MLDouble mlT = (mla as MLDouble);
                            arrayT = mlT.GetArray()[0];
                        }

                        if (String.Equals(mla.Name, "s"))
                        {
                            MLDouble mlS = (mla as MLDouble);
                            arrayS = mlS.GetArray();
                        }
                    }


                    this.Cursor = Cursors.WaitCursor;

                    updateComboBoxNumberWaveValues(arrayS.Count());
                    calculateWavesDatas();

                    this.Cursor = Cursors.Default;
                    zoomInGraphic();
                }
                catch (System.IO.IOException)
                {
                    txtOutput.Text = txtOutput.Text + "Invalid MAT-file!\n";
                    MessageBox.Show("Invalid binary MAT-file! Please select a valid binary MAT-file.",
                        "Invalid MAT-file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                    
            }
        }

        private void zoomInGraphic()
        {

            chartGeneralGraphic.ChartAreas[0].AxisY.ScaleView.Zoom(-3, 3);
        }
        private void comboBoxNumWave_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexWave = comboBoxNumWave.SelectedIndex;

            if (indexWave > -1)
            {
                chartGeneralGraphic.Series[0].Points.Clear();

                double [] heights = arrayS[indexWave];

                for (int i = 1; i < arrayT.Count(); i++)
                {
                    chartGeneralGraphic.Series[0].Points.AddXY(arrayT[i - 1], heights[i - 1]);
                    chartGeneralGraphic.Series[0].Points.AddXY(arrayT[i], heights[i]);
                }
            }
        }
        private void chartGeneralGraphic_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                double xMin = chartGeneralGraphic.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                double xMax = chartGeneralGraphic.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                double yMin = chartGeneralGraphic.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                double yMax = chartGeneralGraphic.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                double posXStart = chartGeneralGraphic.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin);
                double posXFinish = chartGeneralGraphic.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin);
                double posYStart = chartGeneralGraphic.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin);
                double posYFinish = chartGeneralGraphic.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin);
                
                if (e.Delta < 0)
                {
                    chartGeneralGraphic.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart * 4, posXFinish * 4);
                    chartGeneralGraphic.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart * 4, posYFinish * 4);
                }

                if (e.Delta > 0)
                {
                    chartGeneralGraphic.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart / 4, posXFinish / 4);
                    chartGeneralGraphic.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart / 4, posYFinish / 4);
                }

            }
            catch { }
        }
        private void chartGeneralGraphic_MouseLeave(object sender, EventArgs e)
        {
            if (chartGeneralGraphic.Focused)
                chartGeneralGraphic.Parent.Focus();
        }

        private void chartGeneralGraphic_MouseEnter(object sender, EventArgs e)
        {
            if (!chartGeneralGraphic.Focused)
                chartGeneralGraphic.Focus();
        }

        //update possible number of wave
        private void updateComboBoxNumberWaveValues(int size)
        {
            for (int i = 0 ;  i < size; i++)
            {
                comboBoxNumWave.Items.Add(i.ToString());
            }
        }

        //calculate waves datas
        private void calculateWavesDatas()
        {
            arrayWaves = new CCalculatedWaves();
            arrayWaves.calculateDatas(arrayT, arrayS);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int indexWave = comboBoxNumWave.SelectedIndex;

            if (indexWave > -1)
            {
                CSingleWave wave = arrayWaves[indexWave];
                renderingTroughsAndRidges(wave);
                panelGraphic.Enabled = true;
            }
        }

        private void renderingTroughsAndRidges(CSingleWave wave)
        {
            List<waveData> listWavesDatas = wave.calculatingWaves;

            if (listWavesDatas != null)
            {
                waveData param;
                chartGeneralGraphic.Series[1].Font = new Font("Arial", 7);
                chartGeneralGraphic.Series[1].Color = System.Drawing.Color.Green;

                for (int i = 0; i < listWavesDatas.Count() - 1; i++)
                {
                    param = listWavesDatas.ElementAt(i);
                    int indS;
                    if (param.ridge < param.trough)
                    {
                        indS = chartGeneralGraphic.Series[1].Points.AddXY(param.ridge, param.amplMax);
                        chartGeneralGraphic.Series[1].Points[indS].Label = Math.Round(param.amplMax, 3).ToString();
                    }
                    else
                    {
                        indS = chartGeneralGraphic.Series[1].Points.AddXY(param.trough, param.amplMin);
                        chartGeneralGraphic.Series[1].Points[indS].Label = Math.Round(param.amplMin, 3).ToString();
                    }

                }
            }
        }

        private void buttonZoomReset_Click(object sender, EventArgs e)
        {
            chartGeneralGraphic.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chartGeneralGraphic.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

        private void buttonOpenGraphic_Click(object sender, EventArgs e)
        {
            int index = comboBoxNumWave.SelectedIndex;

            if (index > -1)
            {
                // 0 - heights diagram
                if (index == 0)
                {
                    CSingleWave wave = arrayWaves[index];
                    CHeightsDiagram diagHeights = new CHeightsDiagram();
                    diagHeights.renderHeights(wave.heightsZDC.heightOneThird, wave.heightsZDC.significantHeight,
                        wave.heightsZUC.heightOneThird, wave.heightsZUC.significantHeight, wave.listHeihtsZDC, wave.listHeihtsZUC);
                    diagHeights.Show();
                }
            }
        }



    }
}
