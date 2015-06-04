using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Imaging;
using System.Drawing;

namespace StatAnalisys
{
    struct generalWavesInfo
    {
        public double zucHSign;
        public double zdcHSign;
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
            ok.Click += (sender, e) => { prompt.Close(); };
            Button no = new Button() { Text = "No" };
            no.Click += (sender, e) =>
            {
                cbGraphic.Checked = false;
                cbHeights.Checked = false;
                cbProb.Checked = false;
                prompt.Close();
            };

            panel.Controls.Add(ok);
            panel.Controls.Add(no);
            prompt.Controls.Add(panel);
            prompt.ShowDialog();

            return new bool[] { cbGraphic.Checked, cbHeights.Checked, cbProb.Checked };
        }
    }
    public static class CallBackRogueWaveSelected
    {
        public delegate void callbackRogueWaveSelectedEvent(string str);
        public static callbackRogueWaveSelectedEvent callbackRogueWaveSelectedEventHandler;
    }

    public static class CallBackFileSelected
    {
        public delegate void callbackFileSelectedEvent(string str);
        public static callbackFileSelectedEvent callbackFileSelectedEventHandler;
    }
}
