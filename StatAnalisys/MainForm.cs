using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using csmatio.types;
using csmatio.io;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.IO;
using System.Drawing.Imaging;

namespace StatAnalisys
{
    
    public partial class MainForm : BaseForm
    {

        CCalculatedWaves arrayWaves;
        CSingleWave wave;
        double[] arrayT;
        double[][] arrayS;
        double selectedX = 0; 
        
        public MainForm()
        {
            InitializeComponent();

            setupUISettings();            
            changeEnabledSettingsComponents(false);
        }

        void setupUISettings()
        {
            chartGeneralGraphic.Series[1]["PixelPointWidth"] = "1";
            chartZommedWave.Series[1]["PixelPointWidth"] = "1";
            chartZommedWave.ChartAreas[0].AxisY.TitleFont = new Font("Sans Serif", 10, FontStyle.Bold);
            chartZommedWave.ChartAreas[0].AxisY.Title = "H";
            chartZommedWave.ChartAreas[0].AxisX.TitleFont = new Font("Sans Serif", 10, FontStyle.Bold);
            chartZommedWave.ChartAreas[0].AxisX.Title = "T";
            chartZommedWave.Series[2].MarkerStyle = MarkerStyle.Star5;
            chartZommedWave.Series[3].MarkerStyle = MarkerStyle.Star5;
            chartZommedWave.Series[2].Color = Color.Orange;
            chartZommedWave.Series[3].Color = Color.Orange;
            chartZommedWave.Series[2].Font = new Font("Arial", 8);
            chartZommedWave.Series[3].Font = new Font("Arial", 8);
            chartGeneralGraphic.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartGeneralGraphic.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartGeneralGraphic.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartWavesPeriods.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartWavesPeriods.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }
        
        void changeEnabledSettingsComponents(bool value)
        {
            buttonHeightsDiagram.Enabled = value;
            ProbabilitiesDiagram.Enabled = value;
            buttonClouds.Enabled = value;
            saveImagesToolStripMenuItem.Enabled = value;
        }

