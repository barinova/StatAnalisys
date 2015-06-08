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
using System.Text.RegularExpressions;

namespace StatAnalisys
{

    public partial class MainForm : BaseForm
    {
        CCalculatedWaves currentArrayWaves;
        CSingleWave currentWave;
        double[] currentArrayT;
        double[][] currentArrayS;
        double selectedX = 0;
        List<string> fileNames = new List<string>();


        public MainForm()
        {
            InitializeComponent();

            CallBackRogueWaveSelected.callbackRogueWaveSelectedEventHandler = new CallBackRogueWaveSelected.callbackRogueWaveSelectedEvent(openRogueWaveHeightsDiagram);
            CallBackFileSelected.callbackFileSelectedEventHandler = new CallBackFileSelected.callbackFileSelectedEvent(openFile);
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

            openFileDialog.Multiselect = true;
        }

        void ClearAll()
        {
            currentArrayWaves = null;
            currentWave = null;
            currentArrayT = null;
            currentArrayS = null;
            fileNames.Clear();
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
                Regex regex = new Regex(@"[^\\]*$",RegexOptions.IgnoreCase| RegexOptions.CultureInvariant
                    | RegexOptions.IgnorePatternWhitespace| RegexOptions.Compiled);

                    foreach (String file in openFileDialog.FileNames)
                    {
                        currentArrayWaves = null;
                        currentWave = null;

                        txtOutput.Text = txtOutput.Text + "Attempting to read the file '" + file + "'...";

                        Console.WriteLine(file);

                        if (!fileNames.Contains(file))
                        {
                            try
                            {
                                this.Cursor = Cursors.WaitCursor;
                                fileNames.Add(file);
                            }
                            catch (System.IO.IOException)
                            {
                                this.Cursor = Cursors.Default;
                                txtOutput.Text = txtOutput.Text + "Invalid MAT-file!\n";
                                MessageBox.Show("Invalid binary MAT-file! Please select a valid binary MAT-file.",
                                    "Invalid MAT-file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The file " + file + " is already opened.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                   // saveXLSFileToolStripMenuItem.PerformClick();

                this.Cursor = Cursors.Default;
            }
        }

        private CCalculatedWaves loadAndCalculateFromMatFile(string file)
        {
            readMatFile(file);

            CCalculatedWaves arrayWaves = new CCalculatedWaves();                 
            arrayWaves = calculateWavesDatas(file);

            return arrayWaves;
        }

        private void readMatFile(string file)
        {
            MatFileReader mfr = new MatFileReader(file);
            txtOutput.Text += "Done!\nMAT-file contains the following:\n";
            txtOutput.Text += mfr.MatFileHeader.ToString() + "\n";
            foreach (MLArray mla in mfr.Data)
            {
                if (String.Equals(mla.Name, "t"))
                {
                    MLDouble mlT = (mla as MLDouble);
                    currentArrayT = mlT.GetArray()[0];
                }

                if (String.Equals(mla.Name, "s"))
                {
                    MLDouble mlS = (mla as MLDouble);
                    currentArrayS = mlS.GetArray();
                }
            }
        }
        private void chartGeneralGraphic_SelectionRangeChanged(object sender, ViewEventArgs e)
        {
            int indexWave = -1;

            if (textBoxNumWave.Text != string.Empty && Int32.TryParse(textBoxNumWave.Text, out indexWave))
            {
                
            }

            if (indexWave > -1 && currentWave != null)
            {
                int start = (int)e.Axis.ScaleView.ViewMinimum;
                int end = (int)e.Axis.ScaleView.ViewMaximum;

                double currentPoint = start + (end - start) / 2;

                if (selectedX != currentPoint)
                {
                    double x1, x2, x3, x4, x5, y1, y2, y3, y4, y5;
                    waveData selectedWave;
                    selectedX = currentPoint;
                    selectedWave = currentWave.calculatingWaves.FirstOrDefault(c => c.nullPoint[0] < selectedX && c.nullPoint[2] > selectedX);

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
            labelNumWaves.Text = "Enter number of wave (0 - " + (size - 1) + ")";
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
            int interval = currentWave.interval;
            int t = interval;
            int i = 0;

            foreach (double p in currentWave.listSighificiantPeriods)
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
        private CCalculatedWaves calculateWavesDatas(string name)
        {
            CCalculatedWaves currentArrayWaves = new CCalculatedWaves();
            currentArrayWaves.calculateDatas(currentArrayT, currentArrayS);
            return currentArrayWaves;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int indexWave;

            if (Int32.TryParse(textBoxNumWave.Text, out indexWave))
            {
                if (indexWave > -1 && currentWave != null)
                {
                    chartGeneralGraphic.Series[1].Points.Clear();
                    renderingTroughsAndRidges(currentWave);
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
            if (currentArrayWaves != null)
            {
                List<rogueWave> rWaves = currentArrayWaves.rougeWaves;

                if (rWaves.Count > 0)
                {
                    CRougeWaveForm rougeForm = new CRougeWaveForm();
                    rougeForm.setLabelNumRogueWaves(currentArrayWaves.countRogueWaves.ToString());

                    foreach (rogueWave rWave in rWaves)
                    {
                        if (rWave.num > -1)
                        {
                            CSingleWave wave = currentArrayWaves[rWave.num];
                            rougeForm.addRow(rWave.num.ToString(), rWaves.Find(x => x.num == rWave.num).count.ToString(), wave.heightsZDC.significantHeight,
                                wave.heightsZUC.significantHeight);
                        }
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
            CHeightsDiagram diagHeights = new CHeightsDiagram(textBoxNumWave.Text);

            diagHeights.renderHeights(currentWave.heightsZDC.heightOneThird, currentWave.heightsZDC.significantHeight,
                currentWave.heightsZUC.heightOneThird, currentWave.heightsZUC.significantHeight, currentWave.listHeihtsZDC, currentWave.listHeihtsZUC);
            diagHeights.Show();
        }

        private void ProbabilitiesDiagram_Click(object sender, EventArgs e)
        {
            CProbabilitiesDiagram diagProbabilities = new CProbabilitiesDiagram(textBoxNumWave.Text);
            diagProbabilities.renderProbabilities(typeCrossing.ZDC, currentWave.probabilitiesZDC, currentWave.heightsZDC.significantHeight);
            diagProbabilities.renderProbabilities(typeCrossing.ZUC, currentWave.probabilitiesZUC, currentWave.heightsZUC.significantHeight);
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

            if (currentArrayS != null)
            {
                if (!Int32.TryParse(textBoxNumWave.Text, out indexWave) || indexWave > currentArrayS.Count() || indexWave < 0)
                {
                    MessageBox.Show("Wave doesn't found", "Wave", MessageBoxButtons.OK);
                }
                else
                {
                    changeEnabledSettingsComponents(true);
                    clearGraphics();
                    double[] heights = currentArrayS[indexWave];

                    for (int i = 1; i < currentArrayT.Count(); i++)
                    {
                        chartGeneralGraphic.Series[0].Points.AddXY(currentArrayT[i - 1], heights[i - 1]);
                        chartGeneralGraphic.Series[0].Points.AddXY(currentArrayT[i], heights[i]);
                    }

                    currentWave = currentArrayWaves[indexWave];
                    rendeRogueWavesInGeneralGraphic(currentWave, indexWave);
                    renderChartOfWavesPeriods();
                    labelIntervalsPeriod.Text = "Chart of Waves Periods( Interval = " + currentWave.interval + ")";
                }
            }
        }

        private void rendeRogueWavesInGeneralGraphic(CSingleWave currentWave, int indexWave)
        {
            if (currentArrayWaves.rougeWaves.Exists(x => x.num == indexWave))
            { 
                rogueWave rWave = currentArrayWaves.rougeWaves.Find(x => x.num == indexWave);
                int k = 0;

                for (int i = 0; i < rWave.points.Count(); i+=5)
                {
                    Series s = new Series();
                    s.IsVisibleInLegend = false;
                    s.Color = Color.Orange;
                    s.ChartType = SeriesChartType.Spline;
                    s.BorderWidth = 2;

                    chartGeneralGraphic.Series.Add(s);

                    s.Points.AddXY(rWave.points[i], 0);
                    s.Points.AddXY(rWave.points[i + 1], rWave.h[k]);
                    s.Points.AddXY(rWave.points[i + 2], 0);
                    s.Points.AddXY(rWave.points[i + 3], rWave.h[k + 1]);
                    s.Points.AddXY(rWave.points[i + 4], 0);
                    k += 2;
                }
            }
        }

        private void buttonClouds_Click(object sender, EventArgs e)
        {
            if (currentWave != null)
            {
                CClouds cloudsForm = new CClouds(textBoxNumWave.Text);
                cloudsForm.renderClouds(currentWave.cloudsVertZDC, currentWave.cloudsVertZUC, currentWave.cloudsHorZDC,
                    currentWave.cloudsHorZUC);
                cloudsForm.Show();
            }
            
        }

        public void openRogueWaveHeightsDiagram(string index)
        {
            if (index != "-1")
            {
                int i = Int32.Parse(index);

                //open heights diagram
                /*CHeightsDiagram diagHeights = new CHeightsDiagram(i.ToString());
                diagHeights.renderHeights(currentArrayWaves[i].heightsZDC.heightOneThird, currentArrayWaves[i].heightsZDC.significantHeight,
                    currentArrayWaves[i].heightsZUC.heightOneThird, currentArrayWaves[i].heightsZUC.significantHeight,
                    currentArrayWaves[i].listHeihtsZDC, currentArrayWaves[i].listHeihtsZUC);
                diagHeights.Show();*/

                //main
                this.textBoxNumWave.Text = index;
                buttonNumWave.PerformClick();
            }
        }

        public void openFile(string fileName)
        {
            textBoxLoadFile.Text = fileName;

            if (fileNames.Contains(fileName))
            {
                currentArrayWaves = loadAndCalculateFromMatFile(fileName);
                updateComboBoxNumberWaveValues(currentArrayT.Count());
            }
            else
            {
                MessageBox.Show("Please try to reload file " + fileName, "File " + fileName + " " + "was not loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            CLoadedFilesForm loadedFilesForm = new CLoadedFilesForm(fileNames);
        }

        private void saveXLSFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileNames != null)
            {
                CExcelFile xlsFile = new CExcelFile();
                List<string> listFileName = new List<string>();
                List<double> zucHSign = new List<double>();
                List<double> zdcHSign = new List<double>();
                List<int> generalCountRogueWaves = new List<int>();
                List<int> countRogueWaves = new List<int>();
                List<List<generalWavesInfo>> generalWavesInfoForeach = new List<List<generalWavesInfo>>();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLS file|*.xls";
                saveFileDialog.Title = "Save XLS file";
                DialogResult result = saveFileDialog.ShowDialog();
                saveFileDialog.RestoreDirectory = true;
                List<int> rogueWavesZUC = new List<int>();
                List<int> rogueWavesZDC = new List<int>();
                int count = 0;

                if (result == DialogResult.OK)
                {
                    if (saveFileDialog.FileName != "")
                    {
                        if (saveFileDialog.CheckPathExists)
                        {
                            this.Cursor = Cursors.WaitCursor;

                            foreach (string file in fileNames)
                            {
                                CCalculatedWaves listWaves = loadAndCalculateFromMatFile(file);
                                List<generalWavesInfo> tmp = new List<generalWavesInfo>();

                                for (int i = 0; i < listWaves.waves.Count(); i++ )
                                {
                                    generalWavesInfo info;
                                    info.zucHSign = listWaves.waves[i].heightsZUC.significantHeight;
                                    info.zdcHSign = listWaves.waves[i].heightsZDC.significantHeight;
                                    tmp.Add(info);
                                }

                                countRogueWaves.Add(listWaves.countRogueWaves);
                                generalWavesInfoForeach.Add(tmp);
                                listFileName.Add(file);
                                zucHSign.Add(listWaves.generalSighHZUC);
                                zdcHSign.Add(listWaves.generalSighHZDC);
                                generalCountRogueWaves.Add(listWaves.generalCountRogueWavesZUC + listWaves.generalCountRogueWavesZDC);
                                rogueWavesZUC.Add(listWaves.countRogueWavesZUC);
                                rogueWavesZDC.Add(listWaves.countRogueWavesZUC);
                                count++;
                            }

                            if (!xlsFile.saveXLS(saveFileDialog.FileName, listFileName, zucHSign, zdcHSign, generalCountRogueWaves, countRogueWaves, generalWavesInfoForeach, rogueWavesZUC, rogueWavesZDC))
                            {
                                MessageBox.Show("Error to save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            this.Cursor = Cursors.Default;
                        }
                    }
                }
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

    }

    
    
}
