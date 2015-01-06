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

                    updateComboBoxNumberWaveValues(arrayS.Count());
                    calculateWavesDatas();
                }
                catch (System.IO.IOException)
                {
                    txtOutput.Text = txtOutput.Text + "Invalid MAT-file!\n";
                    MessageBox.Show("Invalid binary MAT-file! Please select a valid binary MAT-file.",
                        "Invalid MAT-file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                    
            }
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
                
            }
        }
    }
}