        void clearGraphics()
        {
            foreach ( Series s in chartZommedWave.Series)
            {
                s.Points.Clear();
            }

            foreach (Series s in chartGeneralGraphic.Series)
            {
                s.Points.Clear();
            }

            foreach (Series s in this.chartWavesPeriods.Series)
            {
                s.Points.Clear();
            }
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
                    this.Cursor = Cursors.WaitCursor;
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

                    updateComboBoxNumberWaveValues(arrayS.Count());
                    calculateWavesDatas();

                    this.Cursor = Cursors.Default;
                }
                catch (System.IO.IOException)
                {
                    this.Cursor = Cursors.Default;
                    txtOutput.Text = txtOutput.Text + "Invalid MAT-file!\n";
                    MessageBox.Show("Invalid binary MAT-file! Please select a valid binary MAT-file.",
                        "Invalid MAT-file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void chartGeneralGraphic_SelectionRangeChanged(object sender, ViewEventArgs e)
        {

            int indexWave = -1;

            if (textBoxNumWave.Text != string.Empty && Int32.TryParse(textBoxNumWave.Text, out indexWave))
            {
                
            }

            if (indexWave > -1 && wave != null)
            {
                int start = (int)e.Axis.ScaleView.ViewMinimum;
                int end = (int)e.Axis.ScaleView.ViewMaximum;

                double currentPoint = start + (end - start) / 2;

                if (selectedX != currentPoint)
                {
                    double x1, x2, x3, x4, x5, y1, y2, y3, y4, y5;
                    waveData selectedWave;
                    selectedX = currentPoint;
                    selectedWave = wave.calculatingWaves.FirstOrDefault(c => c.nullPoint[0] < selectedX && c.nullPoint[2] > selectedX);

                    if (selectedWave.nullPoint != null)
                    {
                        y1 = y3 = y5 = 0;
                        x1 = selectedWave.nullPoint[0];
                        x3 = selectedWave.nullPoint[1];
                        x5 = selectedWave.nullPoint[2];

                        if (selectedWave.type == typeCrossing.ZUC)
                        {
                            x2 = selectedWave.ridge;
                            y2 = selectedWave.amplMax;
                            x4 = selectedWave.trough;
                            y4 = selectedWave.amplMin;
                        }
                        else
                        {
                            x4 = selectedWave.ridge;
                            y4 = selectedWave.amplMax;
                            x2 = selectedWave.trough;
                            y2 = selectedWave.amplMin;
                        }

                        chartGeneralGraphic.Series[2].Points.Clear();
                        hightliteWaveOnChart(x1, x2, x3, x4, x5, y1, y2, y3, y4, y5, chartGeneralGraphic.Series[2]);
                        fillParametresTextBoxes(selectedWave.amplMax, selectedWave.amplMin, x5 - x1, selectedWave.type);
                        renderSelectedWaveChart(x1, x2, x3, x4, x5, y1, y2, y3, y4, y5, selectedWave);
                    }
                }
            }

        }

        void renderSelectedWaveChart(double x1, double x2, double x3, double x4, double x5, double y1, double y2, double y3,
            double y4, double y5, waveData selectedWave)
        {
            foreach (Series s in chartZommedWave.Series)
            {
                s.Points.Clear();
            }

            hightliteWaveOnChart(x1, x2, x3, x4, x5, y1, y2, y3, y4, y5, chartZommedWave.Series[0]);

            chartZommedWave.Series[1].Points.AddXY(x2, y2);
            chartZommedWave.Series[1].Points.AddXY(x4, y4);

           // chartZommedWave.Series[2].Points.AddXY(x1 - 0.5, y2);
            //chartZommedWave.Series[2].Points.AddXY(x1 - 0.5, y4);
            //chartZommedWave.Series[2].Points[y2 > y4 ? 0 : 1].Label = Math.Round(selectedWave.totalHeight, 3).ToString();

            //chartZommedWave.Series[3].Points.AddXY(x1 - 0.5, y2 < y4 ? y2 : y4);
            //chartZommedWave.Series[3].Points.AddXY(x5 - 0.5, y2 < y4 ? y2 : y4);
            //chartZommedWave.Series[3].Points[1].Label = Math.Round(x5 - x1, 3).ToString();
        }

        //update possible number of wave
        private void updateComboBoxNumberWaveValues(int size)
        {
            labelNumWaves.Text = "Enter number of wave (1 - " + (size) + ")";
        }

        private void hightliteWaveOnChart(double x1, double x2, double x3, double x4, double x5, double y1, double y2, double y3, 
            double y4, double y5, Series series)
        {
            series.Color = Color.Red;
            series.Points.AddXY(x1, y1);
            series.Points.AddXY(x2, y2);
            series.Points.AddXY(x3, y3);
            series.Points.AddXY(x4, y4);
            series.Points.AddXY(x5, y5);
        }

        private void fillParametresTextBoxes(double amplPlus, double amplMinus, double t, typeCrossing type)
        {
            textBoxAmplitudePlus.Text = amplPlus.ToString();
            textBoxAmplitudeMinus.Text = amplMinus.ToString();
            textBoxT.Text = t.ToString();
            textBoxType.Text = type.ToString();
        }

        private void renderChartOfWavesPeriods()
        {
            int interval = wave.interval;
            int t = interval;
            int i = 0;

            foreach (double p in wave.listSighificiantPeriods)
            {
                chartWavesPeriods.Series[0].Points.AddXY(t, p);
                chartWavesPeriods.Series[0].Points[i].Label = Math.Round(p, 3).ToString();
                t += interval;
                i++;
            }
        }

        private void chartClipboard(Chart chart, double startX, double startY, double endX, double endY)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                chart.SaveImage(ms, ChartImageFormat.Bmp);
                Bitmap bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }
        }
        private void saveImage(System.Drawing.Imaging.ImageFormat format, string name)
        {
            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(DataFormats.Bitmap))
            {
                Image image = (Image)data.GetData(DataFormats.Bitmap, true);
                image.Save(name, format);
            }
            else
            {
                MessageBox.Show("The Data In Clipboard is not as image format");
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
            int indexWave;

            if (Int32.TryParse(textBoxNumWave.Text, out indexWave))
            {
                if (indexWave > -1 && wave != null)
                {
                    chartGeneralGraphic.Series[1].Points.Clear();
                    renderingTroughsAndRidges(wave);
                    panelGraphic.Enabled = true;
                }
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

                for (int i = 0; i < listWavesDatas.Count(); i++)
                {
                    param = listWavesDatas.ElementAt(i);
                    int indS;

                    if (param.ridge < param.trough)
                    {
                        indS = chartGeneralGraphic.Series[1].Points.AddXY(param.ridge, param.amplMax);
                        chartGeneralGraphic.Series[1].Points[indS].Label = Math.Round(param.amplMax, 3).ToString();

                        if (listWavesDatas.Count() - 1 == i)
                        {
                            indS = chartGeneralGraphic.Series[1].Points.AddXY(param.trough, param.amplMin);
                            chartGeneralGraphic.Series[1].Points[indS].Label = Math.Round(param.amplMin, 3).ToString();
                        }
                    }
                    else
                    {
                        indS = chartGeneralGraphic.Series[1].Points.AddXY(param.trough, param.amplMin);
                        chartGeneralGraphic.Series[1].Points[indS].Label = Math.Round(param.amplMin, 3).ToString();

                        if (listWavesDatas.Count() - 1 == i)
                        {
                            indS = chartGeneralGraphic.Series[1].Points.AddXY(param.ridge, param.amplMax);
                            chartGeneralGraphic.Series[1].Points[indS].Label = Math.Round(param.amplMax, 3).ToString();
                        }
                    }

                }

            }
        }

        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage(new Chart[] {chartGeneralGraphic,  chartWavesPeriods});
        }

        private void buttonViewRougeWaves_Click(object sender, EventArgs e)
        {
            if (arrayWaves != null)
            {
                Dictionary<int, int> rWaves = arrayWaves.rougeWaves;

                if (rWaves.Count > 0)
                {
                    CRougeWaveForm rougeForm = new CRougeWaveForm();

                    foreach (int index in rWaves.Keys)
                    {
                        rougeForm.addRow("Wave num.: " + index + "\tRogue waves: " + rWaves[index]);
                    }

                    rougeForm.Show();
                }
                else
                {
                    MessageBox.Show("Rouge waves wasn't found", "Rogue wave", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonHeightsDiagram_Click(object sender, EventArgs e)
        {
            CHeightsDiagram diagHeights = new CHeightsDiagram();

            diagHeights.renderHeights(wave.heightsZDC.heightOneThird, wave.heightsZDC.significantHeight,
                wave.heightsZUC.heightOneThird, wave.heightsZUC.significantHeight, wave.listHeihtsZDC, wave.listHeihtsZUC);
            diagHeights.Show();
        }

        private void ProbabilitiesDiagram_Click(object sender, EventArgs e)
        {
            CProbabilitiesDiagram diagProbabilities = new CProbabilitiesDiagram();
            diagProbabilities.renderProbabilities(typeCrossing.ZDC, wave.probabilitiesZDC, wave.heightsZDC.significantHeight);
            diagProbabilities.renderProbabilities(typeCrossing.ZUC, wave.probabilitiesZUC, wave.heightsZUC.significantHeight);
            diagProbabilities.Show();
        }
        public static void buttonOpenRougeWave_Click(int num)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNumWave_Click(object sender, EventArgs e)
        {
            int indexWave;

            if (arrayS != null)
            {
                if (!Int32.TryParse(textBoxNumWave.Text, out indexWave) || indexWave > arrayS.Count() || indexWave < 1)
                {
                    MessageBox.Show("Wave does't found", "Wave", MessageBoxButtons.OK);
                }
                else
                {
                    indexWave -= 1;
                    changeEnabledSettingsComponents(true);
                    clearGraphics();
                    double[] heights = arrayS[indexWave];

                    for (int i = 1; i < arrayT.Count(); i++)
                    {
                        chartGeneralGraphic.Series[0].Points.AddXY(arrayT[i - 1], heights[i - 1]);
                        chartGeneralGraphic.Series[0].Points.AddXY(arrayT[i], heights[i]);
                    }

                    wave = arrayWaves[indexWave];

                    renderChartOfWavesPeriods();
                    labelIntervalsPeriod.Text = "Chart of Waves Periods( Interval = " + wave.interval + ")";
                }
            }
        }

        private void buttonClouds_Click(object sender, EventArgs e)
        {
            if (wave != null)
            {
                CClouds cloudsForm = new CClouds();
                cloudsForm.renderClouds(wave.heightsZDC.heightOneThird, wave.heightsZUC.heightOneThird, wave.calculatingWaves);
                cloudsForm.Show();
            }
            
        }
    }

    public class BaseForm : Form
    {
        protected void zoom(MouseEventArgs e, System.Windows.Forms.DataVisualization.Charting.ChartArea area, int delta)
        {
            double xMin = area.AxisX.ScaleView.ViewMinimum;
            double xMax = area.AxisX.ScaleView.ViewMaximum;
            double yMin = area.AxisY.ScaleView.ViewMinimum;
            double yMax = area.AxisY.ScaleView.ViewMaximum;

            double posXStart = area.AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin);
            double posXFinish = area.AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin);
            double posYStart = area.AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin);
            double posYFinish = area.AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin);

            if (e.Delta < 0)
            {
                area.AxisX.ScaleView.Zoom(posXStart * delta, posXFinish * delta);
                area.AxisY.ScaleView.Zoom(posYStart * delta, posYFinish * delta);
            }

            if (e.Delta > 0)
            {
                area.AxisX.ScaleView.Zoom(posXStart / delta, posXFinish / delta);
                area.AxisY.ScaleView.Zoom(posYStart / delta, posYFinish / delta);
            }
        }

        protected void zoomReset(Chart chart)
        {
            chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

        public void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            Chart chart = (Chart)sender;

            try
            {
                zoom(e, chart.ChartAreas[0], 2);
            }
            catch { }

        }
        protected void chart_MouseLeave(object sender, EventArgs e)
        {
            Chart chart = (Chart)sender;
            if (chart.Focused)
                chart.Parent.Focus();
        }

        protected void chart_MouseEnter(object sender, EventArgs e)
        {
            Chart chart = (Chart)sender;
            if (!chart.Focused)
                chart.Focus();
        }
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
                if (codec.FormatID == format.Guid)
                    return codec;
            return null;
        }
        private Chart Copy(Chart chart)
        {
            Chart newChart = new Chart();

            foreach (var ca in chart.ChartAreas)
                newChart.ChartAreas.Add(ca);

            foreach (var s in chart.Series)
                newChart.Series.Add(s);

            foreach (var l in chart.Legends)
                newChart.Legends.Add(l);

            foreach (var a in chart.Annotations)
                newChart.Annotations.Add(a);

            return newChart;
        }

        protected void saveImage(Chart[] charts)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG file|*.png";
            saveFileDialog.Title = "Save Charts As Image File";
            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        if (saveFileDialog.CheckPathExists)
                        {
                            foreach (Chart chart in charts)
                            {
                                Chart newChart = Copy(chart);

                                zoomReset(newChart);

                                newChart.Size = new Size(chart.Width * 4, chart.Height * 5);

                                String name = saveFileDialog.FileName.Insert(saveFileDialog.FileName.Count() - 4, chart.Text);

                                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                                myEncoderParameters.Param[0] = new EncoderParameter(myEncoder, 100L);
                                System.IO.MemoryStream mS = new System.IO.MemoryStream();
                                newChart.SaveImage(mS, ChartImageFormat.Png);

                                Image imgImage = Image.FromStream(mS);

                                imgImage.Save(name, GetEncoder(ImageFormat.Png), myEncoderParameters);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Given Path does not exist");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        protected void drawStripLine(Chart chart, double y, Color color, double width)
        {
            StripLine stripLine = new StripLine();
            stripLine.IntervalOffset = y;
            stripLine.BackColor = color;
            stripLine.StripWidth = width;
            chart.ChartAreas[0].AxisY.StripLines.Add(stripLine);
        }
    }

    public static class CheckboxDialog
    {
        public static bool[] ShowDialog(string text, string[] caption)
        {
            Form prompt = new Form();
            FlowLayoutPanel panel = new FlowLayoutPanel();

            CheckBox cbGraphic = new CheckBox();
            cbGraphic.Text = caption[0];
            panel.SetFlowBreak(cbGraphic, true);
            CheckBox cbHeights = new CheckBox();
            cbHeights.Text = caption[1];
            panel.SetFlowBreak(cbHeights, true);
            CheckBox cbProb = new CheckBox();
            cbProb.Text = caption[2];
            panel.SetFlowBreak(cbProb, true);

            panel.Controls.Add(cbGraphic);
            panel.Controls.Add(cbHeights);
            panel.Controls.Add(cbProb);

            Button ok = new Button() { Text = "Yes" };
            ok.Click += (sender, e) => { prompt.Close();};
            Button no = new Button() { Text = "No" };
            no.Click += (sender, e) => { 
                cbGraphic.Checked = false;
                cbHeights.Checked = false;
                cbProb.Checked = false;
                prompt.Close();};
            
            panel.Controls.Add(ok);
            panel.Controls.Add(no);
            prompt.Controls.Add(panel);
            prompt.ShowDialog();

            return new bool[] { cbGraphic.Checked, cbHeights.Checked, cbProb.Checked};
        }
    }
}
